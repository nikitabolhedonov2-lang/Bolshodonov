namespace Bolshodonov
{
    partial class FormCashier
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnMySales;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnMySales = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(12, 12);
            this.lblUser.Size = new System.Drawing.Size(400, 25);
            this.lblUser.Text = "Кассир:";
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 320);
            this.btnMedicines.Location = new System.Drawing.Point(12, 385);
            this.btnMedicines.Size = new System.Drawing.Size(140, 32);
            this.btnMedicines.Text = "Лекарства";
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            this.btnMySales.Location = new System.Drawing.Point(160, 385);
            this.btnMySales.Size = new System.Drawing.Size(140, 32);
            this.btnMySales.Text = "Мои продажи";
            this.btnMySales.Click += new System.EventHandler(this.btnMySales_Click);
            this.btnLogout.Location = new System.Drawing.Point(652, 385);
            this.btnLogout.Size = new System.Drawing.Size(120, 32);
            this.btnLogout.Text = "Выйти";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.ClientSize = new System.Drawing.Size(784, 430);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMedicines);
            this.Controls.Add(this.btnMySales);
            this.Controls.Add(this.btnLogout);
            this.Name = "FormCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кассир — Продажа";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
