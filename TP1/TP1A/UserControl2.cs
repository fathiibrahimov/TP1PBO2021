using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1A
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl61.Show();
            userControl61.BringToFront();
            userControl71.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl71.Show();
            userControl71.BringToFront();
            userControl61.Hide();
        }
    }
}
