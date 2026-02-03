using SenSoutenance.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SenSoutenance.Views.Parametre
{
    public partial class frmUtilisateur : Form
    {
        private List<Utilisateur> utilisateurs = new List<Utilisateur>();
        private List<Professeur> professeurs = new List<Professeur>();
        private List<Candidat> candidats = new List<Candidat>();
        private List<ChefDepartement> chefs = new List<ChefDepartement>();

        public frmUtilisateur()
        {
            InitializeComponent();
        }

        public void SelectTab(int index)
        {
            if (index >= 0 && index < tabControl1.TabCount)
            {
                tabControl1.SelectedIndex = index;
            }
        }

        private void frmUtilisateur_Load(object sender, EventArgs e)
        {
            // Forcer l'affichage des onglets au cas où
            tabControl1.Appearance = TabAppearance.Normal;
            tabControl1.SizeMode = TabSizeMode.Normal;
            tabControl1.Dock = DockStyle.Fill;
            
            ChargerUtilisateurs();
            ChargerProfesseurs();
            ChargerCandidats();
            ChargerChefs();
        }

        private void ChargerUtilisateurs()
        {
            dgUtilisateurs.DataSource = null;
            dgUtilisateurs.DataSource = utilisateurs.ToList();
            dgUtilisateurs.ClearSelection();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Veuillez remplir au moins le nom et l'email.");
                return;
            }

            int newId = utilisateurs.Count == 0 ? 1 : utilisateurs.Max(x => x.IdUtilisateur) + 1;
            utilisateurs.Add(new Utilisateur
            {
                IdUtilisateur = newId,
                NomUtilisateur = txtNom.Text.Trim(),
                PrenomUtilisateur = txtPrenom.Text.Trim(),
                TelUtilisateur = txtTel.Text.Trim(),
                EmailUtilisateur = txtLogin.Text.Trim()
            });

            ChargerUtilisateurs();
            Effacer();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgUtilisateurs.CurrentRow == null) return;

            int id = (int)dgUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;
            var u = utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (u != null)
            {
                u.NomUtilisateur = txtNom.Text.Trim();
                u.PrenomUtilisateur = txtPrenom.Text.Trim();
                u.TelUtilisateur = txtTel.Text.Trim();
                u.EmailUtilisateur = txtLogin.Text.Trim();
                ChargerUtilisateurs();
                Effacer();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgUtilisateurs.CurrentRow == null) return;

            if (MessageBox.Show("Supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = (int)dgUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;
                var u = utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
                if (u != null)
                {
                    utilisateurs.Remove(u);
                    ChargerUtilisateurs();
                    Effacer();
                }
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (dgUtilisateurs.CurrentRow == null) return;
            int id = (int)dgUtilisateurs.CurrentRow.Cells["IdUtilisateur"].Value;
            var u = utilisateurs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (u != null)
            {
                txtNom.Text = u.NomUtilisateur;
                txtPrenom.Text = u.PrenomUtilisateur;
                txtTel.Text = u.TelUtilisateur;
                txtLogin.Text = u.EmailUtilisateur;
            }
        }

        private void Effacer()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtTel.Clear();
            txtLogin.Clear();
            txtNom.Focus();
        }

        // --- Logique Professeurs ---

        private void ChargerProfesseurs()
        {
            dgProfesseurs.DataSource = null;
            dgProfesseurs.DataSource = professeurs.ToList();
            dgProfesseurs.ClearSelection();
        }

        private void btnAjouterProf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomProf.Text) || string.IsNullOrWhiteSpace(txtEmailProf.Text))
            {
                MessageBox.Show("Veuillez remplir le nom et l'email.");
                return;
            }

            professeurs.Add(new Professeur
            {
                IdUtilisateur = professeurs.Count == 0 ? 1 : professeurs.Max(x => x.IdUtilisateur) + 1,
                NomUtilisateur = txtNomProf.Text.Trim(),
                PrenomUtilisateur = txtPrenomProf.Text.Trim(),
                TelUtilisateur = txtTelProf.Text.Trim(),
                EmailUtilisateur = txtEmailProf.Text.Trim(),
                SpecialiteProfesseur = txtSpecialiteProf.Text.Trim()
            });
            ChargerProfesseurs();
            EffacerProf();
        }

        private void btnModifierProf_Click(object sender, EventArgs e)
        {
            if (dgProfesseurs.CurrentRow == null) return;
            int id = (int)dgProfesseurs.CurrentRow.Cells["IdUtilisateur"].Value;
            var p = professeurs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (p != null)
            {
                p.NomUtilisateur = txtNomProf.Text.Trim();
                p.PrenomUtilisateur = txtPrenomProf.Text.Trim();
                p.TelUtilisateur = txtTelProf.Text.Trim();
                p.EmailUtilisateur = txtEmailProf.Text.Trim();
                p.SpecialiteProfesseur = txtSpecialiteProf.Text.Trim();
                ChargerProfesseurs();
                EffacerProf();
            }
        }

        private void btnSupprimerProf_Click(object sender, EventArgs e)
        {
            if (dgProfesseurs.CurrentRow == null) return;
            if (MessageBox.Show("Supprimer ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgProfesseurs.CurrentRow.Cells["IdUtilisateur"].Value;
                var p = professeurs.FirstOrDefault(x => x.IdUtilisateur == id);
                if (p != null)
                {
                    professeurs.Remove(p);
                    ChargerProfesseurs();
                    EffacerProf();
                }
            }
        }

        private void btnSelectionnerProf_Click(object sender, EventArgs e)
        {
            if (dgProfesseurs.CurrentRow == null) return;
            int id = (int)dgProfesseurs.CurrentRow.Cells["IdUtilisateur"].Value;
            var p = professeurs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (p != null)
            {
                txtNomProf.Text = p.NomUtilisateur;
                txtPrenomProf.Text = p.PrenomUtilisateur;
                txtTelProf.Text = p.TelUtilisateur;
                txtEmailProf.Text = p.EmailUtilisateur;
                txtSpecialiteProf.Text = p.SpecialiteProfesseur;
            }
        }

        private void EffacerProf()
        {
            txtNomProf.Clear(); txtPrenomProf.Clear(); txtTelProf.Clear();
            txtEmailProf.Clear(); txtSpecialiteProf.Clear();
        }

        // --- Logique Candidats ---

        private void ChargerCandidats()
        {
            dgCandidats.DataSource = null;
            dgCandidats.DataSource = candidats.ToList();
            dgCandidats.ClearSelection();
        }

        private void btnAjouterCand_Click(object sender, EventArgs e)
        {
            candidats.Add(new Candidat
            {
                IdUtilisateur = candidats.Count == 0 ? 1 : candidats.Max(x => x.IdUtilisateur) + 1,
                NomUtilisateur = txtNomCand.Text.Trim(),
                PrenomUtilisateur = txtPrenomCand.Text.Trim(),
                TelUtilisateur = txtTelCand.Text.Trim(),
                EmailUtilisateur = txtEmailCand.Text.Trim(),
                MatriculeCandidat = txtMatriculeCand.Text.Trim()
            });
            ChargerCandidats();
            EffacerCand();
        }

        private void btnModifierCand_Click(object sender, EventArgs e)
        {
            if (dgCandidats.CurrentRow == null) return;
            int id = (int)dgCandidats.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = candidats.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null)
            {
                c.NomUtilisateur = txtNomCand.Text.Trim();
                c.PrenomUtilisateur = txtPrenomCand.Text.Trim();
                c.TelUtilisateur = txtTelCand.Text.Trim();
                c.EmailUtilisateur = txtEmailCand.Text.Trim();
                c.MatriculeCandidat = txtMatriculeCand.Text.Trim();
                ChargerCandidats();
                EffacerCand();
            }
        }

        private void btnSupprimerCand_Click(object sender, EventArgs e)
        {
            if (dgCandidats.CurrentRow == null) return;
            int id = (int)dgCandidats.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = candidats.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null) { candidats.Remove(c); ChargerCandidats(); EffacerCand(); }
        }

        private void btnSelectionnerCand_Click(object sender, EventArgs e)
        {
            if (dgCandidats.CurrentRow == null) return;
            int id = (int)dgCandidats.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = candidats.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null)
            {
                txtNomCand.Text = c.NomUtilisateur; txtPrenomCand.Text = c.PrenomUtilisateur;
                txtTelCand.Text = c.TelUtilisateur; txtEmailCand.Text = c.EmailUtilisateur;
                txtMatriculeCand.Text = c.MatriculeCandidat;
            }
        }

        private void EffacerCand()
        {
            txtNomCand.Clear(); txtPrenomCand.Clear(); txtTelCand.Clear();
            txtEmailCand.Clear(); txtMatriculeCand.Clear();
        }

        // --- Logique Chefs ---

        private void ChargerChefs()
        {
            dgChefs.DataSource = null;
            dgChefs.DataSource = chefs.ToList();
            dgChefs.ClearSelection();
        }

        private void btnAjouterChef_Click(object sender, EventArgs e)
        {
            chefs.Add(new ChefDepartement
            {
                IdUtilisateur = chefs.Count == 0 ? 1 : chefs.Max(x => x.IdUtilisateur) + 1,
                NomUtilisateur = txtNomChef.Text.Trim(),
                PrenomUtilisateur = txtPrenomChef.Text.Trim(),
                TelUtilisateur = txtTelChef.Text.Trim(),
                EmailUtilisateur = txtEmailChef.Text.Trim()
            });
            ChargerChefs();
            EffacerChef();
        }

        private void btnModifierChef_Click(object sender, EventArgs e)
        {
            if (dgChefs.CurrentRow == null) return;
            int id = (int)dgChefs.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = chefs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null)
            {
                c.NomUtilisateur = txtNomChef.Text.Trim();
                c.PrenomUtilisateur = txtPrenomChef.Text.Trim();
                c.TelUtilisateur = txtTelChef.Text.Trim();
                c.EmailUtilisateur = txtEmailChef.Text.Trim();
                ChargerChefs();
                EffacerChef();
            }
        }

        private void btnSupprimerChef_Click(object sender, EventArgs e)
        {
            if (dgChefs.CurrentRow == null) return;
            int id = (int)dgChefs.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = chefs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null) { chefs.Remove(c); ChargerChefs(); EffacerChef(); }
        }

        private void btnSelectionnerChef_Click(object sender, EventArgs e)
        {
            if (dgChefs.CurrentRow == null) return;
            int id = (int)dgChefs.CurrentRow.Cells["IdUtilisateur"].Value;
            var c = chefs.FirstOrDefault(x => x.IdUtilisateur == id);
            if (c != null)
            {
                txtNomChef.Text = c.NomUtilisateur; txtPrenomChef.Text = c.PrenomUtilisateur;
                txtTelChef.Text = c.TelUtilisateur; txtEmailChef.Text = c.EmailUtilisateur;
            }
        }

        private void EffacerChef()
        {
            txtNomChef.Clear(); txtPrenomChef.Clear(); txtTelChef.Clear();
            txtEmailChef.Clear();
        }
    }
}
