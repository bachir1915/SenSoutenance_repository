namespace SenSoutenance.Views.Parametre
{
    partial class frmUtilisateur
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUtilisateurs = new System.Windows.Forms.TabPage();
            this.tabProfesseurs = new System.Windows.Forms.TabPage();
            this.tabCandidats = new System.Windows.Forms.TabPage();
            this.tabChefs = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.dgUtilisateurs = new System.Windows.Forms.DataGridView();
            this.labelNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dgProfesseurs = new System.Windows.Forms.DataGridView();
            this.btnSupprimerProf = new System.Windows.Forms.Button();
            this.btnModifierProf = new System.Windows.Forms.Button();
            this.btnSelectionnerProf = new System.Windows.Forms.Button();
            this.btnAjouterProf = new System.Windows.Forms.Button();
            this.txtSpecialiteProf = new System.Windows.Forms.TextBox();
            this.labelSpecialiteProf = new System.Windows.Forms.Label();
            this.txtEmailProf = new System.Windows.Forms.TextBox();
            this.labelEmailProf = new System.Windows.Forms.Label();
            this.txtTelProf = new System.Windows.Forms.TextBox();
            this.labelTelProf = new System.Windows.Forms.Label();
            this.txtPrenomProf = new System.Windows.Forms.TextBox();
            this.labelPrenomProf = new System.Windows.Forms.Label();
            this.txtNomProf = new System.Windows.Forms.TextBox();
            this.labelNomProf = new System.Windows.Forms.Label();
            this.dgCandidats = new System.Windows.Forms.DataGridView();
            this.btnSupprimerCand = new System.Windows.Forms.Button();
            this.btnModifierCand = new System.Windows.Forms.Button();
            this.btnSelectionnerCand = new System.Windows.Forms.Button();
            this.btnAjouterCand = new System.Windows.Forms.Button();
            this.txtMatriculeCand = new System.Windows.Forms.TextBox();
            this.labelMatriculeCand = new System.Windows.Forms.Label();
            this.txtEmailCand = new System.Windows.Forms.TextBox();
            this.labelEmailCand = new System.Windows.Forms.Label();
            this.txtTelCand = new System.Windows.Forms.TextBox();
            this.labelTelCand = new System.Windows.Forms.Label();
            this.txtPrenomCand = new System.Windows.Forms.TextBox();
            this.labelPrenomCand = new System.Windows.Forms.Label();
            this.txtNomCand = new System.Windows.Forms.TextBox();
            this.labelNomCand = new System.Windows.Forms.Label();
            this.dgChefs = new System.Windows.Forms.DataGridView();
            this.btnSupprimerChef = new System.Windows.Forms.Button();
            this.btnModifierChef = new System.Windows.Forms.Button();
            this.btnSelectionnerChef = new System.Windows.Forms.Button();
            this.btnAjouterChef = new System.Windows.Forms.Button();
            this.txtEmailChef = new System.Windows.Forms.TextBox();
            this.labelEmailChef = new System.Windows.Forms.Label();
            this.txtTelChef = new System.Windows.Forms.TextBox();
            this.labelTelChef = new System.Windows.Forms.Label();
            this.txtPrenomChef = new System.Windows.Forms.TextBox();
            this.labelPrenomChef = new System.Windows.Forms.Label();
            this.txtNomChef = new System.Windows.Forms.TextBox();
            this.labelNomChef = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUtilisateurs.SuspendLayout();
            this.tabProfesseurs.SuspendLayout();
            this.tabCandidats.SuspendLayout();
            this.tabChefs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChefs)).BeginInit();
            this.SuspendLayout();
            // 
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(20, 20);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 11;
            this.labelNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(23, 40);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 25);
            this.txtNom.TabIndex = 12;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(20, 75);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(53, 17);
            this.labelPrenom.TabIndex = 13;
            this.labelPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(23, 95);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 25);
            this.txtPrenom.TabIndex = 14;
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(20, 130);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(68, 17);
            this.labelTel.TabIndex = 15;
            this.labelTel.Text = "Téléphone";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(23, 150);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 25);
            this.txtTel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(243, 40);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(200, 25);
            this.txtLogin.TabIndex = 1;
            // 

            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(23, 200);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 35);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelectionner.FlatAppearance.BorderSize = 0;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(130, 200);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(100, 35);
            this.btnSelectionner.TabIndex = 7;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(237, 200);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 35);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(344, 200);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 35);
            this.btnSupprimer.TabIndex = 9;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.TabPages.Add(this.tabUtilisateurs);
            this.tabControl1.TabPages.Add(this.tabProfesseurs);
            this.tabControl1.TabPages.Add(this.tabCandidats);
            this.tabControl1.TabPages.Add(this.tabChefs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabUtilisateurs
            // 
            this.tabUtilisateurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabUtilisateurs.Controls.Add(this.dgUtilisateurs);
            this.tabUtilisateurs.Controls.Add(this.btnSupprimer);
            this.tabUtilisateurs.Controls.Add(this.btnModifier);
            this.tabUtilisateurs.Controls.Add(this.btnSelectionner);
            this.tabUtilisateurs.Controls.Add(this.btnAjouter);
            this.tabUtilisateurs.Controls.Add(this.txtTel);
            this.tabUtilisateurs.Controls.Add(this.labelTel);
            this.tabUtilisateurs.Controls.Add(this.txtPrenom);
            this.tabUtilisateurs.Controls.Add(this.labelPrenom);
            this.tabUtilisateurs.Controls.Add(this.txtNom);
            this.tabUtilisateurs.Controls.Add(this.labelNom);
            this.tabUtilisateurs.Controls.Add(this.txtLogin);
            this.tabUtilisateurs.Controls.Add(this.label1);
            this.tabUtilisateurs.Location = new System.Drawing.Point(4, 26);
            this.tabUtilisateurs.Name = "tabUtilisateurs";
            this.tabUtilisateurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtilisateurs.Size = new System.Drawing.Size(822, 420);
            this.tabUtilisateurs.TabIndex = 0;
            this.tabUtilisateurs.Text = "Utilisateurs";
            // 
            // tabCandidats
            // 
            this.tabCandidats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabCandidats.Controls.Add(this.dgCandidats);
            this.tabCandidats.Controls.Add(this.btnSupprimerCand);
            this.tabCandidats.Controls.Add(this.btnModifierCand);
            this.tabCandidats.Controls.Add(this.btnSelectionnerCand);
            this.tabCandidats.Controls.Add(this.btnAjouterCand);
            this.tabCandidats.Controls.Add(this.txtMatriculeCand);
            this.tabCandidats.Controls.Add(this.labelMatriculeCand);
            this.tabCandidats.Controls.Add(this.txtEmailCand);
            this.tabCandidats.Controls.Add(this.labelEmailCand);
            this.tabCandidats.Controls.Add(this.txtTelCand);
            this.tabCandidats.Controls.Add(this.labelTelCand);
            this.tabCandidats.Controls.Add(this.txtPrenomCand);
            this.tabCandidats.Controls.Add(this.labelPrenomCand);
            this.tabCandidats.Controls.Add(this.txtNomCand);
            this.tabCandidats.Controls.Add(this.labelNomCand);
            this.tabCandidats.Location = new System.Drawing.Point(4, 26);
            this.tabCandidats.Name = "tabCandidats";
            this.tabCandidats.Size = new System.Drawing.Size(822, 420);
            this.tabCandidats.TabIndex = 2;
            this.tabCandidats.Text = "Candidats";
            // 
            // dgCandidats
            // 
            this.dgCandidats.BackgroundColor = System.Drawing.Color.White;
            this.dgCandidats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCandidats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCandidats.Location = new System.Drawing.Point(460, 40);
            this.dgCandidats.Name = "dgCandidats";
            this.dgCandidats.ReadOnly = true;
            this.dgCandidats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCandidats.Size = new System.Drawing.Size(350, 300);
            this.dgCandidats.TabIndex = 44;
            // 
            // btnSupprimerCand
            // 
            this.btnSupprimerCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimerCand.FlatAppearance.BorderSize = 0;
            this.btnSupprimerCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerCand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerCand.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerCand.Location = new System.Drawing.Point(344, 260);
            this.btnSupprimerCand.Name = "btnSupprimerCand";
            this.btnSupprimerCand.Size = new System.Drawing.Size(100, 35);
            this.btnSupprimerCand.TabIndex = 43;
            this.btnSupprimerCand.Text = "Supprimer";
            this.btnSupprimerCand.UseVisualStyleBackColor = false;
            this.btnSupprimerCand.Click += new System.EventHandler(this.btnSupprimerCand_Click);
            // 
            // btnModifierCand
            // 
            this.btnModifierCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnModifierCand.FlatAppearance.BorderSize = 0;
            this.btnModifierCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierCand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifierCand.ForeColor = System.Drawing.Color.White;
            this.btnModifierCand.Location = new System.Drawing.Point(237, 260);
            this.btnModifierCand.Name = "btnModifierCand";
            this.btnModifierCand.Size = new System.Drawing.Size(100, 35);
            this.btnModifierCand.TabIndex = 42;
            this.btnModifierCand.Text = "Modifier";
            this.btnModifierCand.UseVisualStyleBackColor = false;
            this.btnModifierCand.Click += new System.EventHandler(this.btnModifierCand_Click);
            // 
            // btnSelectionnerCand
            // 
            this.btnSelectionnerCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelectionnerCand.FlatAppearance.BorderSize = 0;
            this.btnSelectionnerCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionnerCand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectionnerCand.ForeColor = System.Drawing.Color.White;
            this.btnSelectionnerCand.Location = new System.Drawing.Point(130, 260);
            this.btnSelectionnerCand.Name = "btnSelectionnerCand";
            this.btnSelectionnerCand.Size = new System.Drawing.Size(100, 35);
            this.btnSelectionnerCand.TabIndex = 41;
            this.btnSelectionnerCand.Text = "Selectionner";
            this.btnSelectionnerCand.UseVisualStyleBackColor = false;
            this.btnSelectionnerCand.Click += new System.EventHandler(this.btnSelectionnerCand_Click);
            // 
            // btnAjouterCand
            // 
            this.btnAjouterCand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouterCand.FlatAppearance.BorderSize = 0;
            this.btnAjouterCand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterCand.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouterCand.ForeColor = System.Drawing.Color.White;
            this.btnAjouterCand.Location = new System.Drawing.Point(23, 260);
            this.btnAjouterCand.Name = "btnAjouterCand";
            this.btnAjouterCand.Size = new System.Drawing.Size(100, 35);
            this.btnAjouterCand.TabIndex = 40;
            this.btnAjouterCand.Text = "Ajouter";
            this.btnAjouterCand.UseVisualStyleBackColor = false;
            this.btnAjouterCand.Click += new System.EventHandler(this.btnAjouterCand_Click);
            // 
            // txtMatriculeCand
            // 
            this.txtMatriculeCand.Location = new System.Drawing.Point(243, 150);
            this.txtMatriculeCand.Name = "txtMatriculeCand";
            this.txtMatriculeCand.Size = new System.Drawing.Size(200, 25);
            this.txtMatriculeCand.TabIndex = 39;
            // 
            // labelMatriculeCand
            // 
            this.labelMatriculeCand.AutoSize = true;
            this.labelMatriculeCand.Location = new System.Drawing.Point(240, 130);
            this.labelMatriculeCand.Name = "labelMatriculeCand";
            this.labelMatriculeCand.Size = new System.Drawing.Size(63, 17);
            this.labelMatriculeCand.TabIndex = 38;
            this.labelMatriculeCand.Text = "Matricule";

            // 
            // txtEmailCand
            // 
            this.txtEmailCand.Location = new System.Drawing.Point(243, 40);
            this.txtEmailCand.Name = "txtEmailCand";
            this.txtEmailCand.Size = new System.Drawing.Size(200, 25);
            this.txtEmailCand.TabIndex = 35;
            // 
            // labelEmailCand
            // 
            this.labelEmailCand.AutoSize = true;
            this.labelEmailCand.Location = new System.Drawing.Point(240, 20);
            this.labelEmailCand.Name = "labelEmailCand";
            this.labelEmailCand.Size = new System.Drawing.Size(39, 17);
            this.labelEmailCand.TabIndex = 34;
            this.labelEmailCand.Text = "Email";
            // 
            // txtTelCand
            // 
            this.txtTelCand.Location = new System.Drawing.Point(23, 150);
            this.txtTelCand.Name = "txtTelCand";
            this.txtTelCand.Size = new System.Drawing.Size(200, 25);
            this.txtTelCand.TabIndex = 33;
            // 
            // labelTelCand
            // 
            this.labelTelCand.AutoSize = true;
            this.labelTelCand.Location = new System.Drawing.Point(20, 130);
            this.labelTelCand.Name = "labelTelCand";
            this.labelTelCand.Size = new System.Drawing.Size(68, 17);
            this.labelTelCand.TabIndex = 32;
            this.labelTelCand.Text = "Téléphone";
            // 
            // txtPrenomCand
            // 
            this.txtPrenomCand.Location = new System.Drawing.Point(23, 95);
            this.txtPrenomCand.Name = "txtPrenomCand";
            this.txtPrenomCand.Size = new System.Drawing.Size(200, 25);
            this.txtPrenomCand.TabIndex = 31;
            // 
            // labelPrenomCand
            // 
            this.labelPrenomCand.AutoSize = true;
            this.labelPrenomCand.Location = new System.Drawing.Point(20, 75);
            this.labelPrenomCand.Name = "labelPrenomCand";
            this.labelPrenomCand.Size = new System.Drawing.Size(53, 17);
            this.labelPrenomCand.TabIndex = 30;
            this.labelPrenomCand.Text = "Prénom";
            // 
            // txtNomCand
            // 
            this.txtNomCand.Location = new System.Drawing.Point(23, 40);
            this.txtNomCand.Name = "txtNomCand";
            this.txtNomCand.Size = new System.Drawing.Size(200, 25);
            this.txtNomCand.TabIndex = 29;
            // 
            // labelNomCand
            // 
            this.labelNomCand.AutoSize = true;
            this.labelNomCand.Location = new System.Drawing.Point(20, 20);
            this.labelNomCand.Name = "labelNomCand";
            this.labelNomCand.Size = new System.Drawing.Size(37, 17);
            this.labelNomCand.TabIndex = 28;
            this.labelNomCand.Text = "Nom";
            // 
            // tabChefs
            // 
            this.tabChefs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabChefs.Controls.Add(this.dgChefs);
            this.tabChefs.Controls.Add(this.btnSupprimerChef);
            this.tabChefs.Controls.Add(this.btnModifierChef);
            this.tabChefs.Controls.Add(this.btnSelectionnerChef);
            this.tabChefs.Controls.Add(this.btnAjouterChef);
            this.tabChefs.Controls.Add(this.txtEmailChef);
            this.tabChefs.Controls.Add(this.labelEmailChef);
            this.tabChefs.Controls.Add(this.txtTelChef);
            this.tabChefs.Controls.Add(this.labelTelChef);
            this.tabChefs.Controls.Add(this.txtPrenomChef);
            this.tabChefs.Controls.Add(this.labelPrenomChef);
            this.tabChefs.Controls.Add(this.txtNomChef);
            this.tabChefs.Controls.Add(this.labelNomChef);
            this.tabChefs.Location = new System.Drawing.Point(4, 26);
            this.tabChefs.Name = "tabChefs";
            this.tabChefs.Size = new System.Drawing.Size(822, 420);
            this.tabChefs.TabIndex = 3;
            this.tabChefs.Text = "Chef Département";
            // 
            // dgChefs
            // 
            this.dgChefs.BackgroundColor = System.Drawing.Color.White;
            this.dgChefs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgChefs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChefs.Location = new System.Drawing.Point(460, 40);
            this.dgChefs.Name = "dgChefs";
            this.dgChefs.ReadOnly = true;
            this.dgChefs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChefs.Size = new System.Drawing.Size(350, 300);
            this.dgChefs.TabIndex = 59;
            // 
            // btnSupprimerChef
            // 
            this.btnSupprimerChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimerChef.FlatAppearance.BorderSize = 0;
            this.btnSupprimerChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerChef.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerChef.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerChef.Location = new System.Drawing.Point(344, 260);
            this.btnSupprimerChef.Name = "btnSupprimerChef";
            this.btnSupprimerChef.Size = new System.Drawing.Size(100, 35);
            this.btnSupprimerChef.TabIndex = 58;
            this.btnSupprimerChef.Text = "Supprimer";
            this.btnSupprimerChef.UseVisualStyleBackColor = false;
            this.btnSupprimerChef.Click += new System.EventHandler(this.btnSupprimerChef_Click);
            // 
            // btnModifierChef
            // 
            this.btnModifierChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnModifierChef.FlatAppearance.BorderSize = 0;
            this.btnModifierChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierChef.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifierChef.ForeColor = System.Drawing.Color.White;
            this.btnModifierChef.Location = new System.Drawing.Point(237, 260);
            this.btnModifierChef.Name = "btnModifierChef";
            this.btnModifierChef.Size = new System.Drawing.Size(100, 35);
            this.btnModifierChef.TabIndex = 57;
            this.btnModifierChef.Text = "Modifier";
            this.btnModifierChef.UseVisualStyleBackColor = false;
            this.btnModifierChef.Click += new System.EventHandler(this.btnModifierChef_Click);
            // 
            // btnSelectionnerChef
            // 
            this.btnSelectionnerChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelectionnerChef.FlatAppearance.BorderSize = 0;
            this.btnSelectionnerChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionnerChef.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectionnerChef.ForeColor = System.Drawing.Color.White;
            this.btnSelectionnerChef.Location = new System.Drawing.Point(130, 260);
            this.btnSelectionnerChef.Name = "btnSelectionnerChef";
            this.btnSelectionnerChef.Size = new System.Drawing.Size(100, 35);
            this.btnSelectionnerChef.TabIndex = 56;
            this.btnSelectionnerChef.Text = "Selectionner";
            this.btnSelectionnerChef.UseVisualStyleBackColor = false;
            this.btnSelectionnerChef.Click += new System.EventHandler(this.btnSelectionnerChef_Click);
            // 
            // btnAjouterChef
            // 
            this.btnAjouterChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouterChef.FlatAppearance.BorderSize = 0;
            this.btnAjouterChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterChef.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouterChef.ForeColor = System.Drawing.Color.White;
            this.btnAjouterChef.Location = new System.Drawing.Point(23, 260);
            this.btnAjouterChef.Name = "btnAjouterChef";
            this.btnAjouterChef.Size = new System.Drawing.Size(100, 35);
            this.btnAjouterChef.TabIndex = 55;
            this.btnAjouterChef.Text = "Ajouter";
            this.btnAjouterChef.UseVisualStyleBackColor = false;
            this.btnAjouterChef.Click += new System.EventHandler(this.btnAjouterChef_Click);
            // 
            // txtEmailChef
            // 
            this.txtEmailChef.Location = new System.Drawing.Point(243, 40);
            this.txtEmailChef.Name = "txtEmailChef";
            this.txtEmailChef.Size = new System.Drawing.Size(200, 25);
            this.txtEmailChef.TabIndex = 50;
            // 
            // labelEmailChef
            // 
            this.labelEmailChef.AutoSize = true;
            this.labelEmailChef.Location = new System.Drawing.Point(240, 20);
            this.labelEmailChef.Name = "labelEmailChef";
            this.labelEmailChef.Size = new System.Drawing.Size(39, 17);
            this.labelEmailChef.TabIndex = 49;
            this.labelEmailChef.Text = "Email";
            // 
            // txtTelChef
            // 
            this.txtTelChef.Location = new System.Drawing.Point(23, 150);
            this.txtTelChef.Name = "txtTelChef";
            this.txtTelChef.Size = new System.Drawing.Size(200, 25);
            this.txtTelChef.TabIndex = 48;
            // 
            // labelTelChef
            // 
            this.labelTelChef.AutoSize = true;
            this.labelTelChef.Location = new System.Drawing.Point(20, 130);
            this.labelTelChef.Name = "labelTelChef";
            this.labelTelChef.Size = new System.Drawing.Size(68, 17);
            this.labelTelChef.TabIndex = 47;
            this.labelTelChef.Text = "Téléphone";
            // 
            // txtPrenomChef
            // 
            this.txtPrenomChef.Location = new System.Drawing.Point(23, 95);
            this.txtPrenomChef.Name = "txtPrenomChef";
            this.txtPrenomChef.Size = new System.Drawing.Size(200, 25);
            this.txtPrenomChef.TabIndex = 46;
            // 
            // labelPrenomChef
            // 
            this.labelPrenomChef.AutoSize = true;
            this.labelPrenomChef.Location = new System.Drawing.Point(20, 75);
            this.labelPrenomChef.Name = "labelPrenomChef";
            this.labelPrenomChef.Size = new System.Drawing.Size(53, 17);
            this.labelPrenomChef.TabIndex = 45;
            this.labelPrenomChef.Text = "Prénom";
            // 
            // txtNomChef
            // 
            this.txtNomChef.Location = new System.Drawing.Point(23, 40);
            this.txtNomChef.Name = "txtNomChef";
            this.txtNomChef.Size = new System.Drawing.Size(200, 25);
            this.txtNomChef.TabIndex = 44;
            // 
            // labelNomChef
            // 
            this.labelNomChef.AutoSize = true;
            this.labelNomChef.Location = new System.Drawing.Point(20, 20);
            this.labelNomChef.Name = "labelNomChef";
            this.labelNomChef.Size = new System.Drawing.Size(37, 17);
            this.labelNomChef.TabIndex = 43;
            this.labelNomChef.Text = "Nom";
            // 
            // 
            // tabProfesseurs
            // 
            this.tabProfesseurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.tabProfesseurs.Controls.Add(this.dgProfesseurs);
            this.tabProfesseurs.Controls.Add(this.btnSupprimerProf);
            this.tabProfesseurs.Controls.Add(this.btnModifierProf);
            this.tabProfesseurs.Controls.Add(this.btnSelectionnerProf);
            this.tabProfesseurs.Controls.Add(this.btnAjouterProf);
            this.tabProfesseurs.Controls.Add(this.txtSpecialiteProf);
            this.tabProfesseurs.Controls.Add(this.labelSpecialiteProf);
            this.tabProfesseurs.Controls.Add(this.txtEmailProf);
            this.tabProfesseurs.Controls.Add(this.labelEmailProf);
            this.tabProfesseurs.Controls.Add(this.txtTelProf);
            this.tabProfesseurs.Controls.Add(this.labelTelProf);
            this.tabProfesseurs.Controls.Add(this.txtPrenomProf);
            this.tabProfesseurs.Controls.Add(this.labelPrenomProf);
            this.tabProfesseurs.Controls.Add(this.txtNomProf);
            this.tabProfesseurs.Controls.Add(this.labelNomProf);
            this.tabProfesseurs.Location = new System.Drawing.Point(4, 26);
            this.tabProfesseurs.Name = "tabProfesseurs";
            this.tabProfesseurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseurs.Size = new System.Drawing.Size(822, 420);
            this.tabProfesseurs.TabIndex = 1;
            this.tabProfesseurs.Text = "Professeurs";
            // 
            // dgProfesseurs
            // 
            this.dgProfesseurs.BackgroundColor = System.Drawing.Color.White;
            this.dgProfesseurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProfesseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesseurs.Location = new System.Drawing.Point(460, 40);
            this.dgProfesseurs.Name = "dgProfesseurs";
            this.dgProfesseurs.ReadOnly = true;
            this.dgProfesseurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfesseurs.Size = new System.Drawing.Size(350, 300);
            this.dgProfesseurs.TabIndex = 27;
            // 
            // btnSupprimerProf
            // 
            this.btnSupprimerProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSupprimerProf.FlatAppearance.BorderSize = 0;
            this.btnSupprimerProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerProf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSupprimerProf.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerProf.Location = new System.Drawing.Point(344, 260);
            this.btnSupprimerProf.Name = "btnSupprimerProf";
            this.btnSupprimerProf.Size = new System.Drawing.Size(100, 35);
            this.btnSupprimerProf.TabIndex = 26;
            this.btnSupprimerProf.Text = "Supprimer";
            this.btnSupprimerProf.UseVisualStyleBackColor = false;
            this.btnSupprimerProf.Click += new System.EventHandler(this.btnSupprimerProf_Click);
            // 
            // btnModifierProf
            // 
            this.btnModifierProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnModifierProf.FlatAppearance.BorderSize = 0;
            this.btnModifierProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierProf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModifierProf.ForeColor = System.Drawing.Color.White;
            this.btnModifierProf.Location = new System.Drawing.Point(237, 260);
            this.btnModifierProf.Name = "btnModifierProf";
            this.btnModifierProf.Size = new System.Drawing.Size(100, 35);
            this.btnModifierProf.TabIndex = 25;
            this.btnModifierProf.Text = "Modifier";
            this.btnModifierProf.UseVisualStyleBackColor = false;
            this.btnModifierProf.Click += new System.EventHandler(this.btnModifierProf_Click);
            // 
            // btnSelectionnerProf
            // 
            this.btnSelectionnerProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelectionnerProf.FlatAppearance.BorderSize = 0;
            this.btnSelectionnerProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionnerProf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectionnerProf.ForeColor = System.Drawing.Color.White;
            this.btnSelectionnerProf.Location = new System.Drawing.Point(130, 260);
            this.btnSelectionnerProf.Name = "btnSelectionnerProf";
            this.btnSelectionnerProf.Size = new System.Drawing.Size(100, 35);
            this.btnSelectionnerProf.TabIndex = 24;
            this.btnSelectionnerProf.Text = "Selectionner";
            this.btnSelectionnerProf.UseVisualStyleBackColor = false;
            this.btnSelectionnerProf.Click += new System.EventHandler(this.btnSelectionnerProf_Click);
            // 
            // btnAjouterProf
            // 
            this.btnAjouterProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouterProf.FlatAppearance.BorderSize = 0;
            this.btnAjouterProf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterProf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAjouterProf.ForeColor = System.Drawing.Color.White;
            this.btnAjouterProf.Location = new System.Drawing.Point(23, 260);
            this.btnAjouterProf.Name = "btnAjouterProf";
            this.btnAjouterProf.Size = new System.Drawing.Size(100, 35);
            this.btnAjouterProf.TabIndex = 23;
            this.btnAjouterProf.Text = "Ajouter";
            this.btnAjouterProf.UseVisualStyleBackColor = false;
            this.btnAjouterProf.Click += new System.EventHandler(this.btnAjouterProf_Click);
            // 
            // txtSpecialiteProf
            // 
            this.txtSpecialiteProf.Location = new System.Drawing.Point(243, 150);
            this.txtSpecialiteProf.Name = "txtSpecialiteProf";
            this.txtSpecialiteProf.Size = new System.Drawing.Size(200, 25);
            this.txtSpecialiteProf.TabIndex = 22;
            // 
            // labelSpecialiteProf
            // 
            this.labelSpecialiteProf.AutoSize = true;
            this.labelSpecialiteProf.Location = new System.Drawing.Point(240, 130);
            this.labelSpecialiteProf.Name = "labelSpecialiteProf";
            this.labelSpecialiteProf.Size = new System.Drawing.Size(63, 17);
            this.labelSpecialiteProf.TabIndex = 21;
            this.labelSpecialiteProf.Text = "Spécialité";
            // 
            // txtEmailProf
            // 
            this.txtEmailProf.Location = new System.Drawing.Point(243, 40);
            this.txtEmailProf.Name = "txtEmailProf";
            this.txtEmailProf.Size = new System.Drawing.Size(200, 25);
            this.txtEmailProf.TabIndex = 18;
            // 
            // labelEmailProf
            // 
            this.labelEmailProf.AutoSize = true;
            this.labelEmailProf.Location = new System.Drawing.Point(240, 20);
            this.labelEmailProf.Name = "labelEmailProf";
            this.labelEmailProf.Size = new System.Drawing.Size(39, 17);
            this.labelEmailProf.TabIndex = 17;
            this.labelEmailProf.Text = "Email";
            // 
            // txtTelProf
            // 
            this.txtTelProf.Location = new System.Drawing.Point(23, 150);
            this.txtTelProf.Name = "txtTelProf";
            this.txtTelProf.Size = new System.Drawing.Size(200, 25);
            this.txtTelProf.TabIndex = 16;
            // 
            // labelTelProf
            // 
            this.labelTelProf.AutoSize = true;
            this.labelTelProf.Location = new System.Drawing.Point(20, 130);
            this.labelTelProf.Name = "labelTelProf";
            this.labelTelProf.Size = new System.Drawing.Size(68, 17);
            this.labelTelProf.TabIndex = 15;
            this.labelTelProf.Text = "Téléphone";
            // 
            // txtPrenomProf
            // 
            this.txtPrenomProf.Location = new System.Drawing.Point(23, 95);
            this.txtPrenomProf.Name = "txtPrenomProf";
            this.txtPrenomProf.Size = new System.Drawing.Size(200, 25);
            this.txtPrenomProf.TabIndex = 14;
            // 
            // labelPrenomProf
            // 
            this.labelPrenomProf.AutoSize = true;
            this.labelPrenomProf.Location = new System.Drawing.Point(20, 75);
            this.labelPrenomProf.Name = "labelPrenomProf";
            this.labelPrenomProf.Size = new System.Drawing.Size(53, 17);
            this.labelPrenomProf.TabIndex = 13;
            this.labelPrenomProf.Text = "Prénom";
            // 
            // txtNomProf
            // 
            this.txtNomProf.Location = new System.Drawing.Point(23, 40);
            this.txtNomProf.Name = "txtNomProf";
            this.txtNomProf.Size = new System.Drawing.Size(200, 25);
            this.txtNomProf.TabIndex = 12;
            // 
            // labelNomProf
            // 
            this.labelNomProf.AutoSize = true;
            this.labelNomProf.Location = new System.Drawing.Point(20, 20);
            this.labelNomProf.Name = "labelNomProf";
            this.labelNomProf.Size = new System.Drawing.Size(37, 17);
            this.labelNomProf.TabIndex = 11;
            this.labelNomProf.Text = "Nom";
            // 
            // dgUtilisateurs
            // 
            this.dgUtilisateurs.BackgroundColor = System.Drawing.Color.White;
            this.dgUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateurs.Location = new System.Drawing.Point(460, 40);
            this.dgUtilisateurs.Name = "dgUtilisateurs";
            this.dgUtilisateurs.ReadOnly = true;
            this.dgUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUtilisateurs.Size = new System.Drawing.Size(350, 300);
            this.dgUtilisateurs.TabIndex = 10;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "frmUtilisateur";
            this.ControlBox = false;
            this.tabControl1.ResumeLayout(false);
            this.tabUtilisateurs.ResumeLayout(false);
            this.tabUtilisateurs.PerformLayout();
            this.tabProfesseurs.ResumeLayout(false);
            this.tabProfesseurs.PerformLayout();
            this.tabCandidats.ResumeLayout(false);
            this.tabCandidats.PerformLayout();
            this.tabChefs.ResumeLayout(false);
            this.tabChefs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChefs)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabUtilisateurs;
        private System.Windows.Forms.TabPage tabProfesseurs;
        private System.Windows.Forms.TabPage tabCandidats;
        private System.Windows.Forms.TabPage tabChefs;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.DataGridView dgUtilisateurs;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox txtTel;

        private System.Windows.Forms.DataGridView dgProfesseurs;
        private System.Windows.Forms.Button btnSupprimerProf;
        private System.Windows.Forms.Button btnModifierProf;
        private System.Windows.Forms.Button btnSelectionnerProf;
        private System.Windows.Forms.Button btnAjouterProf;
        private System.Windows.Forms.TextBox txtSpecialiteProf;
        private System.Windows.Forms.Label labelSpecialiteProf;
        private System.Windows.Forms.TextBox txtEmailProf;
        private System.Windows.Forms.Label labelEmailProf;
        private System.Windows.Forms.TextBox txtTelProf;
        private System.Windows.Forms.Label labelTelProf;
        private System.Windows.Forms.TextBox txtPrenomProf;
        private System.Windows.Forms.Label labelPrenomProf;
        private System.Windows.Forms.TextBox txtNomProf;
        private System.Windows.Forms.Label labelNomProf;

        private System.Windows.Forms.DataGridView dgCandidats;
        private System.Windows.Forms.Button btnSupprimerCand;
        private System.Windows.Forms.Button btnModifierCand;
        private System.Windows.Forms.Button btnSelectionnerCand;
        private System.Windows.Forms.Button btnAjouterCand;
        private System.Windows.Forms.TextBox txtMatriculeCand;
        private System.Windows.Forms.Label labelMatriculeCand;
        private System.Windows.Forms.TextBox txtEmailCand;
        private System.Windows.Forms.Label labelEmailCand;
        private System.Windows.Forms.TextBox txtTelCand;
        private System.Windows.Forms.Label labelTelCand;
        private System.Windows.Forms.TextBox txtPrenomCand;
        private System.Windows.Forms.Label labelPrenomCand;
        private System.Windows.Forms.TextBox txtNomCand;
        private System.Windows.Forms.Label labelNomCand;

        private System.Windows.Forms.DataGridView dgChefs;
        private System.Windows.Forms.Button btnSupprimerChef;
        private System.Windows.Forms.Button btnModifierChef;
        private System.Windows.Forms.Button btnSelectionnerChef;
        private System.Windows.Forms.Button btnAjouterChef;
        private System.Windows.Forms.TextBox txtEmailChef;
        private System.Windows.Forms.Label labelEmailChef;
        private System.Windows.Forms.TextBox txtTelChef;
        private System.Windows.Forms.Label labelTelChef;
        private System.Windows.Forms.TextBox txtPrenomChef;
        private System.Windows.Forms.Label labelPrenomChef;
        private System.Windows.Forms.TextBox txtNomChef;
        private System.Windows.Forms.Label labelNomChef;
    }
}