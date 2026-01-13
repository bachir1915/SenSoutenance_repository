using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmMemoire : Form
    {
        private List<Memoire> memoires = new List<Memoire>();
        // Simulation de données pour les ComboBox
        private List<AnneeAcademique> annees = new List<AnneeAcademique>();
        private List<Session> sessions = new List<Session>();

        public frmMemoire()
        {
            InitializeComponent();
        }

        private void frmMemoire_Load(object sender, EventArgs e)
        {
            ChargerData();
            ChargerMemoires();
        }

        private void ChargerData()
        {
            // Simulation
            annees.Add(new AnneeAcademique { IdAnneeAcademique = 1, LibelleAnneeAcademique = "2024-2025" });
            sessions.Add(new Session { IdSession = 1, LibelleSession = "Unique" });

            cboAnnee.DataSource = annees;
            cboAnnee.DisplayMember = "LibelleAnneeAcademique";
            cboAnnee.ValueMember = "IdAnneeAcademique";

            cboSession.DataSource = sessions;
            cboSession.DisplayMember = "LibelleSession";
            cboSession.ValueMember = "IdSession";
        }

        private void ChargerMemoires()
        {
            dgMemoire.DataSource = null;
            dgMemoire.DataSource = memoires.Select(m => new
            {
                m.IdMemoire,
                m.SujetMemoire,
                Annee = m.AnneeAcademique?.LibelleAnneeAcademique,
                Session = m.Session?.LibelleSession
            }).ToList();
            dgMemoire.ClearSelection();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSujet.Text))
            {
                MessageBox.Show("Veuillez saisir le sujet du mémoire.");
                return;
            }

            int newId = memoires.Count == 0 ? 1 : memoires.Max(x => x.IdMemoire) + 1;
            Memoire m = new Memoire
            {
                IdMemoire = newId,
                SujetMemoire = txtSujet.Text.Trim(),
                IdAnneeAcademique = (int)cboAnnee.SelectedValue,
                AnneeAcademique = (AnneeAcademique)cboAnnee.SelectedItem,
                IdSession = (int)cboSession.SelectedValue,
                Session = (Session)cboSession.SelectedItem
            };

            memoires.Add(m);
            ChargerMemoires();
            txtSujet.Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;
            if (string.IsNullOrWhiteSpace(txtSujet.Text)) return;

            int id = (int)dgMemoire.CurrentRow.Cells["IdMemoire"].Value;
            var m = memoires.FirstOrDefault(x => x.IdMemoire == id);
            if (m != null)
            {
                m.SujetMemoire = txtSujet.Text.Trim();
                m.IdAnneeAcademique = (int)cboAnnee.SelectedValue;
                m.AnneeAcademique = (AnneeAcademique)cboAnnee.SelectedItem;
                m.IdSession = (int)cboSession.SelectedValue;
                m.Session = (Session)cboSession.SelectedItem;
                ChargerMemoires();
                txtSujet.Clear();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;

            if (MessageBox.Show("Supprimer ce mémoire ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dgMemoire.CurrentRow.Cells["IdMemoire"].Value;
                var m = memoires.FirstOrDefault(x => x.IdMemoire == id);
                if (m != null)
                {
                    memoires.Remove(m);
                    ChargerMemoires();
                    txtSujet.Clear();
                }
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgMemoire.CurrentRow == null) return;
            int id = (int)dgMemoire.CurrentRow.Cells["IdMemoire"].Value;
            var m = memoires.FirstOrDefault(x => x.IdMemoire == id);
            if (m != null)
            {
                txtSujet.Text = m.SujetMemoire;
                cboAnnee.SelectedValue = m.IdAnneeAcademique;
                cboSession.SelectedValue = m.IdSession;
            }
        }
    }
}
