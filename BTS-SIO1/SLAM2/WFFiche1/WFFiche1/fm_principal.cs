using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFFiche1
{
    public partial class fm_principal : Form
    {
        public fm_principal()
        {
            InitializeComponent();
        }

        
        private void lb_liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_ajout_Click(object sender, EventArgs e)
        {
            lb_liste.Items.Add(tb_saisie.Text);
            tb_saisie.Text = "";
            tb_saisie.Focus();
            
            if (tb_saisie.Text.Trim() == "")
            {
                MessageBox.Show(tb_saisie.Text = "Attention, Votre zone de saisie est vide !");
            }
            else
            {
                MessageBox.Show(tb_saisie.Text);
            }
        }

        private void bt_supp_Click(object sender, EventArgs e)
        {
            lb_liste.Items.RemoveAt(lb_liste.SelectedIndex);
        }
    }
}
