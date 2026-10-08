using System;
using System.Data;
using System.Data.SqlClient;

namespace Bolshodonov
{
    public static class DbHelper
    {
        public static string ConnectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=PharmacyDB;Integrated Security=True";

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                conn.Open();
                using (var adapter = new SqlDataAdapter(cmd))
                    adapter.Fill(dt);
            }
            return dt;
        }

        public static (int id, string login, string role)? Authenticate(string login, string password)
        {
            var dt = ExecuteQuery(
                "SELECT employee_id, login, role FROM Employees WHERE login=@login AND password=@password",
                new SqlParameter("@login", login),
                new SqlParameter("@password", password));
            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return ((int)r["employee_id"], r["login"].ToString(), r["role"].ToString());
        }
    }
}
