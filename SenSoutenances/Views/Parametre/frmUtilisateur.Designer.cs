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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(243, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 25);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
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
            // dgUtilisateurs
            // 
            this.dgUtilisateurs.BackgroundColor = System.Drawing.Color.White;
            this.dgUtilisateurs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateurs.Location = new System.Drawing.Point(460, 40);
            this.dgUtilisateurs.Name = "dgUtilisateurs";
            this.dgUtilisateurs.ReadOnly = true;
            this.dgUtilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUtilisateurs.Size = new System.Drawing.Size(350, 200);
            this.dgUtilisateurs.TabIndex = 10;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(830, 260);
            this.Controls.Add(this.dgUtilisateurs);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "frmUtilisateur";
            this.ControlBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des Utilisateurs Securité";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
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
    }
}