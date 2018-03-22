using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SVFenetreMereFille
{
    public partial class FFille : Form
    {

        private string monNom;
        private FMere maMere;
        private int numero;
        

        public FFille(FMere maMere, int numero)
        {
            InitializeComponent();
            this.numero = numero;
            this.Text = "Fille n°" + this.numero;
            this.monNom = this.Text;
            this.maMere = maMere;
           

            btnMaMere.Click += new EventHandler(btnMaMere_Click);
            btnChanger.Click += new EventHandler(btnChanger_Click);

            this.Load +=new EventHandler(FFille_Load);

        }

        void btnChanger_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
            //monNom = tb.Text;
            //MessageBox.Show("J'ai changer de nom, mon nouveau nom est "+monNom);
            //this.Text=monNom;

            this.Text = tb.Text;
            this.maMere.MaFilleChangeDeNom(this,this.tb.Text);

        }

        void FFille_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Evenement Load sur" + this.monNom);
        }

        void btnMaMere_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
            MessageBox.Show("Le nom de la mère de " + this.tb.Text + " est" + this.maMere);
            
        }



        private void FFille_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Etes-vous certain de vouloir quitter ?", "Quitter", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
