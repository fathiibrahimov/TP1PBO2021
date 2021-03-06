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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            String[] nama = new String[] { "Oven", "Rice Cooker", "Apel", "Jeruk", "Kaos" };
            int[] harga = new int[] { 400000, 300000, 250000, 300000, 100000 };
            String[] gambar = new string[] { "", "", "", "", "" };
            int[] range = new int[] { 2, 2, 2, 2, 1};
            String[] jenis = new String[] { "Elektronik", "Elektronik", "Makanan", "Makanan", "Baju" };

            
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
        }

        //tombol logout
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //tombol web
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bukalapak.com");
        }

        //tombol cari
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int jenis = toolStripComboBox1.SelectedIndex;
            int harga = toolStripComboBox2.SelectedIndex;
            if(jenis == -1 || harga == -1)
            {
                MessageBox.Show("Harap pilih jenis dan harganya");
            }else if(jenis == 0)//elektronik
            {
                if(harga == 1)
                {
                    userControl11.Hide();
                    userControl21.Show();
                    userControl21.BringToFront();
                    userControl31.Hide();
                    userControl41.Hide();
                    userControl51.Hide();
                }
                else
                {
                    userControl11.Hide();
                    userControl21.Hide();
                    userControl31.Hide();
                    userControl41.Hide();
                    userControl51.Show();
                    userControl51.BringToFront();
                }
            }else if(jenis == 1)//baju
            {
                if (harga == 0)
                {
                    userControl11.Hide();
                    userControl21.Hide();
                    userControl31.Hide();
                    userControl41.Show();
                    userControl41.BringToFront();
                    userControl51.Hide();
                }
                else
                {
                    userControl11.Hide();
                    userControl21.Hide();
                    userControl31.Hide();
                    userControl41.Hide();
                    userControl51.Show();
                    userControl51.BringToFront();
                }
            }
            else if(jenis == 2)//makanan
            {
                if(harga == 1)
                {
                    userControl11.Hide();
                    userControl21.Hide();
                    userControl31.Show();
                    userControl31.BringToFront();
                    userControl41.Hide();
                    userControl51.Hide();
                }
                else
                {
                    userControl11.Hide();
                    userControl21.Hide();
                    userControl31.Hide();
                    userControl41.Hide();
                    userControl51.Show();
                    userControl51.BringToFront();
                }
            }
        }
    }
}
