using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmChefDepartement : Form
    {
        private List<ChefDepartement> chefs = new List<ChefDepartement>();

        public frmChefDepartement()
        {
            InitializeComponent();
        }

        private void frmChefDepartement_Load(object sender, EventArgs e)
        {
            ChargerChefs();
        }

        private void ChargerChefs()
        {
            dgChef.DataSource = null;
            dgChef.DataSource = chefs.ToList();
            dgChef.ClearSelection();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text))
            {
                MessageBox.Show("Veuillez remplir au moins le nom et le prénom.");
                return;
            }

            int newId = chefs.Count == 0 ? 1 : chefs.Max(x => x.IdUtilisateur) + 1;
            chefs.Add(new ChefDepartement
            {
                IdUtilisateur = newId,
                NomUtilisateur = txtNom.Text.Trim(),
                PrenomUtilisateur = txtPrenom.Text.Trim(),
                TelUtilisateur = txtTel.Text.Trim(),
                EmailUtilisateur = txtEmail.Text.Trim()
            });

            ChargerChefs();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgChef.CurrentRow == null) return;

            int id = (int)dgChef.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = chefs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null)
            {
                c.NomUtilisateur = txtNom.Text.Trim();
                c.PrenomUtilisateur = txtPrenom.Text.Trim();
                c.TelUtilisateur = txtTel.Text.Trim();
                c.EmailUtilisateur = txtEmail.Text.Trim();
                ChargerChefs();
                Effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgChef.CurrentRow == null) return;

            if (MessageBox.Show("Supprimer ce chef ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dgChef.CurrentRow.Cells["IdUtilisateur"].Value;
                var c = chefs.FirstOrDefault(x => x.IdUtilisateur == id);
                if (c != null)
                {
                    chefs.Remove(c);
                    ChargerChefs();
                    Effacer();
                }
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgChef.CurrentRow == null) return;
            int id = (int)dgChef.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = chefs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null)
            {
                txtNom.Text = c.NomUtilisateur;
                txtPrenom.Text = c.PrenomUtilisateur;
                txtTel.Text = c.TelUtilisateur;
                txtEmail.Text = c.EmailUtilisateur;
            }
        }

        private void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtTel.Clear();
            txtEmail.Clear();
        }
    }
}
