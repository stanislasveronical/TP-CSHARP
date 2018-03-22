namespace Fiche2
{
    partial class Form1
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
            this.rt_texte = new System.Windows.Forms.RichTextBox();
            this.mn_principal = new System.Windows.Forms.MenuStrip();
            this.m_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.edition = new System.Windows.Forms.ToolStripMenuItem();
            this.annuler = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copier = new System.Windows.Forms.ToolStripMenuItem();
            this.couper = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.sd_enregistrerSous = new System.Windows.Forms.SaveFileDialog();
            this.sd_enregistrer = new System.Windows.Forms.SaveFileDialog();
            this.mn_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_texte
            // 
            this.rt_texte.Location = new System.Drawing.Point(12, 27);
            this.rt_texte.Name = "rt_texte";
            this.rt_texte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rt_texte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_texte.Size = new System.Drawing.Size(260, 223);
            this.rt_texte.TabIndex = 0;
            this.rt_texte.Text = "";
            this.rt_texte.TextChanged += new System.EventHandler(this.rt_texte_TextChanged);
            // 
            // mn_principal
            // 
            this.mn_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fichier,
            this.edition});
            this.mn_principal.Location = new System.Drawing.Point(0, 0);
            this.mn_principal.Name = "mn_principal";
            this.mn_principal.Size = new System.Drawing.Size(284, 24);
            this.mn_principal.TabIndex = 1;
            this.mn_principal.Text = "menuStrip1";
            // 
            // m_fichier
            // 
            this.m_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ouvrir,
            this.mi_enregistrerSous,
            this.toolStripSeparator2,
            this.mi_quitter,
            this.toolStripSeparator1,
            this.nouveau,
            this.enregistrer});
            this.m_fichier.Name = "m_fichier";
            this.m_fichier.Size = new System.Drawing.Size(54, 20);
            this.m_fichier.Text = "Fichier";
            // 
            // mi_ouvrir
            // 
            this.mi_ouvrir.Name = "mi_ouvrir";
            this.mi_ouvrir.Size = new System.Drawing.Size(170, 22);
            this.mi_ouvrir.Text = "Ouvrir";
            this.mi_ouvrir.Click += new System.EventHandler(this.mi_ouvrir_Click);
            // 
            // mi_enregistrerSous
            // 
            this.mi_enregistrerSous.Name = "mi_enregistrerSous";
            this.mi_enregistrerSous.Size = new System.Drawing.Size(170, 22);
            this.mi_enregistrerSous.Text = "Enregistrer sous ...";
            this.mi_enregistrerSous.Click += new System.EventHandler(this.mi_enregistrerSous_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // mi_quitter
            // 
            this.mi_quitter.Name = "mi_quitter";
            this.mi_quitter.Size = new System.Drawing.Size(170, 22);
            this.mi_quitter.Text = "Quitter";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // nouveau
            // 
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(170, 22);
            this.nouveau.Text = "Nouveau";
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrer.Size = new System.Drawing.Size(170, 22);
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // edition
            // 
            this.edition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annuler,
            this.rétablir,
            this.toolStripSeparator3,
            this.copier,
            this.couper,
            this.collerToolStripMenuItem});
            this.edition.Name = "edition";
            this.edition.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.edition.Size = new System.Drawing.Size(56, 20);
            this.edition.Text = "Edition";
            // 
            // annuler
            // 
            this.annuler.Name = "annuler";
            this.annuler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annuler.Size = new System.Drawing.Size(157, 22);
            this.annuler.Text = "Annuler";
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // rétablir
            // 
            this.rétablir.Name = "rétablir";
            this.rétablir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rétablir.Size = new System.Drawing.Size(157, 22);
            this.rétablir.Text = "Rétablir";
            this.rétablir.Click += new System.EventHandler(this.rétablir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(154, 6);
            // 
            // copier
            // 
            this.copier.Name = "copier";
            this.copier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copier.Size = new System.Drawing.Size(157, 22);
            this.copier.Text = "Copier";
            this.copier.Click += new System.EventHandler(this.copier_Click);
            // 
            // couper
            // 
            this.couper.Name = "couper";
            this.couper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couper.Size = new System.Drawing.Size(157, 22);
            this.couper.Text = "Couper";
            this.couper.Click += new System.EventHandler(this.couper_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileOk += new System.ComponentModel.CancelEventHandler(this.od_ouvrir_FileOk);
            // 
            // sd_enregistrerSous
            // 
            this.sd_enregistrerSous.FileOk += new System.ComponentModel.CancelEventHandler(this.sd_enregistrerSous_FileOk);
            // 
            // sd_enregistrer
            // 
            this.sd_enregistrer.FileOk += new System.ComponentModel.CancelEventHandler(this.sd_enregistrer_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rt_texte);
            this.Controls.Add(this.mn_principal);
            this.MainMenuStrip = this.mn_principal;
            this.Name = "Form1";
            this.Text = "Mon petit éditeur";
            this.mn_principal.ResumeLayout(false);
            this.mn_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_texte;
        private System.Windows.Forms.MenuStrip mn_principal;
        private System.Windows.Forms.ToolStripMenuItem m_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_ouvrir;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrerSous;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mi_quitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.SaveFileDialog sd_enregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem nouveau;
        private System.Windows.Forms.ToolStripMenuItem enregistrer;
        private System.Windows.Forms.SaveFileDialog sd_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem edition;
        private System.Windows.Forms.ToolStripMenuItem annuler;
        private System.Windows.Forms.ToolStripMenuItem rétablir;
        private System.Windows.Forms.ToolStripMenuItem copier;
        private System.Windows.Forms.ToolStripMenuItem couper;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

