using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenSoutenance
{
    public partial class frmConnexion : Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public frmConnexion()
        {
            InitializeComponent();
        }

        //string emailParDefaut = "admin@test.com";
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // Utilisateur par défaut
            string emailParDefaut = "admin@test.com";
            if (txtIdentifiant.Text.Trim() == emailParDefaut)
            {
                SessionUtilisateur.Login = emailParDefaut;
                SessionUtilisateur.Role = "Admin";
                frmMDI f1 = new frmMDI();
                f1.Show();
                this.Hide();
                return;
            }
            // Récupérer l'utilisateur par son email
            var utilisateur = db.utilisateurs
                .FirstOrDefault(u => u.EmailUtilisateur == txtIdentifiant.Text);
            if (utilisateur == null)
            {
                MessageBox.Show("Identifiant incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Connexion réussie - Déterminer le rôle
            SessionUtilisateur.Login = utilisateur.EmailUtilisateur;
            // Vérifier si c'est un Admin
            bool isAdmin = db.admins.Any(a => a.IdUtilisateur == utilisateur.IdUtilisateur);
            SessionUtilisateur.Role = isAdmin ? "Admin" : "User";
            frmMDI f2 = new frmMDI();
            f2.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
