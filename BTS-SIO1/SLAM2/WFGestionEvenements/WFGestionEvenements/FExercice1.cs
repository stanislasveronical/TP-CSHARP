using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFGestionEvenements
{
    public partial class FExercice1 : Form
    {
        public FExercice1()
        {
            InitializeComponent();
            btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Au travail");
        }

        private void tbSaisie_TextChanged(object sender, EventArgs e)
        {
            tbSaisie.Text.AppendText(btnAfficher.Text);
             
        }
    }
}
