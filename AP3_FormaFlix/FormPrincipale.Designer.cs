﻿namespace AP3_FormaFlix
{
    partial class FormPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesFormationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToutesLesFormationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneFormationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommentairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCommentairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.gestionDesFormationsToolStripMenuItem,
            this.gestionDesCommentairesToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.reconnecterToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.connexionToolStripMenuItem.Text = "Gestion des utilisateurs";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.DeconnexionToolStripMenuItem_Click);
            // 
            // reconnecterToolStripMenuItem
            // 
            this.reconnecterToolStripMenuItem.Name = "reconnecterToolStripMenuItem";
            this.reconnecterToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.reconnecterToolStripMenuItem.Text = "Reconnecter";
            this.reconnecterToolStripMenuItem.Click += new System.EventHandler(this.ReconnecterToolStripMenuItem_Click);
            // 
            // gestionDesFormationsToolStripMenuItem
            // 
            this.gestionDesFormationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listerToutesLesFormationsToolStripMenuItem,
            this.ajouterUneFormationToolStripMenuItem,
            this.modifierUneFormationToolStripMenuItem,
            this.supprimerUneFormationToolStripMenuItem});
            this.gestionDesFormationsToolStripMenuItem.Name = "gestionDesFormationsToolStripMenuItem";
            this.gestionDesFormationsToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.gestionDesFormationsToolStripMenuItem.Text = "Gestion des Formations";
            // 
            // listerToutesLesFormationsToolStripMenuItem
            // 
            this.listerToutesLesFormationsToolStripMenuItem.Name = "listerToutesLesFormationsToolStripMenuItem";
            this.listerToutesLesFormationsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.listerToutesLesFormationsToolStripMenuItem.Text = "Lister toutes les formations";
            this.listerToutesLesFormationsToolStripMenuItem.Click += new System.EventHandler(this.ListerToutesLesFormationsToolStripMenuItem_Click);
            // 
            // ajouterUneFormationToolStripMenuItem
            // 
            this.ajouterUneFormationToolStripMenuItem.Name = "ajouterUneFormationToolStripMenuItem";
            this.ajouterUneFormationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ajouterUneFormationToolStripMenuItem.Text = "Ajouter une formation";
            this.ajouterUneFormationToolStripMenuItem.Click += new System.EventHandler(this.AjouterUneFormationToolStripMenuItem_Click);
            // 
            // modifierUneFormationToolStripMenuItem
            // 
            this.modifierUneFormationToolStripMenuItem.Name = "modifierUneFormationToolStripMenuItem";
            this.modifierUneFormationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.modifierUneFormationToolStripMenuItem.Text = "Modifier une formation";
            this.modifierUneFormationToolStripMenuItem.Click += new System.EventHandler(this.modifierUneFormationToolStripMenuItem_Click);
            // 
            // supprimerUneFormationToolStripMenuItem
            // 
            this.supprimerUneFormationToolStripMenuItem.Name = "supprimerUneFormationToolStripMenuItem";
            this.supprimerUneFormationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.supprimerUneFormationToolStripMenuItem.Text = "Supprimer une formation";
            this.supprimerUneFormationToolStripMenuItem.Click += new System.EventHandler(this.SupprimerUneFormationToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // gestionDesCommentairesToolStripMenuItem
            // 
            this.gestionDesCommentairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCommentairesToolStripMenuItem});
            this.gestionDesCommentairesToolStripMenuItem.Name = "gestionDesCommentairesToolStripMenuItem";
            this.gestionDesCommentairesToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.gestionDesCommentairesToolStripMenuItem.Text = "Gestion des commentaires";
            // 
            // listeDesCommentairesToolStripMenuItem
            // 
            this.listeDesCommentairesToolStripMenuItem.Name = "listeDesCommentairesToolStripMenuItem";
            this.listeDesCommentairesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.listeDesCommentairesToolStripMenuItem.Text = "Liste des commentaires";
            this.listeDesCommentairesToolStripMenuItem.Click += new System.EventHandler(this.ListeDesCommentairesToolStripMenuItem_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 485);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMA\'FLIX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipale_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesFormationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToutesLesFormationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneFormationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommentairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCommentairesToolStripMenuItem;
    }
}

