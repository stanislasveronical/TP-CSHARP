using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFMaPremiereFenetre
{
    public partial class MaPremiereFenetre : Form
    {
        public MaPremiereFenetre()
        {
            InitializeComponent();
            this.Text = "Bonjour";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bGo_Click(object sender, EventArgs e)
        {
            if (rbAnglais.Checked == true)
            {
                lblZoneAffichage.Text = "Hello " + tbPrenom.Text;
                MessageBox.Show("Hello " + tbPrenom.Text);
            }
            else {
                lblZoneAffichage.Text = "Gutten Tag " + tbPrenom.Text;
                MessageBox.Show("Gutten Tag " + tbPrenom.Text);

            }
        }
    }
}
