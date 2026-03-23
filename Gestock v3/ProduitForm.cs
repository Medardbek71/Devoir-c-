//using System;
//using System.Windows.Forms;

//namespace Gestock_v3
//{
//    public partial class ProduitForm : Form
//    {
//        public ProduitForm()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            string nomTexte = textBox1.Text.Trim();
//            string prixTexte = textBox2.Text;
//            string qteTexte = textBox3.Text;

//            // 1. Validation du nom
//            if (string.IsNullOrWhiteSpace(nomTexte))
//            {
//                MessageBox.Show("Veuillez remplir le nom du produit.", "Champ obligatoire");
//                textBox1.Focus();
//                return;
//            }

//            // 2. Validation du prix
//            if (!int.TryParse(prixTexte, out int prixValide))
//            {
//                MessageBox.Show("Erreur : Le prix doit être un nombre entier.", "Format incorrect");
//                textBox2.Focus();
//                return;
//            }

//            // 3. Validation de la quantité
//            if (!int.TryParse(qteTexte, out int quantite))
//            {
//                MessageBox.Show("Erreur : La quantité doit être un nombre entier.", "Format incorrect");
//                textBox3.Focus();
//                return;
//            }

//            // 4. Ajout au tableau (Assure-toi que les colonnes existent dans le Designer)
//            // L'ordre : Nom, Prix, Quantité, Texte Bouton Modifier, Texte Bouton Supprimer

//            MessageBox.Show($"Produit {nomTexte} enregistré avec succès !", "Succès");

//            // 5. Nettoyage (Appel avec la bonne majuscule)
//            ViderChamps();
//            this.Hide();
//        } // <--- L'accolade qui manquait ici

//        private void ViderChamps()
//        {
//            textBox1.Clear();
//            textBox2.Clear();
//            textBox3.Clear();
//            textBox1.Focus();
//        }

//        // On peut supprimer les événements vides pour alléger le code
//    }
//}

using System;
using System.Windows.Forms;

namespace Gestock_v3
{
    public partial class ProduitForm : Form
    {
        // On crée une référence vers le tableau du formulaire principal
        private DataGridView _mainGrid;

        // On modifie le constructeur pour accepter le DataGridView en paramètre
        public ProduitForm(DataGridView gridRecue)
        {
            InitializeComponent();
            _mainGrid = gridRecue; // On stocke le tableau reçu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomTexte = textBox1.Text.Trim();
            string prixTexte = textBox2.Text;
            string qteTexte = textBox3.Text;

            // 1. Validation (Nom)
            if (string.IsNullOrWhiteSpace(nomTexte))
            {
                MessageBox.Show("Veuillez remplir le nom du produit.");
                textBox1.Focus();
                return;
            }

            // 2. Validation (Prix)
            if (!int.TryParse(prixTexte, out int prixValide))
            {
                MessageBox.Show("Le prix doit être un nombre.");
                return;
            }

            // 3. Validation (Quantité)
            if (!int.TryParse(qteTexte, out int quantite))
            {
                MessageBox.Show("La quantité doit être un nombre.");
                return;
            }

            // 4. AJOUT AU TABLEAU (On utilise la référence _mainGrid)
            _mainGrid.Rows.Add(nomTexte, prixValide, quantite, "Modifier", "Supprimer");

            MessageBox.Show($"Produit {nomTexte} enregistré !");

            ViderChamps();
            this.Hide(); // On cache la fenêtre d'ajout après l'enregistrement
        }

        private void ViderChamps()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}