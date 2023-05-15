using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta_Project
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            var RegisterPan = parent1.logInUc1;
            var LogPan = parent1.register1;

            RegisterPan.Show();
            LogPan.Hide();
        }
    }
}
