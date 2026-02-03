namespace SenSoutenance.Views.Parametre
{
    partial class frmDepartement
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
            this.txtLibelleDepartement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBoutons = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgDepartement = new System.Windows.Forms.DataGridView();
            this.panelTitre.SuspendLayout();
            this.panelSaisie.SuspendLayout();
            this.panelBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).BeginInit();
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
            this.lblTitre.Size = new System.Drawing.Size(377, 30);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "🏢 GESTION DES DÉPARTEMENTS";
            // 
            // panelSaisie
            // 
            this.panelSaisie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelSaisie.Controls.Add(this.txtLibelleDepartement);
            this.panelSaisie.Controls.Add(this.label2);
            this.panelSaisie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSaisie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSaisie.Location = new System.Drawing.Point(30, 90);
            this.panelSaisie.Name = "panelSaisie";
            this.panelSaisie.Size = new System.Drawing.Size(932, 100);
            this.panelSaisie.TabIndex = 1;
            this.panelSaisie.TabStop = false;
            this.panelSaisie.Text = "Informations";
            // 
            // txtLibelleDepartement
            // 
            this.txtLibelleDepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibelleDepartement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelleDepartement.Location = new System.Drawing.Point(30, 55);
            this.txtLibelleDepartement.Name = "txtLibelleDepartement";
            this.txtLibelleDepartement.Size = new System.Drawing.Size(400, 25);
            this.txtLibelleDepartement.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libellé du Département :";
            // 
            // panelBoutons
            // 
            this.panelBoutons.BackColor = System.Drawing.Color.White;
            this.panelBoutons.Controls.Add(this.btnSupprimer);
            this.panelBoutons.Controls.Add(this.btnModifier);
            this.panelBoutons.Controls.Add(this.btnSelectionner);
            this.panelBoutons.Controls.Add(this.btnAjouter);
            this.panelBoutons.Location = new System.Drawing.Point(30, 210);
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
            this.btnSupprimer.TabIndex = 10;
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
            this.btnModifier.TabIndex = 9;
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
            this.btnSelectionner.TabIndex = 7;
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
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "✓ Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgDepartement
            // 
            this.dgDepartement.AllowUserToAddRows = false;
            this.dgDepartement.AllowUserToDeleteRows = false;
            this.dgDepartement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDepartement.BackgroundColor = System.Drawing.Color.White;
            this.dgDepartement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgDepartement.ColumnHeadersHeight = 40;
            this.dgDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDepartement.Location = new System.Drawing.Point(30, 290);
            this.dgDepartement.MultiSelect = false;
            this.dgDepartement.Name = "dgDepartement";
            this.dgDepartement.ReadOnly = true;
            this.dgDepartement.RowHeadersVisible = false;
            this.dgDepartement.RowTemplate.Height = 35;
            this.dgDepartement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDepartement.Size = new System.Drawing.Size(932, 283);
            this.dgDepartement.TabIndex = 11;
            // 
            // frmDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 603);
            this.Controls.Add(this.dgDepartement);
            this.Controls.Add(this.panelBoutons);
            this.Controls.Add(this.panelSaisie);
            this.Controls.Add(this.panelTitre);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDepartement";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.Text = "Gestion des Départements";
            this.Load += new System.EventHandler(this.frmDepartement_Load);
            this.panelTitre.ResumeLayout(false);
            this.panelTitre.PerformLayout();
            this.panelSaisie.ResumeLayout(false);
            this.panelSaisie.PerformLayout();
            this.panelBoutons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.GroupBox panelSaisie;
        private System.Windows.Forms.TextBox txtLibelleDepartement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBoutons;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgDepartement;
    }
}