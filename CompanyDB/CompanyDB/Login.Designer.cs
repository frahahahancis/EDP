namespace CompanyDB
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Usernametxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Passwordtxt = new TextBox();
            LoginBtn = new Button();
            RmBtn = new CheckBox();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // Usernametxt
            // 
            Usernametxt.AccessibleName = "login textbox";
            Usernametxt.Location = new Point(192, 94);
            Usernametxt.Name = "Usernametxt";
            Usernametxt.Size = new Size(147, 23);
            Usernametxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleName = "login label";
            label1.AutoSize = true;
            label1.Location = new Point(192, 76);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Log In:";
            // 
            // label2
            // 
            label2.AccessibleName = "login label";
            label2.AutoSize = true;
            label2.Location = new Point(192, 135);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // Passwordtxt
            // 
            Passwordtxt.AccessibleName = "password textbox";
            Passwordtxt.Location = new Point(192, 153);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.Size = new Size(147, 23);
            Passwordtxt.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.AutoSize = true;
            LoginBtn.Location = new Point(192, 242);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(147, 39);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "LOG IN";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RmBtn
            // 
            RmBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            RmBtn.AutoSize = true;
            RmBtn.Location = new Point(192, 182);
            RmBtn.Name = "RmBtn";
            RmBtn.Size = new Size(104, 19);
            RmBtn.TabIndex = 5;
            RmBtn.Text = "Remember Me";
            RmBtn.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(192, 204);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(95, 15);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 355);
            Controls.Add(linkLabel2);
            Controls.Add(RmBtn);
            Controls.Add(LoginBtn);
            Controls.Add(Passwordtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Usernametxt);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usernametxt;
        private Label label1;
        private Label label2;
        private TextBox Passwordtxt;
        private Button LoginBtn;
        private CheckBox RmBtn;
        private LinkLabel linkLabel2;
    }
}
