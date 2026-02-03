using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmSoutenance : Form
    {
        // =============================
        // LISTES SIMULATION
        // =============================
        private List<Soutenance> soutenances = new List<Soutenance>();
        private List<Memoire> memoires = new List<Memoire>();

        public frmSoutenance()
        {
            InitializeComponent();
        }

        // =============================
        // LOAD
        // =============================
        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            // Mémoires simulées
            memoires.Add(new Memoire { IdMemoire = 1, SujetMemoire = "IA et Santé" });
            memoires.Add(new Memoire { IdMemoire = 2, SujetMemoire = "Sécurité Informatique" });

            ChargerComboMemoire();
            ChargerSoutenances();
            Effacer();
        }

        // =============================
        // COMBO MEMOIRE
        // =============================
        private void ChargerComboMemoire()
        {
            cbbMemoire.DataSource = memoires;
            cbbMemoire.DisplayMember = "SujetMemoire";
            cbbMemoire.ValueMember = "IdMemoire";
            cbbMemoire.SelectedIndex = -1;
        }

        // =============================
        // TABLEAU
        // =============================
        private void ChargerSoutenances()
        {
            dgSoutenance.DataSource = null;
            dgSoutenance.DataSource = soutenances.Select(s => new
            {
                s.IdSoutenance,
                Date = s.DatwSoutenance.ToShortDateString(),
                s.LieuSoutenance,
                s.ResultatSoutenance,
                s.MentionSoutenance,
                Memoire = s.Memoire?.SujetMemoire
            }).ToList();

            dgSoutenance.ClearSelection();

            // Stylisation moderne du DataGridView
            if (dgSoutenance.ColumnCount > 0)
            {
                dgSoutenance.EnableHeadersVisualStyles = false;
                dgSoutenance.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
                dgSoutenance.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgSoutenance.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                dgSoutenance.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgSoutenance.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
                dgSoutenance.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
                dgSoutenance.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

                dgSoutenance.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
                dgSoutenance.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            }
        }

        // =============================
        // AJOUTER
        // =============================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!VerifierChamps()) return;

            int newId = soutenances.Count == 0
                ? 1
                : soutenances.Max(x => x.IdSoutenance) + 1;

            Memoire memoire = memoires
                .First(m => m.IdMemoire == (int)cbbMemoire.SelectedValue);

            Soutenance s = new Soutenance
            {
                IdSoutenance = newId,
                DatwSoutenance = dtpDateSoutenance.Value,
                LieuSoutenance = txtLieuSoutenance.Text.Trim(),
                ResultatSoutenance = txtResultatSoutenance.Text.Trim(),
                MentionSoutenance = txtMentionSoutenance.Text.Trim(),
                ObservationSoutenance = txtObservationSoutenance.Text.Trim(),
                IdMemoire = memoire.IdMemoire,
                Memoire = memoire
            };

            soutenances.Add(s);
            ChargerSoutenances();
            Effacer();
        }

        // =============================
        // SELECTIONNER
        // =============================
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            int id = Convert.ToInt32(dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value);
            Soutenance s = soutenances.First(x => x.IdSoutenance == id);

            dtpDateSoutenance.Value = s.DatwSoutenance;
            txtLieuSoutenance.Text = s.LieuSoutenance;
            txtResultatSoutenance.Text = s.ResultatSoutenance;
            txtMentionSoutenance.Text = s.MentionSoutenance;
            txtObservationSoutenance.Text = s.ObservationSoutenance;
            cbbMemoire.SelectedValue = s.IdMemoire;
        }

        // =============================
        // MODIFIER
        // =============================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;
            if (!VerifierChamps()) return;

            int id = Convert.ToInt32(dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value);
            Soutenance s = soutenances.First(x => x.IdSoutenance == id);

            s.DatwSoutenance = dtpDateSoutenance.Value;
            s.LieuSoutenance = txtLieuSoutenance.Text.Trim();
            s.ResultatSoutenance = txtResultatSoutenance.Text.Trim();
            s.MentionSoutenance = txtMentionSoutenance.Text.Trim();
            s.ObservationSoutenance = txtObservationSoutenance.Text.Trim();
            s.IdMemoire = (int)cbbMemoire.SelectedValue;
            s.Memoire = memoires.First(m => m.IdMemoire == s.IdMemoire);

            ChargerSoutenances();
            Effacer();
        }

        // =============================
        // SUPPRIMER
        // =============================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            int id = Convert.ToInt32(dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value);
            Soutenance s = soutenances.First(x => x.IdSoutenance == id);

            if (MessageBox.Show("Supprimer cette soutenance ?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                soutenances.Remove(s);
                ChargerSoutenances();
                Effacer();
            }
        }

        // =============================
        // VALIDATION
        // =============================
        private bool VerifierChamps()
        {
            if (string.IsNullOrWhiteSpace(txtLieuSoutenance.Text) ||
                string.IsNullOrWhiteSpace(txtResultatSoutenance.Text) ||
                string.IsNullOrWhiteSpace(txtMentionSoutenance.Text) ||
                cbbMemoire.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return false;
            }
            return true;
        }

        // =============================
        // NETTOYER
        // =============================
        private void Effacer()
        {
            txtLieuSoutenance.Clear();
            txtResultatSoutenance.Clear();
            txtMentionSoutenance.Clear();
            txtObservationSoutenance.Clear();
            cbbMemoire.SelectedIndex = -1;
            dtpDateSoutenance.Value = DateTime.Now;
        }
    }
}
