namespace SVFenetreMereFille
{
    partial class FFille
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
            this.btnChanger = new System.Windows.Forms.Button();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(233, 105);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(92, 26);
            this.btnChanger.TabIndex = 0;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(116, 162);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(92, 23);
            this.btnMaMere.TabIndex = 1;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(116, 109);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(111, 20);
            this.tb.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 112);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(98, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "je change de nom :";
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 222);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.btnChanger);
            this.Name = "FFille";
            this.Text = "Fille";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FFille_FormClosing);
            this.Load += new System.EventHandler(this.FFille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Button btnMaMere;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lbl;
    }
}