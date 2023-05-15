namespace Beta_Project
{
    partial class LogInUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailCATxtBox = new System.Windows.Forms.TextBox();
            this.UsernameCATxtBox = new System.Windows.Forms.TextBox();
            this.PasswordCATxtBox = new System.Windows.Forms.TextBox();
            this.ConpassCATxtBox = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.ConpassCATxtBox);
            this.panel1.Controls.Add(this.PasswordCATxtBox);
            this.panel1.Controls.Add(this.UsernameCATxtBox);
            this.panel1.Controls.Add(this.EmailCATxtBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 490);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // EmailCATxtBox
            // 
            this.EmailCATxtBox.Location = new System.Drawing.Point(16, 122);
            this.EmailCATxtBox.Name = "EmailCATxtBox";
            this.EmailCATxtBox.Size = new System.Drawing.Size(213, 23);
            this.EmailCATxtBox.TabIndex = 5;
            // 
            // UsernameCATxtBox
            // 
            this.UsernameCATxtBox.Location = new System.Drawing.Point(16, 177);
            this.UsernameCATxtBox.Name = "UsernameCATxtBox";
            this.UsernameCATxtBox.Size = new System.Drawing.Size(213, 23);
            this.UsernameCATxtBox.TabIndex = 7;
            // 
            // PasswordCATxtBox
            // 
            this.PasswordCATxtBox.Location = new System.Drawing.Point(16, 234);
            this.PasswordCATxtBox.Name = "PasswordCATxtBox";
            this.PasswordCATxtBox.Size = new System.Drawing.Size(213, 23);
            this.PasswordCATxtBox.TabIndex = 8;
            // 
            // ConpassCATxtBox
            // 
            this.ConpassCATxtBox.Location = new System.Drawing.Point(16, 295);
            this.ConpassCATxtBox.Name = "ConpassCATxtBox";
            this.ConpassCATxtBox.Size = new System.Drawing.Size(213, 23);
            this.ConpassCATxtBox.TabIndex = 9;
            this.ConpassCATxtBox.TextChanged += new System.EventHandler(this.ConpassCATxtBox_TextChanged);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.ForestGreen;
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(16, 357);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(213, 29);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alrady have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(158, 404);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 12);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign In";
            // 
            // LogInUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.panel1);
            this.Name = "LogInUc";
            this.Size = new System.Drawing.Size(255, 504);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox EmailCATxtBox;
        private Button Register;
        private TextBox ConpassCATxtBox;
        private TextBox PasswordCATxtBox;
        private TextBox UsernameCATxtBox;
        private LinkLabel linkLabel1;
        private Label label6;
    }
}
