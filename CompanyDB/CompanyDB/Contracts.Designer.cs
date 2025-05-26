namespace CompanyDB
{
    partial class Contracts
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
            LogoutBtn.Location = new Point(28, 394);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(106, 38);
            LogoutBtn.TabIndex = 27;
            LogoutBtn.Text = "LOG OUT";
            LogoutBtn.UseVisualStyleBackColor = true;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // DeptmBtn
            // 
            DeptmBtn.Location = new Point(28, 316);
            DeptmBtn.Name = "DeptmBtn";
            DeptmBtn.Size = new Size(134, 23);
            DeptmBtn.TabIndex = 26;
            DeptmBtn.Text = "Department Managers";
            DeptmBtn.UseVisualStyleBackColor = true;
            DeptmBtn.Click += DeptmBtn_Click;
            // 
            // TitlesBtn
            // 
            TitlesBtn.Location = new Point(28, 253);
            TitlesBtn.Name = "TitlesBtn";
            TitlesBtn.Size = new Size(134, 23);
            TitlesBtn.TabIndex = 25;
            TitlesBtn.Text = "Titles";
            TitlesBtn.UseVisualStyleBackColor = true;
            TitlesBtn.Click += TitlesBtn_Click;
            // 
            // SalariesBtn
            // 
            SalariesBtn.Location = new Point(28, 190);
            SalariesBtn.Name = "SalariesBtn";
            SalariesBtn.Size = new Size(134, 23);
            SalariesBtn.TabIndex = 24;
            SalariesBtn.Text = "Salaries";
            SalariesBtn.UseVisualStyleBackColor = true;
            SalariesBtn.Click += SalariesBtn_Click;
            // 
            // ContractsBtn
            // 
            ContractsBtn.Location = new Point(28, 134);
            ContractsBtn.Name = "ContractsBtn";
            ContractsBtn.Size = new Size(134, 23);
            ContractsBtn.TabIndex = 23;
            ContractsBtn.Text = "Contracts";
            ContractsBtn.UseVisualStyleBackColor = true;
            // 
            // DepartmentsBtn
            // 
            DepartmentsBtn.Location = new Point(28, 80);
            DepartmentsBtn.Name = "DepartmentsBtn";
            DepartmentsBtn.Size = new Size(134, 23);
            DepartmentsBtn.TabIndex = 22;
            DepartmentsBtn.Text = "Departments";
            DepartmentsBtn.UseVisualStyleBackColor = true;
            DepartmentsBtn.Click += DepartmentsBtn_Click;
            // 
            // EmployeesBtn
            // 
            EmployeesBtn.Location = new Point(28, 30);
            EmployeesBtn.Name = "EmployeesBtn";
            EmployeesBtn.Size = new Size(134, 23);
            EmployeesBtn.TabIndex = 21;
            EmployeesBtn.Text = "Employees";
            EmployeesBtn.UseVisualStyleBackColor = true;
            EmployeesBtn.Click += EmployeesBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(229, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(506, 259);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ExportBtn
            // 
            ExportBtn.Location = new Point(640, 345);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(95, 42);
            ExportBtn.TabIndex = 32;
            ExportBtn.Text = "Export to Excel";
            ExportBtn.UseVisualStyleBackColor = true;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // Contracts
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
            Name = "Contracts";
            Text = "Contracts";
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