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

namespace CompanyDB
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
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
    }
}
