using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitur_help_new
{
    public partial class FAQ1 : Form
    {

        public FAQ1()
        {
            InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkritikdanSaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            FAQForm2 fAQForm2 = new FAQForm2();
            fAQForm2.ShowDialog();
        }

        private void reundedpnClass12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FAQ1_Load(object sender, EventArgs e)
        {

        }

        private void reundedpnClass11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox1.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label6.Text = "Ketuk untuk Cari";
            }
            else
            {
                label6.Text = "";
            }
            textBox1.AutoSize = false;
            textBox1.Height = 20;

        }
    }
}


