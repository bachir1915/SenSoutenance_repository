using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmSoutenance : Form
    {
        private List<Soutenance> soutenances = new List<Soutenance>();
        private List<Memoire> memoires = new List<Memoire>();

        public frmSoutenance()
        {
            InitializeComponent();
        }

        private void frmSoutenance_Load(object sender, EventArgs e)
        {
            // Initialisation de la liste pour simulation
            memoires.Add(new Memoire { IdMemoire = 1, SujetMemoire = "N/A" });
            ChargerSoutenances();
        }



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
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int newId = soutenances.Count == 0 ? 1 : soutenances.Max(x => x.IdSoutenance) + 1;
            Soutenance s = new Soutenance
            {
                IdSoutenance = newId,
                DatwSoutenance = dtpDate.Value,
                LieuSoutenance = txtLieu.Text.Trim(),
                ResultatSoutenance = txtResultat.Text.Trim(),
                MentionSoutenance = txtMention.Text.Trim(),
                ObservationSoutenance = txtObservation.Text.Trim(),
                IdMemoire = 1,
                Memoire = memoires.First()
            };

            soutenances.Add(s);
            ChargerSoutenances();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            int id = (int)dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value;
            var s = soutenances.FirstOrDefault(x => x.IdSoutenance == id);
            if (s != null)
            {
                s.DatwSoutenance = dtpDate.Value;
                s.LieuSoutenance = txtLieu.Text.Trim();
                s.ResultatSoutenance = txtResultat.Text.Trim();
                s.MentionSoutenance = txtMention.Text.Trim();
                s.ObservationSoutenance = txtObservation.Text.Trim();
                s.IdMemoire = 1;
                s.Memoire = memoires.First();
                ChargerSoutenances();
                Effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;

            if (MessageBox.Show("Supprimer cette soutenance ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value;
                var s = soutenances.FirstOrDefault(x => x.IdSoutenance == id);
                if (s != null)
                {
                    soutenances.Remove(s);
                    ChargerSoutenances();
                    Effacer();
                }
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgSoutenance.CurrentRow == null) return;
            int id = (int)dgSoutenance.CurrentRow.Cells["IdSoutenance"].Value;
            var s = soutenances.FirstOrDefault(x => x.IdSoutenance == id);
            if (s != null)
            {
                dtpDate.Value = s.DatwSoutenance;
                txtLieu.Text = s.LieuSoutenance;
                txtResultat.Text = s.ResultatSoutenance;
                txtMention.Text = s.MentionSoutenance;
                txtObservation.Text = s.ObservationSoutenance;
            }
        }

        private void Effacer()
        {
            txtLieu.Clear();
            txtResultat.Clear();
            txtMention.Clear();
            txtObservation.Clear();
            dtpDate.Value = DateTime.Now;
        }
    }
}
