namespace Bolshodonov
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(340, 35);
            this.lblTitle.Text = "Аптека — Авторизация";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Location = new System.Drawing.Point(40, 70);
            this.lblLogin.Size = new System.Drawing.Size(70, 20);
            this.lblLogin.Text = "Логин:";
            this.txtLogin.Location = new System.Drawing.Point(120, 68);
            this.txtLogin.Size = new System.Drawing.Size(200, 20);
            this.lblPassword.Location = new System.Drawing.Point(40, 110);
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.Text = "Пароль:";
            this.txtPassword.Location = new System.Drawing.Point(120, 108);
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.PasswordChar = '*';
            this.btnEnter.Location = new System.Drawing.Point(70, 155);
            this.btnEnter.Size = new System.Drawing.Size(100, 30);
            this.btnEnter.Text = "Войти";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            this.btnExit.Location = new System.Drawing.Point(190, 155);
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.ClientSize = new System.Drawing.Size(380, 210);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
