namespace SenSoutenance.Views.Parametre
{
    partial class frmUtilisateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabUtilisateur = new System.Windows.Forms.TabControl();
            this.tabChefDepartement = new System.Windows.Forms.TabPage();
            this.panelChefGrid = new System.Windows.Forms.Panel();
            this.dgChefDepartement = new System.Windows.Forms.DataGridView();
            this.panelChefForm = new System.Windows.Forms.Panel();
            this.btnSelectionnerChef = new System.Windows.Forms.Button();
            this.btnModifierChef = new System.Windows.Forms.Button();
            this.btnSupprimerChef = new System.Windows.Forms.Button();
            this.btnAjouterChef = new System.Windows.Forms.Button();
            this.txtChefEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtChefTelephone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtChefPrenom = new System.Windows.Forms.TextBox();
            this.txtChefNom = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabProfesseur = new System.Windows.Forms.TabPage();
            this.panelProfGrid = new System.Windows.Forms.Panel();
            this.dgProfesseur = new System.Windows.Forms.DataGridView();
            this.panelProfForm = new System.Windows.Forms.Panel();
            this.btnProfSelectionner = new System.Windows.Forms.Button();
            this.btnProfModifier = new System.Windows.Forms.Button();
            this.btnProfSupprimer = new System.Windows.Forms.Button();
            this.btnProfAjouter = new System.Windows.Forms.Button();
            this.txtProfEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfTelephone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProfSpecialite = new System.Windows.Forms.TextBox();
            this.txtProfPrenom = new System.Windows.Forms.TextBox();
            this.txtProfNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabCandidat = new System.Windows.Forms.TabPage();
            this.panelCandidatGrid = new System.Windows.Forms.Panel();
            this.dgCandidat = new System.Windows.Forms.DataGridView();
            this.panelCandidatForm = new System.Windows.Forms.Panel();
            this.txtMatriculeCandidat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectionnerCandidat = new System.Windows.Forms.Button();
            this.btnModifierCandidat = new System.Windows.Forms.Button();
            this.btnSupprimerCandidat = new System.Windows.Forms.Button();
            this.btnAjouterCandidat = new System.Windows.Forms.Button();
            this.txtEmailCandidat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelephoneCandidat = new System.Windows.Forms.TextBox();
            this.txtPrenomCandidat = new System.Windows.Forms.TextBox();
            this.txtNomCandidat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUtilisateur.SuspendLayout();
            this.tabChefDepartement.SuspendLayout();
            this.panelChefGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChefDepartement)).BeginInit();
            this.panelChefForm.SuspendLayout();
            this.tabProfesseur.SuspendLayout();
            this.panelProfGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).BeginInit();
            this.panelProfForm.SuspendLayout();
            this.tabCandidat.SuspendLayout();
            this.panelCandidatGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).BeginInit();
            this.panelCandidatForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUtilisateur
            // 
            this.tabUtilisateur.Controls.Add(this.tabChefDepartement);
            this.tabUtilisateur.Controls.Add(this.tabProfesseur);
            this.tabUtilisateur.Controls.Add(this.tabCandidat);
            this.tabUtilisateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.tabUtilisateur.Multiline = true;
            this.tabUtilisateur.Name = "tabUtilisateur";
            this.tabUtilisateur.SelectedIndex = 0;
            this.tabUtilisateur.Size = new System.Drawing.Size(776, 450);
            this.tabUtilisateur.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabUtilisateur.TabIndex = 0;
            // 
            // tabChefDepartement
            // 
            this.tabChefDepartement.BackColor = System.Drawing.Color.White;
            this.tabChefDepartement.Controls.Add(this.panelChefGrid);
            this.tabChefDepartement.Controls.Add(this.panelChefForm);
            this.tabChefDepartement.Location = new System.Drawing.Point(4, 22);
            this.tabChefDepartement.Name = "tabChefDepartement";
            this.tabChefDepartement.Padding = new System.Windows.Forms.Padding(3);
            this.tabChefDepartement.Size = new System.Drawing.Size(768, 424);
            this.tabChefDepartement.TabIndex = 0;
            this.tabChefDepartement.Text = "Chef Département";
            this.tabChefDepartement.Click += new System.EventHandler(this.tabChefDepartement_Click);
            // 
            // panelChefGrid
            // 
            this.panelChefGrid.Controls.Add(this.dgChefDepartement);
            this.panelChefGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChefGrid.Location = new System.Drawing.Point(388, 3);
            this.panelChefGrid.Name = "panelChefGrid";
            this.panelChefGrid.Size = new System.Drawing.Size(377, 418);
            this.panelChefGrid.TabIndex = 1;
            // 
            // dgChefDepartement
            // 
            this.dgChefDepartement.AllowUserToAddRows = false;
            this.dgChefDepartement.AllowUserToDeleteRows = false;
            this.dgChefDepartement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChefDepartement.BackgroundColor = System.Drawing.Color.White;
            this.dgChefDepartement.ColumnHeadersHeight = 40;
            this.dgChefDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgChefDepartement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChefDepartement.Location = new System.Drawing.Point(0, 0);
            this.dgChefDepartement.MultiSelect = false;
            this.dgChefDepartement.Name = "dgChefDepartement";
            this.dgChefDepartement.ReadOnly = true;
            this.dgChefDepartement.RowHeadersVisible = false;
            this.dgChefDepartement.RowTemplate.Height = 35;
            this.dgChefDepartement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChefDepartement.Size = new System.Drawing.Size(377, 418);
            this.dgChefDepartement.TabIndex = 48;
            // 
            // panelChefForm
            // 
            this.panelChefForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelChefForm.Controls.Add(this.btnSelectionnerChef);
            this.panelChefForm.Controls.Add(this.btnModifierChef);
            this.panelChefForm.Controls.Add(this.btnSupprimerChef);
            this.panelChefForm.Controls.Add(this.btnAjouterChef);
            this.panelChefForm.Controls.Add(this.txtChefEmail);
            this.panelChefForm.Controls.Add(this.label11);
            this.panelChefForm.Controls.Add(this.txtChefTelephone);
            this.panelChefForm.Controls.Add(this.label12);
            this.panelChefForm.Controls.Add(this.txtChefPrenom);
            this.panelChefForm.Controls.Add(this.txtChefNom);
            this.panelChefForm.Controls.Add(this.label13);
            this.panelChefForm.Controls.Add(this.label15);
            this.panelChefForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChefForm.Location = new System.Drawing.Point(3, 3);
            this.panelChefForm.Name = "panelChefForm";
            this.panelChefForm.Padding = new System.Windows.Forms.Padding(15);
            this.panelChefForm.Size = new System.Drawing.Size(385, 418);
            this.panelChefForm.TabIndex = 0;
            // 
            // btnSelectionnerChef
            // 
            this.btnSelectionnerChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSelectionnerChef.FlatAppearance.BorderSize = 0;
            this.btnSelectionnerChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionnerChef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionnerChef.ForeColor = System.Drawing.Color.White;
            this.btnSelectionnerChef.Location = new System.Drawing.Point(223, 238);
            this.btnSelectionnerChef.Name = "btnSelectionnerChef";
            this.btnSelectionnerChef.Size = new System.Drawing.Size(108, 40);
            this.btnSelectionnerChef.TabIndex = 52;
            this.btnSelectionnerChef.Text = "→ Sélect.";
            this.btnSelectionnerChef.UseVisualStyleBackColor = false;
            this.btnSelectionnerChef.Click += new System.EventHandler(this.btnSelectionnerChef_Click);
            // 
            // btnModifierChef
            // 
            this.btnModifierChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnModifierChef.FlatAppearance.BorderSize = 0;
            this.btnModifierChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierChef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierChef.ForeColor = System.Drawing.Color.White;
            this.btnModifierChef.Location = new System.Drawing.Point(223, 293);
            this.btnModifierChef.Name = "btnModifierChef";
            this.btnModifierChef.Size = new System.Drawing.Size(108, 40);
            this.btnModifierChef.TabIndex = 51;
            this.btnModifierChef.Text = "✎ Modif.";
            this.btnModifierChef.UseVisualStyleBackColor = false;
            this.btnModifierChef.Click += new System.EventHandler(this.btnModifierChef_Click);
            // 
            // btnSupprimerChef
            // 
            this.btnSupprimerChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnSupprimerChef.FlatAppearance.BorderSize = 0;
            this.btnSupprimerChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerChef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerChef.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerChef.Location = new System.Drawing.Point(84, 293);
            this.btnSupprimerChef.Name = "btnSupprimerChef";
            this.btnSupprimerChef.Size = new System.Drawing.Size(108, 40);
            this.btnSupprimerChef.TabIndex = 50;
            this.btnSupprimerChef.Text = "✕ Suppr.";
            this.btnSupprimerChef.UseVisualStyleBackColor = false;
            this.btnSupprimerChef.Click += new System.EventHandler(this.btnSupprimerChef_Click);
            // 
            // btnAjouterChef
            // 
            this.btnAjouterChef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouterChef.FlatAppearance.BorderSize = 0;
            this.btnAjouterChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterChef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterChef.ForeColor = System.Drawing.Color.White;
            this.btnAjouterChef.Location = new System.Drawing.Point(84, 238);
            this.btnAjouterChef.Name = "btnAjouterChef";
            this.btnAjouterChef.Size = new System.Drawing.Size(108, 40);
            this.btnAjouterChef.TabIndex = 49;
            this.btnAjouterChef.Text = "✓ Ajouter";
            this.btnAjouterChef.UseVisualStyleBackColor = false;
            this.btnAjouterChef.Click += new System.EventHandler(this.btnAjouterChef_Click);
            // 
            // txtChefEmail
            // 
            this.txtChefEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChefEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChefEmail.Location = new System.Drawing.Point(30, 195);
            this.txtChefEmail.Name = "txtChefEmail";
            this.txtChefEmail.Size = new System.Drawing.Size(325, 25);
            this.txtChefEmail.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(30, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 46;
            this.label11.Text = "Email :";
            // 
            // txtChefTelephone
            // 
            this.txtChefTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChefTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChefTelephone.Location = new System.Drawing.Point(30, 135);
            this.txtChefTelephone.Name = "txtChefTelephone";
            this.txtChefTelephone.Size = new System.Drawing.Size(325, 25);
            this.txtChefTelephone.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label12.Location = new System.Drawing.Point(30, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 44;
            this.label12.Text = "Téléphone :";
            // 
            // txtChefPrenom
            // 
            this.txtChefPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChefPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChefPrenom.Location = new System.Drawing.Point(30, 75);
            this.txtChefPrenom.Name = "txtChefPrenom";
            this.txtChefPrenom.Size = new System.Drawing.Size(325, 25);
            this.txtChefPrenom.TabIndex = 42;
            this.txtChefPrenom.TextChanged += new System.EventHandler(this.txtChefPrenom_TextChanged);
            // 
            // txtChefNom
            // 
            this.txtChefNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChefNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChefNom.Location = new System.Drawing.Point(30, 25);
            this.txtChefNom.Name = "txtChefNom";
            this.txtChefNom.Size = new System.Drawing.Size(325, 25);
            this.txtChefNom.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label13.Location = new System.Drawing.Point(30, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "Prénom :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label15.Location = new System.Drawing.Point(15, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 19);
            this.label15.TabIndex = 38;
            this.label15.Text = "Nom :";
            // 
            // tabProfesseur
            // 
            this.tabProfesseur.BackColor = System.Drawing.Color.White;
            this.tabProfesseur.Controls.Add(this.panelProfGrid);
            this.tabProfesseur.Controls.Add(this.panelProfForm);
            this.tabProfesseur.Location = new System.Drawing.Point(4, 22);
            this.tabProfesseur.Name = "tabProfesseur";
            this.tabProfesseur.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesseur.Size = new System.Drawing.Size(768, 424);
            this.tabProfesseur.TabIndex = 1;
            this.tabProfesseur.Text = "Professeur";
            // 
            // panelProfGrid
            // 
            this.panelProfGrid.Controls.Add(this.dgProfesseur);
            this.panelProfGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfGrid.Location = new System.Drawing.Point(388, 3);
            this.panelProfGrid.Name = "panelProfGrid";
            this.panelProfGrid.Size = new System.Drawing.Size(377, 418);
            this.panelProfGrid.TabIndex = 1;
            // 
            // dgProfesseur
            // 
            this.dgProfesseur.AllowUserToAddRows = false;
            this.dgProfesseur.AllowUserToDeleteRows = false;
            this.dgProfesseur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProfesseur.BackgroundColor = System.Drawing.Color.White;
            this.dgProfesseur.ColumnHeadersHeight = 40;
            this.dgProfesseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgProfesseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProfesseur.Location = new System.Drawing.Point(0, 0);
            this.dgProfesseur.MultiSelect = false;
            this.dgProfesseur.Name = "dgProfesseur";
            this.dgProfesseur.ReadOnly = true;
            this.dgProfesseur.RowHeadersVisible = false;
            this.dgProfesseur.RowTemplate.Height = 35;
            this.dgProfesseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfesseur.Size = new System.Drawing.Size(377, 418);
            this.dgProfesseur.TabIndex = 24;
            // 
            // panelProfForm
            // 
            this.panelProfForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelProfForm.Controls.Add(this.btnProfSelectionner);
            this.panelProfForm.Controls.Add(this.btnProfModifier);
            this.panelProfForm.Controls.Add(this.btnProfSupprimer);
            this.panelProfForm.Controls.Add(this.btnProfAjouter);
            this.panelProfForm.Controls.Add(this.txtProfEmail);
            this.panelProfForm.Controls.Add(this.label6);
            this.panelProfForm.Controls.Add(this.txtProfTelephone);
            this.panelProfForm.Controls.Add(this.label7);
            this.panelProfForm.Controls.Add(this.txtProfSpecialite);
            this.panelProfForm.Controls.Add(this.txtProfPrenom);
            this.panelProfForm.Controls.Add(this.txtProfNom);
            this.panelProfForm.Controls.Add(this.label8);
            this.panelProfForm.Controls.Add(this.label9);
            this.panelProfForm.Controls.Add(this.label10);
            this.panelProfForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelProfForm.Location = new System.Drawing.Point(3, 3);
            this.panelProfForm.Name = "panelProfForm";
            this.panelProfForm.Padding = new System.Windows.Forms.Padding(15);
            this.panelProfForm.Size = new System.Drawing.Size(385, 418);
            this.panelProfForm.TabIndex = 0;
            // 
            // btnProfSelectionner
            // 
            this.btnProfSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnProfSelectionner.FlatAppearance.BorderSize = 0;
            this.btnProfSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfSelectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnProfSelectionner.Location = new System.Drawing.Point(257, 303);
            this.btnProfSelectionner.Name = "btnProfSelectionner";
            this.btnProfSelectionner.Size = new System.Drawing.Size(98, 40);
            this.btnProfSelectionner.TabIndex = 37;
            this.btnProfSelectionner.Text = "→ Sélect.";
            this.btnProfSelectionner.UseVisualStyleBackColor = false;
            this.btnProfSelectionner.Click += new System.EventHandler(this.btnSelectionnerProfesseur_Click);
            // 
            // btnProfModifier
            // 
            this.btnProfModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnProfModifier.FlatAppearance.BorderSize = 0;
            this.btnProfModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfModifier.ForeColor = System.Drawing.Color.White;
            this.btnProfModifier.Location = new System.Drawing.Point(129, 360);
            this.btnProfModifier.Name = "btnProfModifier";
            this.btnProfModifier.Size = new System.Drawing.Size(98, 40);
            this.btnProfModifier.TabIndex = 36;
            this.btnProfModifier.Text = "✎ Modif.";
            this.btnProfModifier.UseVisualStyleBackColor = false;
            this.btnProfModifier.Click += new System.EventHandler(this.btnModifierProfesseur_Click);
            // 
            // btnProfSupprimer
            // 
            this.btnProfSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnProfSupprimer.FlatAppearance.BorderSize = 0;
            this.btnProfSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnProfSupprimer.Location = new System.Drawing.Point(257, 360);
            this.btnProfSupprimer.Name = "btnProfSupprimer";
            this.btnProfSupprimer.Size = new System.Drawing.Size(98, 40);
            this.btnProfSupprimer.TabIndex = 35;
            this.btnProfSupprimer.Text = "✕ Suppr.";
            this.btnProfSupprimer.UseVisualStyleBackColor = false;
            this.btnProfSupprimer.Click += new System.EventHandler(this.btnSupprimerProfesseur_Click);
            // 
            // btnProfAjouter
            // 
            this.btnProfAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnProfAjouter.FlatAppearance.BorderSize = 0;
            this.btnProfAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfAjouter.ForeColor = System.Drawing.Color.White;
            this.btnProfAjouter.Location = new System.Drawing.Point(129, 303);
            this.btnProfAjouter.Name = "btnProfAjouter";
            this.btnProfAjouter.Size = new System.Drawing.Size(98, 40);
            this.btnProfAjouter.TabIndex = 34;
            this.btnProfAjouter.Text = "✓ Ajouter";
            this.btnProfAjouter.UseVisualStyleBackColor = false;
            this.btnProfAjouter.Click += new System.EventHandler(this.btnAjouterProfesseur_Click);
            // 
            // txtProfEmail
            // 
            this.txtProfEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfEmail.Location = new System.Drawing.Point(30, 252);
            this.txtProfEmail.Name = "txtProfEmail";
            this.txtProfEmail.Size = new System.Drawing.Size(325, 25);
            this.txtProfEmail.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(30, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email :";
            // 
            // txtProfTelephone
            // 
            this.txtProfTelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfTelephone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfTelephone.Location = new System.Drawing.Point(30, 202);
            this.txtProfTelephone.Name = "txtProfTelephone";
            this.txtProfTelephone.Size = new System.Drawing.Size(325, 25);
            this.txtProfTelephone.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(30, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Téléphone :";
            // 
            // txtProfSpecialite
            // 
            this.txtProfSpecialite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfSpecialite.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfSpecialite.Location = new System.Drawing.Point(30, 143);
            this.txtProfSpecialite.Name = "txtProfSpecialite";
            this.txtProfSpecialite.Size = new System.Drawing.Size(325, 25);
            this.txtProfSpecialite.TabIndex = 19;
            // 
            // txtProfPrenom
            // 
            this.txtProfPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfPrenom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfPrenom.Location = new System.Drawing.Point(30, 75);
            this.txtProfPrenom.Name = "txtProfPrenom";
            this.txtProfPrenom.Size = new System.Drawing.Size(325, 25);
            this.txtProfPrenom.TabIndex = 18;
            // 
            // txtProfNom
            // 
            this.txtProfNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfNom.Location = new System.Drawing.Point(30, 20);
            this.txtProfNom.Name = "txtProfNom";
            this.txtProfNom.Size = new System.Drawing.Size(325, 25);
            this.txtProfNom.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(30, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Prénom :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(30, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Spécialité :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(30, -3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nom :";
            // 
            // tabCandidat
            // 
            this.tabCandidat.BackColor = System.Drawing.Color.White;
            this.tabCandidat.Controls.Add(this.panelCandidatGrid);
            this.tabCandidat.Controls.Add(this.panelCandidatForm);
            this.tabCandidat.Location = new System.Drawing.Point(4, 22);
            this.tabCandidat.Name = "tabCandidat";
            this.tabCandidat.Padding = new System.Windows.Forms.Padding(3);
            this.tabCandidat.Size = new System.Drawing.Size(768, 424);
            this.tabCandidat.TabIndex = 2;
            this.tabCandidat.Text = "Candidat";
            this.tabCandidat.UseVisualStyleBackColor = true;
            // 
            // panelCandidatGrid
            // 
            this.panelCandidatGrid.Controls.Add(this.dgCandidat);
            this.panelCandidatGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCandidatGrid.Location = new System.Drawing.Point(388, 3);
            this.panelCandidatGrid.Name = "panelCandidatGrid";
            this.panelCandidatGrid.Size = new System.Drawing.Size(377, 418);
            this.panelCandidatGrid.TabIndex = 1;
            // 
            // dgCandidat
            // 
            this.dgCandidat.AllowUserToAddRows = false;
            this.dgCandidat.AllowUserToDeleteRows = false;
            this.dgCandidat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCandidat.BackgroundColor = System.Drawing.Color.White;
            this.dgCandidat.ColumnHeadersHeight = 40;
            this.dgCandidat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCandidat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCandidat.Location = new System.Drawing.Point(0, 0);
            this.dgCandidat.MultiSelect = false;
            this.dgCandidat.Name = "dgCandidat";
            this.dgCandidat.ReadOnly = true;
            this.dgCandidat.RowHeadersVisible = false;
            this.dgCandidat.RowTemplate.Height = 35;
            this.dgCandidat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCandidat.Size = new System.Drawing.Size(377, 418);
            this.dgCandidat.TabIndex = 0;
            this.dgCandidat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCandidat_CellContentClick);
            // 
            // panelCandidatForm
            // 
            this.panelCandidatForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelCandidatForm.Controls.Add(this.txtMatriculeCandidat);
            this.panelCandidatForm.Controls.Add(this.label5);
            this.panelCandidatForm.Controls.Add(this.btnSelectionnerCandidat);
            this.panelCandidatForm.Controls.Add(this.btnModifierCandidat);
            this.panelCandidatForm.Controls.Add(this.btnSupprimerCandidat);
            this.panelCandidatForm.Controls.Add(this.btnAjouterCandidat);
            this.panelCandidatForm.Controls.Add(this.txtEmailCandidat);
            this.panelCandidatForm.Controls.Add(this.label4);
            this.panelCandidatForm.Controls.Add(this.txtTelephoneCandidat);
            this.panelCandidatForm.Controls.Add(this.txtPrenomCandidat);
            this.panelCandidatForm.Controls.Add(this.txtNomCandidat);
            this.panelCandidatForm.Controls.Add(this.label3);
            this.panelCandidatForm.Controls.Add(this.label2);
            this.panelCandidatForm.Controls.Add(this.label1);
            this.panelCandidatForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCandidatForm.Location = new System.Drawing.Point(3, 3);
            this.panelCandidatForm.Name = "panelCandidatForm";
            this.panelCandidatForm.Padding = new System.Windows.Forms.Padding(15);
            this.panelCandidatForm.Size = new System.Drawing.Size(385, 418);
            this.panelCandidatForm.TabIndex = 0;
            // 
            // txtMatriculeCandidat
            // 
            this.txtMatriculeCandidat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatriculeCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculeCandidat.Location = new System.Drawing.Point(30, 240);
            this.txtMatriculeCandidat.Name = "txtMatriculeCandidat";
            this.txtMatriculeCandidat.Size = new System.Drawing.Size(325, 25);
            this.txtMatriculeCandidat.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(30, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Matricule :";
            // 
            // btnSelectionnerCandidat
            // 
            this.btnSelectionnerCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSelectionnerCandidat.FlatAppearance.BorderSize = 0;
            this.btnSelectionnerCandidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionnerCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionnerCandidat.ForeColor = System.Drawing.Color.White;
            this.btnSelectionnerCandidat.Location = new System.Drawing.Point(266, 293);
            this.btnSelectionnerCandidat.Name = "btnSelectionnerCandidat";
            this.btnSelectionnerCandidat.Size = new System.Drawing.Size(89, 40);
            this.btnSelectionnerCandidat.TabIndex = 33;
            this.btnSelectionnerCandidat.Text = "→ Sélect.";
            this.btnSelectionnerCandidat.UseVisualStyleBackColor = false;
            this.btnSelectionnerCandidat.Click += new System.EventHandler(this.btnSelectionnerCandidat_Click);
            // 
            // btnModifierCandidat
            // 
            this.btnModifierCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnModifierCandidat.FlatAppearance.BorderSize = 0;
            this.btnModifierCandidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierCandidat.ForeColor = System.Drawing.Color.White;
            this.btnModifierCandidat.Location = new System.Drawing.Point(266, 349);
            this.btnModifierCandidat.Name = "btnModifierCandidat";
            this.btnModifierCandidat.Size = new System.Drawing.Size(89, 40);
            this.btnModifierCandidat.TabIndex = 32;
            this.btnModifierCandidat.Text = "✎ Modif.";
            this.btnModifierCandidat.UseVisualStyleBackColor = false;
            this.btnModifierCandidat.Click += new System.EventHandler(this.btnModifierCandidat_Click);
            // 
            // btnSupprimerCandidat
            // 
            this.btnSupprimerCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnSupprimerCandidat.FlatAppearance.BorderSize = 0;
            this.btnSupprimerCandidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerCandidat.ForeColor = System.Drawing.Color.White;
            this.btnSupprimerCandidat.Location = new System.Drawing.Point(161, 349);
            this.btnSupprimerCandidat.Name = "btnSupprimerCandidat";
            this.btnSupprimerCandidat.Size = new System.Drawing.Size(89, 40);
            this.btnSupprimerCandidat.TabIndex = 31;
            this.btnSupprimerCandidat.Text = "✕ Suppr.";
            this.btnSupprimerCandidat.UseVisualStyleBackColor = false;
            this.btnSupprimerCandidat.Click += new System.EventHandler(this.btnSupprimerCandidat_Click);
            // 
            // btnAjouterCandidat
            // 
            this.btnAjouterCandidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouterCandidat.FlatAppearance.BorderSize = 0;
            this.btnAjouterCandidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterCandidat.ForeColor = System.Drawing.Color.White;
            this.btnAjouterCandidat.Location = new System.Drawing.Point(161, 293);
            this.btnAjouterCandidat.Name = "btnAjouterCandidat";
            this.btnAjouterCandidat.Size = new System.Drawing.Size(89, 40);
            this.btnAjouterCandidat.TabIndex = 30;
            this.btnAjouterCandidat.Text = "✓ Ajouter";
            this.btnAjouterCandidat.UseVisualStyleBackColor = false;
            this.btnAjouterCandidat.Click += new System.EventHandler(this.btnAjouterCandidat_Click);
            // 
            // txtEmailCandidat
            // 
            this.txtEmailCandidat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCandidat.Location = new System.Drawing.Point(30, 180);
            this.txtEmailCandidat.Name = "txtEmailCandidat";
            this.txtEmailCandidat.Size = new System.Drawing.Size(325, 25);
            this.txtEmailCandidat.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email :";
            // 
            // txtTelephoneCandidat
            // 
            this.txtTelephoneCandidat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelephoneCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephoneCandidat.Location = new System.Drawing.Point(30, 127);
            this.txtTelephoneCandidat.Name = "txtTelephoneCandidat";
            this.txtTelephoneCandidat.Size = new System.Drawing.Size(325, 25);
            this.txtTelephoneCandidat.TabIndex = 27;
            // 
            // txtPrenomCandidat
            // 
            this.txtPrenomCandidat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenomCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomCandidat.Location = new System.Drawing.Point(30, 77);
            this.txtPrenomCandidat.Name = "txtPrenomCandidat";
            this.txtPrenomCandidat.Size = new System.Drawing.Size(325, 25);
            this.txtPrenomCandidat.TabIndex = 26;
            // 
            // txtNomCandidat
            // 
            this.txtNomCandidat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomCandidat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCandidat.Location = new System.Drawing.Point(30, 27);
            this.txtNomCandidat.Name = "txtNomCandidat";
            this.txtNomCandidat.Size = new System.Drawing.Size(325, 25);
            this.txtNomCandidat.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(30, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Téléphone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nom :";
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.tabUtilisateur);
            this.Name = "frmUtilisateur";
            this.Text = "Gestion des Utilisateurs";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            this.tabUtilisateur.ResumeLayout(false);
            this.tabChefDepartement.ResumeLayout(false);
            this.panelChefGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChefDepartement)).EndInit();
            this.panelChefForm.ResumeLayout(false);
            this.panelChefForm.PerformLayout();
            this.tabProfesseur.ResumeLayout(false);
            this.panelProfGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesseur)).EndInit();
            this.panelProfForm.ResumeLayout(false);
            this.panelProfForm.PerformLayout();
            this.tabCandidat.ResumeLayout(false);
            this.panelCandidatGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCandidat)).EndInit();
            this.panelCandidatForm.ResumeLayout(false);
            this.panelCandidatForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUtilisateur;
        private System.Windows.Forms.TabPage tabChefDepartement;
        private System.Windows.Forms.TabPage tabProfesseur;
        private System.Windows.Forms.TabPage tabCandidat;
        private System.Windows.Forms.Panel panelCandidatGrid;
        private System.Windows.Forms.Panel panelCandidatForm;
        private System.Windows.Forms.TextBox txtEmailCandidat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelephoneCandidat;
        private System.Windows.Forms.TextBox txtPrenomCandidat;
        private System.Windows.Forms.TextBox txtNomCandidat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCandidat;
        private System.Windows.Forms.Button btnSelectionnerCandidat;
        private System.Windows.Forms.Button btnModifierCandidat;
        private System.Windows.Forms.Button btnSupprimerCandidat;
        private System.Windows.Forms.Button btnAjouterCandidat;
        private System.Windows.Forms.TextBox txtMatriculeCandidat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProfSpecialite;
        private System.Windows.Forms.TextBox txtProfPrenom;
        private System.Windows.Forms.TextBox txtProfNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgProfesseur;
        private System.Windows.Forms.Button btnProfSelectionner;
        private System.Windows.Forms.Button btnProfModifier;
        private System.Windows.Forms.Button btnProfSupprimer;
        private System.Windows.Forms.Button btnProfAjouter;
        private System.Windows.Forms.Button btnSelectionnerChef;
        private System.Windows.Forms.Button btnModifierChef;
        private System.Windows.Forms.Button btnSupprimerChef;
        private System.Windows.Forms.Button btnAjouterChef;
        private System.Windows.Forms.DataGridView dgChefDepartement;
        private System.Windows.Forms.TextBox txtChefEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtChefTelephone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtChefPrenom;
        private System.Windows.Forms.TextBox txtChefNom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelProfGrid;
        private System.Windows.Forms.Panel panelProfForm;
        private System.Windows.Forms.Panel panelChefGrid;
        private System.Windows.Forms.Panel panelChefForm;
    }
}