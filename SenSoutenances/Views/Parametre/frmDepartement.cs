using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmDepartement : Form
    {
        private List<Departement> departements = new List<Departement>();

        public frmDepartement()
        {
            InitializeComponent();
        }

        private void frmDepartement_Load(object sender, EventArgs e)
        {
            ChargerDepartements();
        }

        private void ChargerDepartements()
        {
            dgDepartement.DataSource = null;
            dgDepartement.DataSource = departements.ToList();
            dgDepartement.ClearSelection();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé du département.");
                return;
            }

            int newId = departements.Count == 0 ? 1 : departements.Max(x => x.IdDepartement) + 1;
            departements.Add(new Departement
            {
                IdDepartement = newId,
                LibelleDepartement = txtLibelle.Text.Trim()
            });

            ChargerDepartements();
            txtLibelle.Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;
            if (string.IsNullOrWhiteSpace(txtLibelle.Text)) return;

            int id = (int)dgDepartement.CurrentRow.Cells["IdDepartement"].Value;
            var d = departements.FirstOrDefault(x => x.IdDepartement == id);
            if (d != null)
            {
                d.LibelleDepartement = txtLibelle.Text.Trim();
                ChargerDepartements();
                txtLibelle.Clear();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;

            if (MessageBox.Show("Supprimer ce département ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dgDepartement.CurrentRow.Cells["IdDepartement"].Value;
                var d = departements.FirstOrDefault(x => x.IdDepartement == id);
                if (d != null)
                {
                    departements.Remove(d);
                    ChargerDepartements();
                    txtLibelle.Clear();
                }
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;
            txtLibelle.Text = dgDepartement.CurrentRow.Cells["LibelleDepartement"].Value.ToString();
        }
    }
}
