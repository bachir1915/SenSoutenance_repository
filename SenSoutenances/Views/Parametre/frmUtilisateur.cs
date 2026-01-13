using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmUtilisateur : Form
    {
        private List<Utilisateur> utilisateurs = new List<Utilisateur>();

        public frmUtilisateur()
        {
            InitializeComponent();
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            ChargerUtilisateurs();
        }

        private void ChargerUtilisateurs()
        {
            dgUtilisateurs.DataSource = null;
            dgUtilisateurs.DataSource = utilisateurs.ToList();
            dgUtilisateurs.ClearSelection();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Veuillez remplir le login et le mot de passe.");
                return;
            }

            int newId = utilisateurs.Count == 0 ? 1 : utilisateurs.Max(x => x.IdUtilisateur) + 1;
            utilisateurs.Add(new Utilisateur
            {
                IdUtilisateur = newId,
                EmailUtilisateur = txtLogin.Text.Trim(),
                MotDePasse = SenSoutenance.Shared.Md5Helper.GetMd5Hash(txtPassword.Text.Trim())
            });

            ChargerUtilisateurs();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgUtilisateurs.CurrentRow == null) return;

            int id = (int)dgUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;
            var u = utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (u != null)
            {
                u.EmailUtilisateur = txtLogin.Text.Trim();
                u.MotDePasse = SenSoutenance.Shared.Md5Helper.GetMd5Hash(txtPassword.Text.Trim());
                ChargerUtilisateurs();
                Effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgUtilisateurs.CurrentRow == null) return;

            if (MessageBox.Show("Supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dgUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;
                var u = utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
                if (u != null)
                {
                    utilisateurs.Remove(u);
                    ChargerUtilisateurs();
                    Effacer();
                }
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgUtilisateurs.CurrentRow == null) return;
            int id = (int)dgUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;
            var u = utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (u != null)
            {
                txtLogin.Text = u.EmailUtilisateur;
                txtPassword.Text = ""; // On ne remplit pas le mot de passe en clair
            }
        }

        private void Effacer()
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }
    }
}
