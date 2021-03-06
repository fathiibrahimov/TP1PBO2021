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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl61.Show();
            userControl61.BringToFront();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl61.Hide();
            userControl71.BringToFront();
            userControl71.Show();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl61.Hide();
            userControl81.BringToFront();
            userControl71.Hide();
            userControl81.Show();
            userControl91.Hide();
            userControl101.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl61.Hide();
            userControl91.BringToFront();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Show();
            userControl101.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl61.Hide();
            userControl101.BringToFront();
            userControl71.Hide();
            userControl81.Hide();
            userControl91.Hide();
            userControl101.Show();
        }
    }
}
