namespace Bolshodonov
{
    partial class FormProvisor
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnArrivals;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnArrivals = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // lblUser
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUser.Location = new System.Drawing.Point(12, 8);
            this.lblUser.Size = new System.Drawing.Size(500, 25);
            this.lblUser.Text = "Провизор:";
            // bindingNavigator1
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.bindingNavigatorMoveFirstItem, this.bindingNavigatorMovePreviousItem,
                this.bindingNavigatorSeparator, this.bindingNavigatorPositionItem,
                this.bindingNavigatorCountItem, this.bindingNavigatorSeparator1,
                this.bindingNavigatorMoveNextItem, this.bindingNavigatorMoveLastItem,
                this.bindingNavigatorSeparator2, this.bindingNavigatorAddNewItem,
                this.bindingNavigatorDeleteItem, this.btnSave});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 38);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(900, 25);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorMoveFirstItem.Text = "<<";
            this.bindingNavigatorMovePreviousItem.Text = "<";
            this.bindingNavigatorMoveNextItem.Text = ">";
            this.bindingNavigatorMoveLastItem.Text = ">>";
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.Width = 40;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // dataGridView1
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Size = new System.Drawing.Size(876, 350);
            // buttons
            this.btnMedicines.Location = new System.Drawing.Point(12, 435);
            this.btnMedicines.Size = new System.Drawing.Size(120, 32);
            this.btnMedicines.Text = "Лекарства";
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            this.btnArrivals.Location = new System.Drawing.Point(140, 435);
            this.btnArrivals.Size = new System.Drawing.Size(120, 32);
            this.btnArrivals.Text = "Приход";
            this.btnArrivals.Click += new System.EventHandler(this.btnArrivals_Click);
            this.btnSales.Location = new System.Drawing.Point(268, 435);
            this.btnSales.Size = new System.Drawing.Size(120, 32);
            this.btnSales.Text = "Продажи";
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            this.btnLogout.Location = new System.Drawing.Point(768, 435);
            this.btnLogout.Size = new System.Drawing.Size(120, 32);
            this.btnLogout.Text = "Выйти";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // Form
            this.ClientSize = new System.Drawing.Size(900, 480);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMedicines);
            this.Controls.Add(this.btnArrivals);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnLogout);
            this.Name = "FormProvisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Провизор — Управление аптекой";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
