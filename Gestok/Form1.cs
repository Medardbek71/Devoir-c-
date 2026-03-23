namespace Gestok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = username.Text;
            string motDePasse = password.Text;

            if (nomUtilisateur == "admin" && motDePasse == "1234")
            {
                MessageBox.Show("Connexion réussi");

                // Ouvre le formulaire principal de l'application
                MainForm mainApp = new MainForm();
                mainApp.Show();

                this.Hide();

                // Quand la fenêtre principale est fermée, ferme aussi la fenêtre de connexion
                mainApp.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Identifiants incorrects", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
