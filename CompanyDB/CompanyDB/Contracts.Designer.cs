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
            label2 = new Label();
            label1 = new Label();
            LogoutBtn = new Button();
            DeptmBtn = new Button();
            TitlesBtn = new Button();
            SalariesBtn = new Button();
            ContractsBtn = new Button();
            DepartmentsBtn = new Button();
            EmployeesBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 24);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 20;
            label2.Text = "Employee No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(513, 24);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 19;
            label1.Text = "Years Contract";
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
            // Contracts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogoutBtn);
            Controls.Add(DeptmBtn);
            Controls.Add(TitlesBtn);
            Controls.Add(SalariesBtn);
            Controls.Add(ContractsBtn);
            Controls.Add(DepartmentsBtn);
            Controls.Add(EmployeesBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Contracts";
            Text = "Contracts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button LogoutBtn;
        private Button DeptmBtn;
        private Button TitlesBtn;
        private Button SalariesBtn;
        private Button ContractsBtn;
        private Button DepartmentsBtn;
        private Button EmployeesBtn;
    }
}