using System;
using System.Windows.Forms;

namespace Bolshodonov
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var user = DbHelper.Authenticate(login, password);
                if (user == null)
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    return;
                }
                this.Hide();
                if (user.Value.role == "provisor")
                {
                    var f = new FormProvisor(user.Value.login);
                    f.FormClosed += (s, a) => this.Show();
                    f.Show();
                }
                else
                {
                    var f = new FormCashier(user.Value.login, user.Value.id);
                    f.FormClosed += (s, a) => this.Show();
                    f.Show();
                }
                txtLogin.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
