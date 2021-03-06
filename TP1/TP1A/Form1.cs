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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(TBPass.Text=="" || TBUser.Text == "")
            {
                MessageBox.Show("Harap Masukkan Username dan Password");
            }else if (TBPass.Text == "pbo123")
            {
                MessageBox.Show("Login Berhasil!");
                this.Hide();
                Form2 fm = new Form2();
                fm.Show();
            }
            else
            {
                MessageBox.Show("Password Salah !");
            }
        }
    }
}
