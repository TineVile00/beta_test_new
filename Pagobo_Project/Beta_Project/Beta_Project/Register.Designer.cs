namespace Beta_Project
{
    partial class Register
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
            this.SignUpLabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.PassSATxtBox = new System.Windows.Forms.TextBox();
            this.EmailUserTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.SignUpLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LogInBtn);
            this.panel1.Controls.Add(this.PassSATxtBox);
            this.panel1.Controls.Add(this.EmailUserTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 358);
            this.panel1.TabIndex = 0;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.ActiveLinkColor = System.Drawing.Color.PaleTurquoise;
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpLabel.LinkColor = System.Drawing.Color.DodgerBlue;
            this.SignUpLabel.Location = new System.Drawing.Point(151, 327);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(34, 12);
            this.SignUpLabel.TabIndex = 13;
            this.SignUpLabel.TabStop = true;
            this.SignUpLabel.Text = "Sign up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(54, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alrady have an account?";
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.LogInBtn.Location = new System.Drawing.Point(19, 272);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(207, 29);
            this.LogInBtn.TabIndex = 6;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // PassSATxtBox
            // 
            this.PassSATxtBox.Location = new System.Drawing.Point(19, 219);
            this.PassSATxtBox.Name = "PassSATxtBox";
            this.PassSATxtBox.Size = new System.Drawing.Size(207, 23);
            this.PassSATxtBox.TabIndex = 5;
            // 
            // EmailUserTxtBox
            // 
            this.EmailUserTxtBox.Location = new System.Drawing.Point(19, 152);
            this.EmailUserTxtBox.Name = "EmailUserTxtBox";
            this.EmailUserTxtBox.Size = new System.Drawing.Size(207, 23);
            this.EmailUserTxtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email/Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign in to your account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(255, 372);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button LogInBtn;
        private TextBox PassSATxtBox;
        private TextBox EmailUserTxtBox;
        private LinkLabel SignUpLabel;
        private Label label6;
    }
}
