using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bolshodonov
{
    public partial class FormProvisor : Form
    {
        private string _login;
        private SqlDataAdapter _adapter;
        private DataTable _table;

        public FormProvisor(string login)
        {
            _login = login;
            InitializeComponent();
            lblUser.Text = "Провизор: " + login;
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            var conn = new SqlConnection(DbHelper.ConnectionString);
            _adapter = new SqlDataAdapter(
                "SELECT medicine_id, name, manufacturer, cost_price, selling_price, stock, expiry_date, prescription_required FROM Medicines", conn);
            new SqlCommandBuilder(_adapter);
            _table = new DataTable();
            _adapter.Fill(_table);
            bindingSource1.DataSource = _table;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            SetHeaders(new[] { "ID", "Название", "Производитель", "Себестоимость", "Цена", "Остаток", "Срок годности", "Рецепт" });
        }

        private void SetHeaders(string[] headers)
        {
            for (int i = 0; i < headers.Length && i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].HeaderText = headers[i];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _adapter.Update(_table);
                MessageBox.Show("Данные сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArrivals_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbHelper.ExecuteQuery(
                @"SELECT a.arrival_id AS [ID], m.name AS [Лекарство], s.name AS [Поставщик],
                         a.quantity AS [Кол-во], a.arrival_date AS [Дата], e.login AS [Сотрудник]
                  FROM Arrivals a
                  JOIN Medicines m ON a.medicine_id = m.medicine_id
                  JOIN Suppliers s ON a.supplier_id = s.supplier_id
                  JOIN Employees e ON a.employee_id = e.employee_id");
            bindingNavigator1.BindingSource = null;
        }

        private void btnMedicines_Click(object sender, EventArgs e) { LoadMedicines(); }

        private void btnSales_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbHelper.ExecuteQuery(
                @"SELECT s.sale_id AS [ID], s.sale_datetime AS [Дата], e.login AS [Кассир], s.total_amount AS [Сумма]
                  FROM Sales s JOIN Employees e ON s.cashier_id = e.employee_id ORDER BY s.sale_datetime DESC");
            bindingNavigator1.BindingSource = null;
        }

        private void btnLogout_Click(object sender, EventArgs e) { Close(); }
    }
}
