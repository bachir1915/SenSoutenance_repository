using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmSession : global::System.Windows.Forms.Form
    {
        public frmSession()
        {
            InitializeComponent();
        }

        BdSenSoutenanceContext db;

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
                Session session = db.sessions.Find(id);
                if (session != null)
                {
                    session.LibelleSession = txtSession.Text;
                    session.IdAnneeAcademique = (int?)cbbAnneeAcademique.SelectedValue;
                    db.SaveChanges();
                    Effacer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message);
            }
        }

        private void frmSession_Load(object sender, EventArgs e)
        {
            db = new BdSenSoutenanceContext();
            Effacer();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Session session = new Session()
            {
                LibelleSession = txtSession.Text,
                IdAnneeAcademique = (int?)cbbAnneeAcademique.SelectedValue
            };
            db.sessions.Add(session);
            db.SaveChanges();
            Effacer();
        }

        private void Effacer()
        {
            txtSession.Clear();
            cbbAnneeAcademique.SelectedValue = null;
            dgSession.DataSource = db.sessions.ToList();
            cbbAnneeAcademique.DataSource = db.anneeAcademiques.ToList();
            cbbAnneeAcademique.DisplayMember = "LibelleAnneeAcademique";
            cbbAnneeAcademique.ValueMember = "IdAnneeAcademique";
            txtSession.Focus();
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            txtSession.Text = session.LibelleSession;
            cbbAnneeAcademique.SelectedValue = session.IdAnneeAcademique;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgSession.CurrentRow.Cells[0].Value.ToString());
            Session session = db.sessions.Find(id);
            db.sessions.Remove(session);
            db.SaveChanges();
            Effacer();
        }
    }
}
