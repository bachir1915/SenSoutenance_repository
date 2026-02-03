using SenSoutenance.Models;
using System;
using System.Collections.Generic;
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
            Effacer();
        }

        // =============================
        // CHARGER TABLEAU
        // =============================
        private void ChargerDepartements()
        {
            dgDepartement.DataSource = null;
            dgDepartement.DataSource = departements.Select(d => new
            {
                d.IdDepartement,
                d.LibelleDepartement
            }).ToList();

            dgDepartement.ClearSelection();

            // Stylisation moderne du DataGridView
            if (dgDepartement.ColumnCount > 0)
            {
                dgDepartement.EnableHeadersVisualStyles = false;
                dgDepartement.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
                dgDepartement.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgDepartement.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                dgDepartement.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgDepartement.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
                dgDepartement.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
                dgDepartement.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

                dgDepartement.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
                dgDepartement.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            }
        }

        // =============================
        // AJOUTER
        // =============================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!VerifierChamps()) return;

            int newId = departements.Count == 0
                ? 1
                : departements.Max(d => d.IdDepartement) + 1;

            Departement dpt = new Departement
            {
                IdDepartement = newId,
                LibelleDepartement = txtLibelleDepartement.Text.Trim()
            };

            departements.Add(dpt);
            ChargerDepartements();
            Effacer();
        }

        // =============================
        // SELECTIONNER
        // =============================
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;

            txtLibelleDepartement.Text =
                dgDepartement.CurrentRow.Cells["LibelleDepartement"].Value.ToString();
        }

        // =============================
        // MODIFIER
        // =============================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;
            if (!VerifierChamps()) return;

            int id = Convert.ToInt32(
                dgDepartement.CurrentRow.Cells["IdDepartement"].Value);

            Departement dpt = departements.FirstOrDefault(d => d.IdDepartement == id);
            if (dpt == null) return;

            dpt.LibelleDepartement = txtLibelleDepartement.Text.Trim();

            ChargerDepartements();
            Effacer();
        }

        // =============================
        // SUPPRIMER
        // =============================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgDepartement.CurrentRow == null) return;

            int id = Convert.ToInt32(
                dgDepartement.CurrentRow.Cells["IdDepartement"].Value);

            Departement dpt = departements.FirstOrDefault(d => d.IdDepartement == id);
            if (dpt == null) return;

            if (MessageBox.Show(
                "Supprimer ce département ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                departements.Remove(dpt);
                ChargerDepartements();
                Effacer();
            }
        }

        // =============================
        // VALIDATION
        // =============================
        private bool VerifierChamps()
        {
            if (string.IsNullOrWhiteSpace(txtLibelleDepartement.Text))
            {
                MessageBox.Show("Veuillez saisir le libellé du département.");
                return false;
            }
            return true;
        }

        // =============================
        // NETTOYER
        // =============================
        private void Effacer()
        {
            txtLibelleDepartement.Clear();
            txtLibelleDepartement.Focus();
        }
    }
}
