using SenSoutenance.Views.Parametre;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

       
        // Méthode : fermer tous les formulaires enfants MDI
       
        private void FermerTousLesForms()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        // =====================================================
        // Méthode générique : ouvrir un formulaire dans le MDI
        // =====================================================
        private void OuvrirForm<T>(string titre) where T : Form, new()
        {
            // Vérifier si le formulaire est déjà ouvert
            Form formExistant = this.MdiChildren
                .FirstOrDefault(f => f is T);

            if (formExistant != null)
            {
                formExistant.BringToFront();
                return;
            }

            FermerTousLesForms();

            Form form = new T
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };

            this.Text = $"Sen Soutenance - [{titre}]";
            form.Show();
        }

        
        // Chargement du formulaire MDI
        
        private void frmMDI_Load(object sender, EventArgs e)
        {
            // Plein écran déjà géré par Designer
            // Gestion des droits

            if (SessionUtilisateur.Role == "Admin")
            {
                securiteToolStripMenuItem.Visible = true;
            }
            else
            {
                securiteToolStripMenuItem.Visible = false;
            }
        }

        
        // MENU PARAMÈTRE
      
        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm<frmAnneeAcademique>("Année Académique");
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm<frmSession>("Session");
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm<frmDepartement>("Département");
        }


        private void memoireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm<frmMemoire>("Mémoire");
        }

        private void soutenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm<frmSoutenance>("Soutenance");
        }




        // MENU ACTION

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show(
                "Voulez-vous vraiment vous déconnecter ?",
                "Déconnexion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rep == DialogResult.Yes)
            {
                new frmConnexion().Show();
                this.Close();
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rep = MessageBox.Show(
                "Voulez-vous vraiment quitter l'application ?",
                "Quitter",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (rep == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirForm<frmUtilisateur>("Utilisateur");
        }

        private void securiteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
    }
}
