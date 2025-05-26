namespace CompanyDB
{
    partial class Dept_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogoutBtn = new Button();
            DeptmBtn = new Button();
            TitlesBtn = new Button();
            SalariesBtn = new Button();
            ContractsBtn = new Button();
            DepartmentsBtn = new Button();
            EmployeesBtn = new Button();
            dataGridView1 = new DataGridView();
            ExportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(33, 390);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(106, 38);
            LogoutBtn.TabIndex = 29;
            LogoutBtn.Text = "LOG OUT";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // DeptmBtn
            // 
            DeptmBtn.Location = new Point(33, 312);
            DeptmBtn.Name = "DeptmBtn";
            DeptmBtn.Size = new Size(134, 23);
            DeptmBtn.TabIndex = 28;
            DeptmBtn.Text = "Department Managers";
            DeptmBtn.UseVisualStyleBackColor = true;
            DeptmBtn.Click += DeptmBtn_Click;
            // 
            // TitlesBtn
            // 
            TitlesBtn.Location = new Point(33, 249);
            TitlesBtn.Name = "TitlesBtn";
            TitlesBtn.Size = new Size(134, 23);
            TitlesBtn.TabIndex = 27;
            TitlesBtn.Text = "Titles";
            TitlesBtn.UseVisualStyleBackColor = true;
            TitlesBtn.Click += TitlesBtn_Click;
            // 
            // SalariesBtn
            // 
            SalariesBtn.Location = new Point(33, 186);
            SalariesBtn.Name = "SalariesBtn";
            SalariesBtn.Size = new Size(134, 23);
            SalariesBtn.TabIndex = 26;
            SalariesBtn.Text = "Salaries";
            SalariesBtn.UseVisualStyleBackColor = true;
            SalariesBtn.Click += SalariesBtn_Click;
            // 
            // ContractsBtn
            // 
            ContractsBtn.Location = new Point(33, 130);
            ContractsBtn.Name = "ContractsBtn";
            ContractsBtn.Size = new Size(134, 23);
            ContractsBtn.TabIndex = 25;
            ContractsBtn.Text = "Contracts";
            ContractsBtn.UseVisualStyleBackColor = true;
            ContractsBtn.Click += ContractsBtn_Click;
            // 
            // DepartmentsBtn
            // 
            DepartmentsBtn.Location = new Point(33, 76);
            DepartmentsBtn.Name = "DepartmentsBtn";
            DepartmentsBtn.Size = new Size(134, 23);
            DepartmentsBtn.TabIndex = 24;
            DepartmentsBtn.Text = "Departments";
            DepartmentsBtn.UseVisualStyleBackColor = true;
            DepartmentsBtn.Click += DepartmentsBtn_Click;
            // 
            // EmployeesBtn
            // 
            EmployeesBtn.Location = new Point(33, 26);
            EmployeesBtn.Name = "EmployeesBtn";
            EmployeesBtn.Size = new Size(134, 23);
            EmployeesBtn.TabIndex = 23;
            EmployeesBtn.Text = "Employees";
            EmployeesBtn.UseVisualStyleBackColor = true;
            EmployeesBtn.Click += EmployeesBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(246, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(506, 259);
            dataGridView1.TabIndex = 30;
            // 
            // ExportBtn
            // 
            ExportBtn.Location = new Point(657, 341);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(95, 42);
            ExportBtn.TabIndex = 32;
            ExportBtn.Text = "Export to Excel";
            ExportBtn.UseVisualStyleBackColor = true;
            // 
            // Dept_Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExportBtn);
            Controls.Add(dataGridView1);
            Controls.Add(LogoutBtn);
            Controls.Add(DeptmBtn);
            Controls.Add(TitlesBtn);
            Controls.Add(SalariesBtn);
            Controls.Add(ContractsBtn);
            Controls.Add(DepartmentsBtn);
            Controls.Add(EmployeesBtn);
            Name = "Dept_Manager";
            Text = "Dept_Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button LogoutBtn;
        private Button DeptmBtn;
        private Button TitlesBtn;
        private Button SalariesBtn;
        private Button ContractsBtn;
        private Button DepartmentsBtn;
        private Button EmployeesBtn;
        private DataGridView dataGridView1;
        private Button ExportBtn;
    }
}