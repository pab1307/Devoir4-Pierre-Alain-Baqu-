﻿namespace habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.btnAnnulPwd = new System.Windows.Forms.Button();
            this.btnEnregPwd = new System.Windows.Forms.Button();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbPwd = new System.Windows.Forms.GroupBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.btnAnnulDev = new System.Windows.Forms.Button();
            this.btnEnregDev = new System.Windows.Forms.Button();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.grbDeveloppeur = new System.Windows.Forms.GroupBox();
            this.btnDemandeChangePwd = new System.Windows.Forms.Button();
            this.btnDemandeSupprDev = new System.Windows.Forms.Button();
            this.btnDemandeModifDev = new System.Windows.Forms.Button();
            this.grbLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.dgvDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.grbPwd.SuspendLayout();
            this.grbDeveloppeur.SuspendLayout();
            this.grbLesDeveloppeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "encore";
            // 
            // btnAnnulPwd
            // 
            this.btnAnnulPwd.Location = new System.Drawing.Point(116, 55);
            this.btnAnnulPwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulPwd.Name = "btnAnnulPwd";
            this.btnAnnulPwd.Size = new System.Drawing.Size(100, 28);
            this.btnAnnulPwd.TabIndex = 4;
            this.btnAnnulPwd.Text = "annuler";
            this.btnAnnulPwd.UseVisualStyleBackColor = true;
            this.btnAnnulPwd.Click += new System.EventHandler(this.BtnAnnulPwd_Click);
            // 
            // btnEnregPwd
            // 
            this.btnEnregPwd.Location = new System.Drawing.Point(8, 55);
            this.btnEnregPwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregPwd.Name = "btnEnregPwd";
            this.btnEnregPwd.Size = new System.Drawing.Size(100, 28);
            this.btnEnregPwd.TabIndex = 3;
            this.btnEnregPwd.Text = "Enregistrer";
            this.btnEnregPwd.UseVisualStyleBackColor = true;
            this.btnEnregPwd.Click += new System.EventHandler(this.BtnEnregPwd_Click);
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(472, 23);
            this.txtPwd2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd2.MaxLength = 50;
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.PasswordChar = '*';
            this.txtPwd2.Size = new System.Drawing.Size(325, 22);
            this.txtPwd2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "pwd";
            // 
            // grbPwd
            // 
            this.grbPwd.Controls.Add(this.label7);
            this.grbPwd.Controls.Add(this.btnAnnulPwd);
            this.grbPwd.Controls.Add(this.btnEnregPwd);
            this.grbPwd.Controls.Add(this.txtPwd2);
            this.grbPwd.Controls.Add(this.txtPwd1);
            this.grbPwd.Controls.Add(this.label6);
            this.grbPwd.Location = new System.Drawing.Point(13, 537);
            this.grbPwd.Margin = new System.Windows.Forms.Padding(4);
            this.grbPwd.Name = "grbPwd";
            this.grbPwd.Padding = new System.Windows.Forms.Padding(4);
            this.grbPwd.Size = new System.Drawing.Size(807, 95);
            this.grbPwd.TabIndex = 6;
            this.grbPwd.TabStop = false;
            this.grbPwd.Text = "changer le mot de passe";
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(72, 23);
            this.txtPwd1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd1.MaxLength = 50;
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.Size = new System.Drawing.Size(325, 22);
            this.txtPwd1.TabIndex = 1;
            // 
            // btnAnnulDev
            // 
            this.btnAnnulDev.Location = new System.Drawing.Point(116, 121);
            this.btnAnnulDev.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulDev.Name = "btnAnnulDev";
            this.btnAnnulDev.Size = new System.Drawing.Size(100, 28);
            this.btnAnnulDev.TabIndex = 10;
            this.btnAnnulDev.Text = "annuler";
            this.btnAnnulDev.UseVisualStyleBackColor = true;
            this.btnAnnulDev.Click += new System.EventHandler(this.BtnAnnulDev_Click);
            // 
            // btnEnregDev
            // 
            this.btnEnregDev.Location = new System.Drawing.Point(8, 121);
            this.btnEnregDev.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregDev.Name = "btnEnregDev";
            this.btnEnregDev.Size = new System.Drawing.Size(100, 28);
            this.btnEnregDev.TabIndex = 9;
            this.btnEnregDev.Text = "enregistrer";
            this.btnEnregDev.UseVisualStyleBackColor = true;
            this.btnEnregDev.Click += new System.EventHandler(this.BtnEnregDev_Click);
            // 
            // cboProfil
            // 
            this.cboProfil.FormattingEnabled = true;
            this.cboProfil.Location = new System.Drawing.Point(472, 87);
            this.cboProfil.Margin = new System.Windows.Forms.Padding(4);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(213, 24);
            this.cboProfil.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "profil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "prenom";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(472, 23);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(325, 22);
            this.txtMail.TabIndex = 6;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(472, 55);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(213, 22);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(72, 55);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(325, 22);
            this.txtPrenom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(72, 23);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.MaxLength = 20;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(325, 22);
            this.txtNom.TabIndex = 3;
            // 
            // grbDeveloppeur
            // 
            this.grbDeveloppeur.Controls.Add(this.btnAnnulDev);
            this.grbDeveloppeur.Controls.Add(this.btnEnregDev);
            this.grbDeveloppeur.Controls.Add(this.cboProfil);
            this.grbDeveloppeur.Controls.Add(this.label5);
            this.grbDeveloppeur.Controls.Add(this.label4);
            this.grbDeveloppeur.Controls.Add(this.label3);
            this.grbDeveloppeur.Controls.Add(this.label2);
            this.grbDeveloppeur.Controls.Add(this.txtMail);
            this.grbDeveloppeur.Controls.Add(this.txtTel);
            this.grbDeveloppeur.Controls.Add(this.txtPrenom);
            this.grbDeveloppeur.Controls.Add(this.label1);
            this.grbDeveloppeur.Controls.Add(this.txtNom);
            this.grbDeveloppeur.Location = new System.Drawing.Point(13, 370);
            this.grbDeveloppeur.Margin = new System.Windows.Forms.Padding(4);
            this.grbDeveloppeur.Name = "grbDeveloppeur";
            this.grbDeveloppeur.Padding = new System.Windows.Forms.Padding(4);
            this.grbDeveloppeur.Size = new System.Drawing.Size(807, 159);
            this.grbDeveloppeur.TabIndex = 5;
            this.grbDeveloppeur.TabStop = false;
            this.grbDeveloppeur.Text = "ajouter un développeur";
            // 
            // btnDemandeChangePwd
            // 
            this.btnDemandeChangePwd.Location = new System.Drawing.Point(225, 311);
            this.btnDemandeChangePwd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemandeChangePwd.Name = "btnDemandeChangePwd";
            this.btnDemandeChangePwd.Size = new System.Drawing.Size(113, 28);
            this.btnDemandeChangePwd.TabIndex = 3;
            this.btnDemandeChangePwd.Text = "changer pwd";
            this.btnDemandeChangePwd.UseVisualStyleBackColor = true;
            this.btnDemandeChangePwd.Click += new System.EventHandler(this.BtnDemandeChangePwd_Click);
            // 
            // btnDemandeSupprDev
            // 
            this.btnDemandeSupprDev.Location = new System.Drawing.Point(117, 311);
            this.btnDemandeSupprDev.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemandeSupprDev.Name = "btnDemandeSupprDev";
            this.btnDemandeSupprDev.Size = new System.Drawing.Size(100, 28);
            this.btnDemandeSupprDev.TabIndex = 2;
            this.btnDemandeSupprDev.Text = "supprimer";
            this.btnDemandeSupprDev.UseVisualStyleBackColor = true;
            this.btnDemandeSupprDev.Click += new System.EventHandler(this.BtnDemandeSupprDev_Click);
            // 
            // btnDemandeModifDev
            // 
            this.btnDemandeModifDev.Location = new System.Drawing.Point(9, 311);
            this.btnDemandeModifDev.Margin = new System.Windows.Forms.Padding(4);
            this.btnDemandeModifDev.Name = "btnDemandeModifDev";
            this.btnDemandeModifDev.Size = new System.Drawing.Size(100, 28);
            this.btnDemandeModifDev.TabIndex = 1;
            this.btnDemandeModifDev.Text = "modifier";
            this.btnDemandeModifDev.UseVisualStyleBackColor = true;
            this.btnDemandeModifDev.Click += new System.EventHandler(this.BtnDemandeModifDev_Click);
            // 
            // grbLesDeveloppeurs
            // 
            this.grbLesDeveloppeurs.Controls.Add(this.comboBoxFilter);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeChangePwd);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeSupprDev);
            this.grbLesDeveloppeurs.Controls.Add(this.btnDemandeModifDev);
            this.grbLesDeveloppeurs.Controls.Add(this.dgvDeveloppeurs);
            this.grbLesDeveloppeurs.Location = new System.Drawing.Point(15, 12);
            this.grbLesDeveloppeurs.Margin = new System.Windows.Forms.Padding(4);
            this.grbLesDeveloppeurs.Name = "grbLesDeveloppeurs";
            this.grbLesDeveloppeurs.Padding = new System.Windows.Forms.Padding(4);
            this.grbLesDeveloppeurs.Size = new System.Drawing.Size(807, 350);
            this.grbLesDeveloppeurs.TabIndex = 4;
            this.grbLesDeveloppeurs.TabStop = false;
            this.grbLesDeveloppeurs.Text = "les développeurs";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(9, 23);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(775, 24);
            this.comboBoxFilter.TabIndex = 4;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.cboProfils_SelectedIndexChanged);
            // 
            // dgvDeveloppeurs
            // 
            this.dgvDeveloppeurs.AllowUserToAddRows = false;
            this.dgvDeveloppeurs.AllowUserToDeleteRows = false;
            this.dgvDeveloppeurs.AllowUserToResizeRows = false;
            this.dgvDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeurs.Location = new System.Drawing.Point(9, 50);
            this.dgvDeveloppeurs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDeveloppeurs.MultiSelect = false;
            this.dgvDeveloppeurs.Name = "dgvDeveloppeurs";
            this.dgvDeveloppeurs.ReadOnly = true;
            this.dgvDeveloppeurs.RowHeadersVisible = false;
            this.dgvDeveloppeurs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDeveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeveloppeurs.Size = new System.Drawing.Size(775, 254);
            this.dgvDeveloppeurs.TabIndex = 0;
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 645);
            this.Controls.Add(this.grbPwd);
            this.Controls.Add(this.grbDeveloppeur);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            this.grbPwd.ResumeLayout(false);
            this.grbPwd.PerformLayout();
            this.grbDeveloppeur.ResumeLayout(false);
            this.grbDeveloppeur.PerformLayout();
            this.grbLesDeveloppeurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAnnulPwd;
        private System.Windows.Forms.Button btnEnregPwd;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbPwd;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Button btnAnnulDev;
        private System.Windows.Forms.Button btnEnregDev;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox grbDeveloppeur;
        private System.Windows.Forms.Button btnDemandeChangePwd;
        private System.Windows.Forms.Button btnDemandeSupprDev;
        private System.Windows.Forms.Button btnDemandeModifDev;
        private System.Windows.Forms.GroupBox grbLesDeveloppeurs;
        private System.Windows.Forms.DataGridView dgvDeveloppeurs;
        private System.Windows.Forms.ComboBox comboBoxFilter;
    }
}

