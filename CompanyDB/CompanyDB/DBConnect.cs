using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CompanyDB
{
    internal class DBConnect
    {
        private string connectionString = "Server=127.0.0.1;Database=CompanyDB;Uid=root;Pwd=fgdc011604;";

        public DataTable GetData(string query)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Database error: " + ex.Message);
                }
            }

        }
    }
}
