using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitur_help_new
{
    public partial class FAQForm2 : Form
    {
        public FAQForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAQ1 faq1 = new FAQ1();
            faq1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAQ2 faq2 = new FAQ2();
            faq2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FAQ3 faq3 = new FAQ3();
            faq3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FAQ4 faq4 = new FAQ4();
            faq4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FAQ5 faq5 = new FAQ5();
            faq5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FAQ6 faq6 = new FAQ6();
            faq6.Show();
        }

        private void btnkritikdanSaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox1.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox1.Focus();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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
