namespace fitur_help_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFaq_Click(object sender, EventArgs e)
        {
            FAQForm2 faq = new FAQForm2();
            faq.Show();
        }

        private void btnKritik_Click(object sender, EventArgs e)
        {
            Kritik_SaranForm2 kritik = new Kritik_SaranForm2();
            kritik.Show();
        }
    }
}