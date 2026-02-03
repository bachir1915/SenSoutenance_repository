using System;
using System.Windows.Forms;

namespace SenSoutenance
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            txtMotDePasse.PasswordChar = '●';
            txtIdentifiant.Focus();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // 1️⃣ Vérification des champs
            if (string.IsNullOrWhiteSpace(txtIdentifiant.Text) ||
                string.IsNullOrWhiteSpace(txtMotDePasse.Text))
            {
                MessageBox.Show(
                    "Veuillez saisir l'identifiant et le mot de passe.",
                    "Connexion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2️⃣ Récupération des valeurs
            string login = txtIdentifiant.Text.Trim();
            string password = txtMotDePasse.Text.Trim();

            //  COMPTES SIMULÉS (COURS)
            if (login == "admin" && password == "admin")
            {
                SessionUtilisateur.Login = "admin";
                SessionUtilisateur.Role = "Admin";
            }
            else if (login == "user" && password == "user")
            {
                SessionUtilisateur.Login = "user";
                SessionUtilisateur.Role = "User";
            }
            else
            {
                MessageBox.Show(
                    "Identifiant ou mot de passe incorrect.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                txtMotDePasse.Clear();
                txtMotDePasse.Focus();
                return;
            }

            // 3️⃣ Ouverture du MDI
            frmMDI mdi = new frmMDI();
            mdi.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
