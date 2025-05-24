using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyDB
{
    public partial class Salaries : Form
    {
        public Salaries()
        {
            InitializeComponent();
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
