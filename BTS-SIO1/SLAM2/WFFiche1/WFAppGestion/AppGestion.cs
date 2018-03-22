using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFAppGestion
{
    public partial class AppGestion : Form
    {
        public AppGestion()
        {
            InitializeComponent();
            btnAjouterListe1.Click += new System.EventHandler(this.btnAjouterListe1_Click);
            btnSupprimerListe1.Click += new System.EventHandler(this.btnSupprimerListe1_Click);
            btnAjouterListe2.Click += new System.EventHandler(this.btnAjouterListe2_Click);
            btnSupprimerListe2.Click += new System.EventHandler(this.btnSupprimerListe2_Click);
            btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            btnPassageGD.Click += new System.EventHandler(this.btnPassageGD_Click);
            btnPassageDG.Click += new System.EventHandler(this.btnPassageDG_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voulez-vous vraiment quitter l'application ? ");
            Application.Exit();
            
        }

        private void btnAjouterListe1_Click(object sender, EventArgs e)
        {
            lb1.Items.Add(tb1.Text);
            tb1.Text = "";
            tb1.Focus();
            
        }

        private void btnSupprimerListe1_Click(object sender, EventArgs e)
        {
            lb1.Items.RemoveAt(lb1.SelectedIndex);
            
        }

        private void btnAjouterListe2_Click(object sender, EventArgs e)
        {
            lb2.Items.Add(tb2.Text);
            tb2.Text = "";
            tb2.Text.Trim();
            tb2.Focus();
        }

        private void btnSupprimerListe2_Click(object sender, EventArgs e)
        {
            lb2.Items.RemoveAt(lb2.SelectedIndex);
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPassageGD_Click(object sender, EventArgs e)
        {
            lb2.Items.Add(lb1.SelectedItem);
            
        }

        private void btnPassageDG_Click(object sender, EventArgs e)
        {
            lb1.Items.Add(lb2.SelectedItem);
        }

        

        
    }
}
