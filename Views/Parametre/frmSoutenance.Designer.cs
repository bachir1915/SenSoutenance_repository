namespace SenSoutenance.Views.Parametre
{
    partial class frmSoutenance
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
            this.cbbMemoire = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservationSoutenance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMentionSoutenance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultatSoutenance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateSoutenance = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLieuSoutenance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBoutons = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgSoutenance = new System.Windows.Forms.DataGridView();
            this.panelTitre.SuspendLayout();
            this.panelSaisie.SuspendLayout();
            this.panelBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).BeginInit();
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
            this.lblTitre.Size = new System.Drawing.Size(378, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🎓 GESTION DES SOUTENANCES";
            // 
            // panelSaisie
            // 
            this.panelSaisie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelSaisie.Controls.Add(this.cbbMemoire);
            this.panelSaisie.Controls.Add(this.label6);
            this.panelSaisie.Controls.Add(this.txtObservationSoutenance);
            this.panelSaisie.Controls.Add(this.label2);
            this.panelSaisie.Controls.Add(this.txtMentionSoutenance);
            this.panelSaisie.Controls.Add(this.label1);
            this.panelSaisie.Controls.Add(this.txtResultatSoutenance);
            this.panelSaisie.Controls.Add(this.label3);
            this.panelSaisie.Controls.Add(this.dtpDateSoutenance);
            this.panelSaisie.Controls.Add(this.label5);
            this.panelSaisie.Controls.Add(this.txtLieuSoutenance);
            this.panelSaisie.Controls.Add(this.label4);
            this.panelSaisie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSaisie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSaisie.Location = new System.Drawing.Point(30, 90);
            this.panelSaisie.Name = "panelSaisie";
            this.panelSaisie.Size = new System.Drawing.Size(932, 140);
            this.panelSaisie.TabIndex = 1;
            this.panelSaisie.TabStop = false;
            this.panelSaisie.Text = "Informations";
            // 
            // cbbMemoire
            // 
            this.cbbMemoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbMemoire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMemoire.FormattingEnabled = true;
            this.cbbMemoire.Location = new System.Drawing.Point(490, 100);
            this.cbbMemoire.Name = "cbbMemoire";
            this.cbbMemoire.Size = new System.Drawing.Size(400, 25);
            this.cbbMemoire.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(490, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mémoire :";
            // 
            // txtObservationSoutenance
            // 
            this.txtObservationSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservationSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservationSoutenance.Location = new System.Drawing.Point(30, 100);
            this.txtObservationSoutenance.Name = "txtObservationSoutenance";
            this.txtObservationSoutenance.Size = new System.Drawing.Size(400, 25);
            this.txtObservationSoutenance.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Observation :";
            // 
            // txtMentionSoutenance
            // 
            this.txtMentionSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMentionSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMentionSoutenance.Location = new System.Drawing.Point(720, 30);
            this.txtMentionSoutenance.Name = "txtMentionSoutenance";
            this.txtMentionSoutenance.Size = new System.Drawing.Size(170, 25);
            this.txtMentionSoutenance.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(720, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mention :";
            // 
            // txtResultatSoutenance
            // 
            this.txtResultatSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultatSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultatSoutenance.Location = new System.Drawing.Point(490, 30);
            this.txtResultatSoutenance.Name = "txtResultatSoutenance";
            this.txtResultatSoutenance.Size = new System.Drawing.Size(170, 25);
            this.txtResultatSoutenance.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(490, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Résultat :";
            // 
            // dtpDateSoutenance
            // 
            this.dtpDateSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateSoutenance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateSoutenance.Location = new System.Drawing.Point(260, 30);
            this.dtpDateSoutenance.Name = "dtpDateSoutenance";
            this.dtpDateSoutenance.Size = new System.Drawing.Size(170, 25);
            this.dtpDateSoutenance.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(260, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date :";
            // 
            // txtLieuSoutenance
            // 
            this.txtLieuSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLieuSoutenance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieuSoutenance.Location = new System.Drawing.Point(30, 30);
            this.txtLieuSoutenance.Name = "txtLieuSoutenance";
            this.txtLieuSoutenance.Size = new System.Drawing.Size(170, 25);
            this.txtLieuSoutenance.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(30, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lieu :";
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
            this.btnSupprimer.TabIndex = 19;
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
            this.btnModifier.TabIndex = 18;
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
            this.btnSelectionner.TabIndex = 16;
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
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "✓ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgSoutenance
            // 
            this.dgSoutenance.AllowUserToAddRows = false;
            this.dgSoutenance.AllowUserToDeleteRows = false;
            this.dgSoutenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSoutenance.BackgroundColor = System.Drawing.Color.White;
            this.dgSoutenance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgSoutenance.ColumnHeadersHeight = 40;
            this.dgSoutenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgSoutenance.Location = new System.Drawing.Point(30, 330);
            this.dgSoutenance.MultiSelect = false;
            this.dgSoutenance.Name = "dgSoutenance";
            this.dgSoutenance.ReadOnly = true;
            this.dgSoutenance.RowHeadersVisible = false;
            this.dgSoutenance.RowTemplate.Height = 35;
            this.dgSoutenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSoutenance.Size = new System.Drawing.Size(932, 243);
            this.dgSoutenance.TabIndex = 20;
            // 
            // frmSoutenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 603);
            this.Controls.Add(this.dgSoutenance);
            this.Controls.Add(this.panelBoutons);
            this.Controls.Add(this.panelSaisie);
            this.Controls.Add(this.panelTitre);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSoutenance";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Text = "Gestion des Soutenances";
            this.Load += new System.EventHandler(this.frmSoutenance_Load);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.panelSaisie.ResumeLayout(false);
            this.panelSaisie.PerformLayout();
            this.panelBoutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSoutenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox panelSaisie;
        private System.Windows.Forms.ComboBox cbbMemoire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservationSoutenance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMentionSoutenance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultatSoutenance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateSoutenance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLieuSoutenance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBoutons;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgSoutenance;
    }
}