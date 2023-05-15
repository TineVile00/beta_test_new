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
    public partial class LogInUc : UserControl
    {
        public LogInUc()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ConpassCATxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            var parent1 = this.Parent as Form1;
            var RegisterPan = parent1.logInUc1;
            var LogPan = parent1.register1;

            RegisterPan.Hide();
            LogPan.Show();
        }
    }
}
