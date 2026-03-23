namespace Gestock_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = nomUtilisateur.Text;
            string password = motDePasse.Text;

            if(username == "admin" && password == "1234")
            {
                mainScreen ecranPrincipal = new mainScreen();
                this.Hide();
                ecranPrincipal.Show();
            }
        }
    }
}
