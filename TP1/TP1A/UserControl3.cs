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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl81.Show();
            userControl81.BringToFront();
            userControl91.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl81.Hide();
            userControl91.Show();
            userControl91.BringToFront();
        }
    }
}
