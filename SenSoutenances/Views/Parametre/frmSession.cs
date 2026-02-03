using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmSession : Form
    {
        
        // LISTES DE SIMULATION
     
        private List<AnneeAcademique> annees = new List<AnneeAcademique>();
        private List<Session> sessions = new List<Session>();

        public frmSession()
        {
            InitializeComponent();
        }

      
        // Chargement du formulaire
        
        private void frmSession_Load(object sender, EventArgs e)
        {
            ChargerSessions();
            Effacer();
        }

        
        // Charger ComboBox Année académique (SIMULATION)
      


        
        // Charger DataGridView Sessions (SIMULATION)
       
        private void ChargerSessions()
        {
            dgSession.DataSource = null;
            dgSession.DataSource = sessions
                .Select(s => new
                {
                    s.IdSession,
                    s.LibelleSession,
                    AnneeAcademique = annees
                        .First(a => a.IdAnneeAcademique == s.IdAnneeAcademique)
                        .LibelleAnneeAcademique
                })
                .ToList();

            dgSession.ClearSelection();
        }

        
        // Réinitialiser le formulaire
       
        private void Effacer()
        {
            txtSession.Clear();
            txtSession.Focus();
        }

        
        // Ajouter (SIMULATION)
        
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (!VerifierChamps()) return;

            int newId = sessions.Count == 0 ? 1 : sessions.Max(s => s.IdSession) + 1;

            sessions.Add(new Session
            {
                IdSession = newId,
                LibelleSession = txtSession.Text.Trim(),
                IdAnneeAcademique = 1 // Default
            });

            ChargerSessions();
            Effacer();
        }

        
        // Modifier (SIMULATION)
        
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            int id = (int)dgSession.CurrentRow.Cells[0].Value;
            var session = sessions.FirstOrDefault(s => s.IdSession == id);
            if (session == null) return;

            session.LibelleSession = txtSession.Text.Trim();
            session.IdAnneeAcademique = 1; // Default

            ChargerSessions();
            Effacer();
        }

      
        // Supprimer (SIMULATION)
       
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            DialogResult rep = MessageBox.Show(
                "Voulez-vous vraiment supprimer cette session ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rep != DialogResult.Yes) return;

            int id = (int)dgSession.CurrentRow.Cells[0].Value;
            sessions.RemoveAll(s => s.IdSession == id);

            ChargerSessions();
            Effacer();
        }

        
        // Sélectionner
        
        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgSession.CurrentRow == null) return;

            txtSession.Text = dgSession.CurrentRow.Cells[1].Value.ToString();
        }

        
        // Vérification des champs
     
        private bool VerifierChamps()
        {
            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Veuillez saisir la session.");
                txtSession.Focus();
                return false;
            }



            return true;
        }
    }
}
