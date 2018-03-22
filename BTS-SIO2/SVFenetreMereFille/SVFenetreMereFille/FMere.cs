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
    public partial class FMere : Form
    {
        private List<FFille> lesFilles;
        private int nombreFille;
        private string nomMere;
        
        
        public FMere()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            lesFilles = new List<FFille>();
            btnNew.Click += new EventHandler(btnNew_Click);
            btnNew.Click +=new EventHandler(btnNew_Click_Message);

            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click +=new EventHandler(btnHide_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
            btnClose.Click += new EventHandler(btnClose_Click);

 
        }

        public string GetNomMere()
        {
            return nomMere;
        }

        void btnNew_Click_Message(object sender, EventArgs e)
        {
            MessageBox.Show("Une fenêtre fille a été instanciée");
        }
          

        void btnShow_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (lbLesFilles.SelectedIndex != -1)
            { 
                this.lesFilles[lbLesFilles.SelectedIndex].Show();
            }
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            FFille nouvelleFille;
            nombreFille = nombreFille + 1;
            nouvelleFille = new FFille(this,this.nombreFille);
            lesFilles.Add(nouvelleFille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);

        }

        private void FMere_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Hide();
            }
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex != -1)
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Close();
            }
        }

        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {
            int position = lesFilles.IndexOf(ffille);
            lbLesFilles.Items[position] = nouveauNom;
        }

              
    }
}
