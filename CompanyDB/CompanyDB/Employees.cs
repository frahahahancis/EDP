using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace CompanyDB
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
            LoadData();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            Dept_Manager form2 = new Dept_Manager();
            form2.Show();
            this.Hide();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            string connectionString = "Server=127.0.0.1;Database=CompanyDB;Uid=root;Pwd=fgdc011604;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM employees";
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

        private void ExportBtn_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                }
            }

            workbook.SaveAs("ExportedData.xlsx");
            excelApp.Quit();
        }
    }
}
