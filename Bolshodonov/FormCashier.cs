using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bolshodonov
{
    public partial class FormCashier : Form
    {
        private int _cashierId;

        public FormCashier(string login, int cashierId)
        {
            _cashierId = cashierId;
            InitializeComponent();
            lblUser.Text = "Кассир: " + login;
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            dataGridView1.DataSource = DbHelper.ExecuteQuery(
                "SELECT medicine_id AS [ID], name AS [Название], selling_price AS [Цена], stock AS [В наличии] FROM Medicines WHERE stock > 0 ORDER BY name");
        }

        private void btnMySales_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbHelper.ExecuteQuery(
                "SELECT sale_id AS [N], sale_datetime AS [Дата], total_amount AS [Сумма] FROM Sales WHERE cashier_id=@id ORDER BY sale_datetime DESC",
                new SqlParameter("@id", _cashierId));
        }

        private void btnMedicines_Click(object sender, EventArgs e) { LoadMedicines(); }
        private void btnLogout_Click(object sender, EventArgs e) { Close(); }
    }
}
