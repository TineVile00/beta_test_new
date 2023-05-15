namespace Beta_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logInUc1 = new Beta_Project.LogInUc();
            this.register1 = new Beta_Project.Register();
            this.SuspendLayout();
            // 
            // logInUc1
            // 
            this.logInUc1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logInUc1.Location = new System.Drawing.Point(243, 11);
            this.logInUc1.Name = "logInUc1";
            this.logInUc1.Size = new System.Drawing.Size(255, 504);
            this.logInUc1.TabIndex = 0;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.register1.Location = new System.Drawing.Point(243, 59);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(255, 372);
            this.register1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 524);
            this.Controls.Add(this.logInUc1);
            this.Controls.Add(this.register1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        internal LogInUc logInUc1;
        internal Register register1;
    }
}