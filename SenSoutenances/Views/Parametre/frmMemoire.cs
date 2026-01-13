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
            // Initialisation des listes pour éviter les erreurs de mapping dans le Select
            annees.Add(new AnneeAcademique { IdAnneeAcademique = 1, LibelleAnneeAcademique = "N/A" });
            sessions.Add(new Session { IdSession = 1, LibelleSession = "N/A" });
            ChargerMemoires();
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
                IdAnneeAcademique = 1,
                AnneeAcademique = annees.First(),
                IdSession = 1,
                Session = sessions.First()
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
                m.IdAnneeAcademique = 1;
                m.AnneeAcademique = annees.First();
                m.IdSession = 1;
                m.Session = sessions.First();
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
            }
        }
    }
}
