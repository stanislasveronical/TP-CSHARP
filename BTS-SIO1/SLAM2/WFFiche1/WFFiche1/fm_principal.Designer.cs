namespace WFFiche1
{
    partial class fm_principal
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
            this.lb_liste = new System.Windows.Forms.ListBox();
            this.tb_saisie = new System.Windows.Forms.TextBox();
            this.bt_ajout = new System.Windows.Forms.Button();
            this.bt_supp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_liste
            // 
            this.lb_liste.FormattingEnabled = true;
            this.lb_liste.Location = new System.Drawing.Point(46, 73);
            this.lb_liste.Name = "lb_liste";
            this.lb_liste.Size = new System.Drawing.Size(219, 199);
            this.lb_liste.Sorted = true;
            this.lb_liste.TabIndex = 0;
            this.lb_liste.UseWaitCursor = true;
            this.lb_liste.SelectedIndexChanged += new System.EventHandler(this.lb_liste_SelectedIndexChanged);
            // 
            // tb_saisie
            // 
            this.tb_saisie.Location = new System.Drawing.Point(46, 304);
            this.tb_saisie.Name = "tb_saisie";
            this.tb_saisie.Size = new System.Drawing.Size(219, 20);
            this.tb_saisie.TabIndex = 1;
            // 
            // bt_ajout
            // 
            this.bt_ajout.Location = new System.Drawing.Point(333, 243);
            this.bt_ajout.Name = "bt_ajout";
            this.bt_ajout.Size = new System.Drawing.Size(113, 29);
            this.bt_ajout.TabIndex = 2;
            this.bt_ajout.Text = "&Ajouter";
            this.bt_ajout.UseVisualStyleBackColor = true;
            this.bt_ajout.UseWaitCursor = true;
            this.bt_ajout.Click += new System.EventHandler(this.bt_ajout_Click);
            // 
            // bt_supp
            // 
            this.bt_supp.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_supp.Location = new System.Drawing.Point(333, 278);
            this.bt_supp.Name = "bt_supp";
            this.bt_supp.Size = new System.Drawing.Size(117, 29);
            this.bt_supp.TabIndex = 3;
            this.bt_supp.Text = "&Supprimer";
            this.bt_supp.UseVisualStyleBackColor = true;
            this.bt_supp.UseWaitCursor = true;
            this.bt_supp.Click += new System.EventHandler(this.bt_supp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Une liste déroulante";
            // 
            // fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_supp);
            this.Controls.Add(this.bt_ajout);
            this.Controls.Add(this.tb_saisie);
            this.Controls.Add(this.lb_liste);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fm_principal";
            this.Text = "Premier Programme";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_liste;
        private System.Windows.Forms.TextBox tb_saisie;
        private System.Windows.Forms.Button bt_ajout;
        private System.Windows.Forms.Button bt_supp;
        private System.Windows.Forms.Label label1;
    }
}

