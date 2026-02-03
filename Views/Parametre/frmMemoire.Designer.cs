namespace SenSoutenance.Views.Parametre
{
    partial class frmMemoire
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
            this.panelTitre = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.panelSaisie = new System.Windows.Forms.GroupBox();
            this.cbbSession = new System.Windows.Forms.ComboBox();
            this.labelSession = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.labelAnnee = new System.Windows.Forms.Label();
            this.txtSujetMemoire = new System.Windows.Forms.TextBox();
            this.labelSujet = new System.Windows.Forms.Label();
            this.panelBoutons = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgMemoire = new System.Windows.Forms.DataGridView();
            this.panelTitre.SuspendLayout();
            this.panelSaisie.SuspendLayout();
            this.panelBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitre
            // 
            this.panelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelTitre.Controls.Add(this.lblTitre);
            this.panelTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitre.Location = new System.Drawing.Point(0, 0);
            this.panelTitre.Name = "panelTitre";
            this.panelTitre.Size = new System.Drawing.Size(992, 70);
            this.panelTitre.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.White;
            this.lblTitre.Location = new System.Drawing.Point(20, 20);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(334, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "📘 GESTION DES MÉMOIRES";
            // 
            // panelSaisie
            // 
            this.panelSaisie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelSaisie.Controls.Add(this.cbbSession);
            this.panelSaisie.Controls.Add(this.labelSession);
            this.panelSaisie.Controls.Add(this.cbbAnneeAcademique);
            this.panelSaisie.Controls.Add(this.labelAnnee);
            this.panelSaisie.Controls.Add(this.txtSujetMemoire);
            this.panelSaisie.Controls.Add(this.labelSujet);
            this.panelSaisie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSaisie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSaisie.Location = new System.Drawing.Point(30, 90);
            this.panelSaisie.Name = "panelSaisie";
            this.panelSaisie.Size = new System.Drawing.Size(932, 140);
            this.panelSaisie.TabIndex = 1;
            this.panelSaisie.TabStop = false;
            this.panelSaisie.Text = "Informations";
            // 
            // cbbSession
            // 
            this.cbbSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSession.FormattingEnabled = true;
            this.cbbSession.Location = new System.Drawing.Point(490, 80);
            this.cbbSession.Name = "cbbSession";
            this.cbbSession.Size = new System.Drawing.Size(400, 25);
            this.cbbSession.TabIndex = 8;
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelSession.Location = new System.Drawing.Point(490, 55);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(63, 19);
            this.labelSession.TabIndex = 9;
            this.labelSession.Text = "Session :";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAnneeAcademique.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(30, 80);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(400, 25);
            this.cbbAnneeAcademique.TabIndex = 0;
            // 
            // labelAnnee
            // 
            this.labelAnnee.AutoSize = true;
            this.labelAnnee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelAnnee.Location = new System.Drawing.Point(30, 55);
            this.labelAnnee.Name = "labelAnnee";
            this.labelAnnee.Size = new System.Drawing.Size(139, 19);
            this.labelAnnee.TabIndex = 7;
            this.labelAnnee.Text = "Année Académique :";
            // 
            // txtSujetMemoire
            // 
            this.txtSujetMemoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSujetMemoire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSujetMemoire.Location = new System.Drawing.Point(30, 30);
            this.txtSujetMemoire.Name = "txtSujetMemoire";
            this.txtSujetMemoire.Size = new System.Drawing.Size(860, 25);
            this.txtSujetMemoire.TabIndex = 6;
            // 
            // labelSujet
            // 
            this.labelSujet.AutoSize = true;
            this.labelSujet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSujet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelSujet.Location = new System.Drawing.Point(30, 5);
            this.labelSujet.Name = "labelSujet";
            this.labelSujet.Size = new System.Drawing.Size(136, 19);
            this.labelSujet.TabIndex = 5;
            this.labelSujet.Text = "Sujet du Mémoire :";
            // 
            // panelBoutons
            // 
            this.panelBoutons.BackColor = System.Drawing.Color.White;
            this.panelBoutons.Controls.Add(this.btnSupprimer);
            this.panelBoutons.Controls.Add(this.btnModifier);
            this.panelBoutons.Controls.Add(this.btnSelectionner);
            this.panelBoutons.Controls.Add(this.btnAjouter);
            this.panelBoutons.Location = new System.Drawing.Point(30, 250);
            this.panelBoutons.Name = "panelBoutons";
            this.panelBoutons.Size = new System.Drawing.Size(932, 60);
            this.panelBoutons.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnSupprimer.FlatAppearance.BorderSize = 0;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(480, 10);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(140, 40);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "✕ Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(320, 10);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(140, 40);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "✎ Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSelectionner.FlatAppearance.BorderSize = 0;
            this.btnSelectionner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionner.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionner.ForeColor = System.Drawing.Color.White;
            this.btnSelectionner.Location = new System.Drawing.Point(160, 10);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(140, 40);
            this.btnSelectionner.TabIndex = 11;
            this.btnSelectionner.Text = "→ Sélectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(0, 10);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(140, 40);
            this.btnAjouter.TabIndex = 12;
            this.btnAjouter.Text = "✓ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgMemoire
            // 
            this.dgMemoire.AllowUserToAddRows = false;
            this.dgMemoire.AllowUserToDeleteRows = false;
            this.dgMemoire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMemoire.BackgroundColor = System.Drawing.Color.White;
            this.dgMemoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgMemoire.ColumnHeadersHeight = 40;
            this.dgMemoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgMemoire.Location = new System.Drawing.Point(30, 330);
            this.dgMemoire.MultiSelect = false;
            this.dgMemoire.Name = "dgMemoire";
            this.dgMemoire.ReadOnly = true;
            this.dgMemoire.RowHeadersVisible = false;
            this.dgMemoire.RowTemplate.Height = 35;
            this.dgMemoire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMemoire.Size = new System.Drawing.Size(932, 243);
            this.dgMemoire.TabIndex = 15;
            // 
            // frmMemoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 603);
            this.Controls.Add(this.dgMemoire);
            this.Controls.Add(this.panelBoutons);
            this.Controls.Add(this.panelSaisie);
            this.Controls.Add(this.panelTitre);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMemoire";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Text = "Gestion des Mémoires";
            this.Load += new System.EventHandler(this.frmMemoire_Load);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.panelSaisie.ResumeLayout(false);
            this.panelSaisie.PerformLayout();
            this.panelBoutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMemoire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox panelSaisie;
        private System.Windows.Forms.ComboBox cbbSession;
        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Label labelAnnee;
        private System.Windows.Forms.TextBox txtSujetMemoire;
        private System.Windows.Forms.Label labelSujet;
        private System.Windows.Forms.Panel panelBoutons;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgMemoire;
    }
}