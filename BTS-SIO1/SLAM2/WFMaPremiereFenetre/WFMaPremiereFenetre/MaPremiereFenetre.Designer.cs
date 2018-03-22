namespace WFMaPremiereFenetre
{
    partial class MaPremiereFenetre
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
            this.gbLangues = new System.Windows.Forms.GroupBox();
            this.rbAllemand = new System.Windows.Forms.RadioButton();
            this.rbAnglais = new System.Windows.Forms.RadioButton();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.bGo = new System.Windows.Forms.Button();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblZoneAffichage = new System.Windows.Forms.Label();
            this.gbLangues.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLangues
            // 
            this.gbLangues.Controls.Add(this.rbAnglais);
            this.gbLangues.Controls.Add(this.rbAllemand);
            this.gbLangues.Location = new System.Drawing.Point(49, 44);
            this.gbLangues.Name = "gbLangues";
            this.gbLangues.Size = new System.Drawing.Size(200, 100);
            this.gbLangues.TabIndex = 0;
            this.gbLangues.TabStop = false;
            this.gbLangues.Text = "Langues";
            this.gbLangues.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbAllemand
            // 
            this.rbAllemand.AutoSize = true;
            this.rbAllemand.Location = new System.Drawing.Point(33, 30);
            this.rbAllemand.Name = "rbAllemand";
            this.rbAllemand.Size = new System.Drawing.Size(68, 17);
            this.rbAllemand.TabIndex = 0;
            this.rbAllemand.TabStop = true;
            this.rbAllemand.Text = "Allemand";
            this.rbAllemand.UseVisualStyleBackColor = true;
            // 
            // rbAnglais
            // 
            this.rbAnglais.AutoSize = true;
            this.rbAnglais.Location = new System.Drawing.Point(33, 54);
            this.rbAnglais.Name = "rbAnglais";
            this.rbAnglais.Size = new System.Drawing.Size(59, 17);
            this.rbAnglais.TabIndex = 1;
            this.rbAnglais.TabStop = true;
            this.rbAnglais.Text = "Anglais";
            this.rbAnglais.UseVisualStyleBackColor = true;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(140, 185);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 1;
            // 
            // bGo
            // 
            this.bGo.Location = new System.Drawing.Point(324, 185);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(75, 23);
            this.bGo.TabIndex = 2;
            this.bGo.Text = "Go";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(46, 195);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblZoneAffichage
            // 
            this.lblZoneAffichage.AutoSize = true;
            this.lblZoneAffichage.Location = new System.Drawing.Point(79, 259);
            this.lblZoneAffichage.Name = "lblZoneAffichage";
            this.lblZoneAffichage.Size = new System.Drawing.Size(77, 13);
            this.lblZoneAffichage.TabIndex = 4;
            this.lblZoneAffichage.Text = "ZoneAffichage";
            // 
            // MaPremiereFenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 330);
            this.Controls.Add(this.lblZoneAffichage);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.bGo);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.gbLangues);
            this.Name = "MaPremiereFenetre";
            this.Text = "Bonjour";
            this.gbLangues.ResumeLayout(false);
            this.gbLangues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLangues;
        private System.Windows.Forms.RadioButton rbAnglais;
        private System.Windows.Forms.RadioButton rbAllemand;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblZoneAffichage;
    }
}

