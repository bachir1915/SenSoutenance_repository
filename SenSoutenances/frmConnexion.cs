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
    public partial class frmConnexion : global::System.Windows.Forms.Form
    {
        BdSenSoutenanceContext db = new BdSenSoutenanceContext();

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // Récupérer le hash du mot de passe stocké en base pour cet utilisateur
            var utilisateur = db.utilisateurs
                .Where(u => u.Login == txtIdentifiant.Text)
                .FirstOrDefault();

            if (utilisateur == null)
            {
                MessageBox.Show("Identifiant incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Vérifier le mot de passe avec MD5
            using (MD5 md5Hash = MD5.Create())
            {
                if (VerifyMd5Hash(md5Hash, txtMotDePasse.Text, utilisateur.Password))
                {
                    // Connexion réussie
                    frmMDI f = new frmMDI();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Méthode pour créer un hash MD5
        private string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }

        // Méthode pour vérifier un hash MD5
        private bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

