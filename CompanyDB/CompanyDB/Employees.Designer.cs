namespace CompanyDB
{
    partial class Employees
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
            EmployeesBtn = new Button();
            DepartmentsBtn = new Button();
            ContractsBtn = new Button();
            SalariesBtn = new Button();
            TitlesBtn = new Button();
            DeptmBtn = new Button();
            LogoutBtn = new Button();
            dataGridView1 = new DataGridView();
            ExportBtn = new Button();
            AddBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EmployeesBtn
            // 
            EmployeesBtn.Location = new Point(22, 36);
            EmployeesBtn.Name = "EmployeesBtn";
            EmployeesBtn.Size = new Size(134, 23);
            EmployeesBtn.TabIndex = 0;
            EmployeesBtn.Text = "Employees";
            EmployeesBtn.UseVisualStyleBackColor = true;
            // 
            // DepartmentsBtn
            // 
            DepartmentsBtn.Location = new Point(22, 86);
            DepartmentsBtn.Name = "DepartmentsBtn";
            DepartmentsBtn.Size = new Size(134, 23);
            DepartmentsBtn.TabIndex = 1;
            DepartmentsBtn.Text = "Departments";
            DepartmentsBtn.UseVisualStyleBackColor = true;
            DepartmentsBtn.Click += DepartmentsBtn_Click;
            // 
            // ContractsBtn
            // 
            ContractsBtn.Location = new Point(22, 140);
            ContractsBtn.Name = "ContractsBtn";
            ContractsBtn.Size = new Size(134, 23);
            ContractsBtn.TabIndex = 2;
            ContractsBtn.Text = "Contracts";
            ContractsBtn.UseVisualStyleBackColor = true;
            ContractsBtn.Click += ContractsBtn_Click;
            // 
            // SalariesBtn
            // 
            SalariesBtn.Location = new Point(22, 196);
            SalariesBtn.Name = "SalariesBtn";
            SalariesBtn.Size = new Size(134, 23);
            SalariesBtn.TabIndex = 3;
            SalariesBtn.Text = "Salaries";
            SalariesBtn.UseVisualStyleBackColor = true;
            SalariesBtn.Click += SalariesBtn_Click;
            // 
            // TitlesBtn
            // 
            TitlesBtn.Location = new Point(22, 259);
            TitlesBtn.Name = "TitlesBtn";
            TitlesBtn.Size = new Size(134, 23);
            TitlesBtn.TabIndex = 4;
            TitlesBtn.Text = "Titles";
            TitlesBtn.UseVisualStyleBackColor = true;
            TitlesBtn.Click += TitlesBtn_Click;
            // 
            // DeptmBtn
            // 
            DeptmBtn.Location = new Point(22, 322);
            DeptmBtn.Name = "DeptmBtn";
            DeptmBtn.Size = new Size(134, 23);
            DeptmBtn.TabIndex = 5;
            DeptmBtn.Text = "Department Managers";
            DeptmBtn.UseVisualStyleBackColor = true;
            DeptmBtn.Click += DeptmBtn_Click;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Location = new Point(22, 400);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(106, 38);
            LogoutBtn.TabIndex = 6;
            LogoutBtn.Text = "LOG OUT";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(220, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(506, 259);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ExportBtn
            // 
            ExportBtn.Location = new Point(631, 351);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(95, 42);
            ExportBtn.TabIndex = 32;
            ExportBtn.Text = "Export to Excel";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(612, 57);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(114, 23);
            AddBtn.TabIndex = 33;
            AddBtn.Text = "Add Employees";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddBtn);
            Controls.Add(ExportBtn);
            Controls.Add(dataGridView1);
            Controls.Add(LogoutBtn);
            Controls.Add(DeptmBtn);
            Controls.Add(TitlesBtn);
            Controls.Add(SalariesBtn);
            Controls.Add(ContractsBtn);
            Controls.Add(DepartmentsBtn);
            Controls.Add(EmployeesBtn);
            Name = "Employees";
            Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button EmployeesBtn;
        private Button DepartmentsBtn;
        private Button ContractsBtn;
        private Button SalariesBtn;
        private Button TitlesBtn;
        private Button DeptmBtn;
        private Button LogoutBtn;
        private DataGridView dataGridView1;
        private Button ExportBtn;
        private Button AddBtn;
    }
}