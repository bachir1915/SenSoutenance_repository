using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmMemoire : Form
    {
        // =============================
        // LISTES DE SIMULATION
        // =============================
        private List<Memoire> memoires = new List<Memoire>();
        private List<AnneeAcademique> annees = new List<AnneeAcademique>();
        private List<Session> sessions = new List<Session>();

        public frmMemoire()
        {
            InitializeComponent();
        }

        // =============================
        // LOAD FORM
        // =============================
        private void frmMemoire_Load(object sender, EventArgs e)
        {
            // Données simulées (comme le prof)
            annees.Add(new AnneeAcademique
            {
                IdAnneeAcademique = 1,
                LibelleAnneeAcademique = "2023-2024"
            });

            annees.Add(new AnneeAcademique
            {
                IdAnneeAcademique = 2,
                LibelleAnneeAcademique = "2024-2025"
            });

            sessions.Add(new Session
            {
                IdSession = 1,
                LibelleSession = "Session 1"
            });

            sessions.Add(new Session
            {
                IdSession = 2,
                LibelleSession = "Session 2"
            });

            ChargerComboBox();
            ChargerMemoires();
            Effacer();
        }

        // =============================
        // CHARGER COMBOBOX
        // =============================
        private void ChargerComboBox()
        {
            cbbAnneeAcademique.DataSource = annees;
            cbbAnneeAcademique.DisplayMember = "LibelleAnneeAcademique";
            cbbAnneeAcademique.ValueMember = "IdAnneeAcademique";
            cbbAnneeAcademique.SelectedIndex = -1;

            cbbSession.DataSource = sessions;
            cbbSession.DisplayMember = "LibelleSession";
            cbbSession.ValueMember = "IdSession";
            cbbSession.SelectedIndex = -1;
        }

        // =============================
        // CHARGER DATAGRIDVIEW
        // =============================
        private void ChargerMemoires()
        {
            dgMemoire.DataSource = null;

            dgMemoire.DataSource = memoires.Select(m => new
            {
                m.IdMemoire,
                m.SujetMemoire,
                AnneeAcademique = m.AnneeAcademique != null
                    ? m.AnneeAcademique.LibelleAnneeAcademique
                    : "",
                Session = m.Session != null
                    ? m.Session.LibelleSession
                    : ""
            }).ToList();

            dgMemoire.ClearSelection();

            // Stylisation moderne du DataGridView
            if (dgMemoire.ColumnCount > 0)
            {
                dgMemoire.EnableHeadersVisualStyles = false;
                dgMemoire.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
                dgMemoire.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgMemoire.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                dgMemoire.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgMemoire.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
                dgMemoire.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
                dgMemoire.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

                dgMemoire.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
                dgMemoire.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            }
        }

        // =============================
        // AJOUTER
        // =============================
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!VerifierChamps()) return;

            int newId = memoires.Count == 0
                ? 1
                : memoires.Max(x => x.IdMemoire) + 1;

            Memoire memoire = new Memoire
            {
                IdMemoire = newId,
                SujetMemoire = txtSujetMemoire.Text.Trim(),
                IdAnneeAcademique = (int)cbbAnneeAcademique.SelectedValue,
                IdSession = (int)cbbSession.SelectedValue,
                AnneeAcademique = annees.First(a =>
                    a.IdAnneeAcademique == (int)cbbAnneeAcademique.SelectedValue),
                Session = sessions.First(s =>
                    s.IdSession == (int)cbbSession.SelectedValue)
            };

            memoires.Add(memoire);
            ChargerMemoires();
            Effacer();
        }

        // =============================
        // SELECTIONNER
        // =============================
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;

            txtSujetMemoire.Text =
                dgMemoire.CurrentRow.Cells["SujetMemoire"].Value.ToString();

            cbbAnneeAcademique.Text =
                dgMemoire.CurrentRow.Cells["AnneeAcademique"].Value.ToString();

            cbbSession.Text =
                dgMemoire.CurrentRow.Cells["Session"].Value.ToString();
        }

        // =============================
        // MODIFIER
        // =============================
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;
            if (!VerifierChamps()) return;

            int id = Convert.ToInt32(
                dgMemoire.CurrentRow.Cells["IdMemoire"].Value);

            Memoire memoire = memoires.FirstOrDefault(x => x.IdMemoire == id);
            if (memoire == null) return;

            memoire.SujetMemoire = txtSujetMemoire.Text.Trim();
            memoire.AnneeAcademique = annees.First(a =>
                a.IdAnneeAcademique == (int)cbbAnneeAcademique.SelectedValue);
            memoire.Session = sessions.First(s =>
                s.IdSession == (int)cbbSession.SelectedValue);

            ChargerMemoires();
            Effacer();
        }

        // =============================
        // SUPPRIMER
        // =============================
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;

            int id = Convert.ToInt32(
                dgMemoire.CurrentRow.Cells["IdMemoire"].Value);

            Memoire memoire = memoires.FirstOrDefault(x => x.IdMemoire == id);
            if (memoire == null) return;

            if (MessageBox.Show(
                "Voulez-vous supprimer ce mémoire ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                memoires.Remove(memoire);
                ChargerMemoires();
                Effacer();
            }
        }

        // =============================
        // VALIDATION
        // =============================
        private bool VerifierChamps()
        {
            if (string.IsNullOrWhiteSpace(txtSujetMemoire.Text) ||
                cbbAnneeAcademique.SelectedIndex == -1 ||
                cbbSession.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Veuillez remplir tous les champs.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }

        // =============================
        // NETTOYER
        // =============================
        private void Effacer()
        {
            txtSujetMemoire.Clear();
            cbbAnneeAcademique.SelectedIndex = -1;
            cbbSession.SelectedIndex = -1;
            txtSujetMemoire.Focus();
        }
    }
}
