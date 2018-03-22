using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fiche2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void mi_quitter_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show("Voulez-vous vraiment quitter l'application ? ");
            Application.Exit();
            
            
        }

        private void od_ouvrir_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
        }

        private void mi_ouvrir_Click(object sender, EventArgs e)
        {
            if (od_ouvrir.ShowDialog() == DialogResult.OK)
            {
                rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void sd_enregistrerSous_FileOk(object sender, CancelEventArgs e)
        {
            rt_texte.SaveFile(sd_enregistrerSous.FileName, RichTextBoxStreamType.PlainText);
        }

        private void mi_enregistrerSous_Click(object sender, EventArgs e)
        {
            if (sd_enregistrerSous.ShowDialog() == DialogResult.OK)
            {
                rt_texte.SaveFile(sd_enregistrerSous.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void sd_enregistrer_FileOk(object sender, CancelEventArgs e)
        {
            rt_texte.SaveFile(sd_enregistrer.FileName, RichTextBoxStreamType.PlainText);
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (sd_enregistrer.ShowDialog() == DialogResult.OK)
            {
                rt_texte.SaveFile(sd_enregistrer.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void nouveau_Click(object sender, EventArgs e)
        {

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            rt_texte.Undo();
        }

        private void rétablir_Click(object sender, EventArgs e)
        {
            rt_texte.Redo();
        }

        private void copier_Click(object sender, EventArgs e)
        {
            rt_texte.Copy();
        }

        private void couper_Click(object sender, EventArgs e)
        {
            rt_texte.Cut();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rt_texte.Paste();
        }

        private void rt_texte_TextChanged(object sender, EventArgs e)
        {

        }



        
    }
}
