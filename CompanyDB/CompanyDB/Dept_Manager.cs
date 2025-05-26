using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CompanyDB
{
    public partial class Dept_Manager : Form
    {
        public Dept_Manager()
        {
            InitializeComponent();
            LoadData();
        }

        private void EmployeesBtn_Click(object sender, EventArgs e)
        {
            Employees form2 = new Employees();
            form2.Show();
            this.Hide();
        }

        private void DepartmentsBtn_Click(object sender, EventArgs e)
        {
            Departments form2 = new Departments();
            form2.Show();
            this.Hide();
        }

        private void ContractsBtn_Click(object sender, EventArgs e)
        {
            Contracts form2 = new Contracts();
            form2.Show();
            this.Hide();
        }

        private void SalariesBtn_Click(object sender, EventArgs e)
        {
            Salaries form2 = new Salaries();
            form2.Show();
            this.Hide();
        }

        private void TitlesBtn_Click(object sender, EventArgs e)
        {
            Titles form2 = new Titles();
            form2.Show();
            this.Hide();
        }

        private void DeptmBtn_Click(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void LoadData()
        {
            string connectionString = "Server=127.0.0.1;Database=CompanyDB;Uid=root;Pwd=fgdc011604;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM departments";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
