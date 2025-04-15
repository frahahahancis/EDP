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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "login textbox";
            textBox1.Location = new Point(192, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 0;
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
            // textBox2
            // 
            textBox2.AccessibleName = "password textbox";
            textBox2.Location = new Point(192, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(192, 242);
            button1.Name = "button1";
            button1.Size = new Size(147, 39);
            button1.TabIndex = 4;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(192, 182);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(219, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create Account";
            // 
            // label3
            // 
            label3.AccessibleName = "login label";
            label3.AutoSize = true;
            label3.Location = new Point(204, 316);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 7;
            label3.Text = "New to the Company?";
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
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label3;
        private LinkLabel linkLabel2;
    }
}
