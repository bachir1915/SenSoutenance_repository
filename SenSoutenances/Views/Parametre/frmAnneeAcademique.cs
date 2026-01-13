using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SenSoutenance.Models;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmAnneeAcademique : Form
    {
        private List<AnneeAcademique> annees;

        public frmAnneeAcademique()
        {
            InitializeComponent();
        }

        private void frmAnneeAcademique_Load(object sender, EventArgs e)
        {
            annees = new List<AnneeAcademique>
            {
                new AnneeAcademique { IdAnneeAcademique = 1, LibelleAnneeAcademique = "2023-2024", AnneeAcademiqueVal = 2023 },
                new AnneeAcademique { IdAnneeAcademique = 2, LibelleAnneeAcademique = "2024-2025", AnneeAcademiqueVal = 2024 }
            };

            ChargerDonnees();
        }

        private void ChargerDonnees()
        {
            dgAnneeAcademique.DataSource = null;
            dgAnneeAcademique.AutoGenerateColumns = true;
            dgAnneeAcademique.DataSource = annees;
            dgAnneeAcademique.ClearSelection();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelleAnneeAcademique.Text) ||
                string.IsNullOrWhiteSpace(txtAnneeAcademiqueVal.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            annees.Add(new AnneeAcademique
            {
                IdAnneeAcademique = annees.Count + 1,
                LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text,
                AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text)
            });

            ChargerDonnees();
            Effacer();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;

            txtLibelleAnneeAcademique.Text =
                dgAnneeAcademique.CurrentRow.Cells["LibelleAnneeAcademique"].Value.ToString();

            txtAnneeAcademiqueVal.Text =
                dgAnneeAcademique.CurrentRow.Cells["AnneeAcademiqueVal"].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;

            int id = (int)dgAnneeAcademique.CurrentRow.Cells["IdAnneeAcademique"].Value;

            var annee = annees.Find(a => a.IdAnneeAcademique == id);
            if (annee == null) return;

            annee.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
            annee.AnneeAcademiqueVal = int.Parse(txtAnneeAcademiqueVal.Text);

            ChargerDonnees();
            Effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgAnneeAcademique.CurrentRow == null) return;

            int id = (int)dgAnneeAcademique.CurrentRow.Cells["IdAnneeAcademique"].Value;
            annees.RemoveAll(a => a.IdAnneeAcademique == id);

            ChargerDonnees();
            Effacer();
        }

        private void Effacer()
        {
            txtLibelleAnneeAcademique.Clear();
            txtAnneeAcademiqueVal.Clear();
        }
    }
}
