using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPEventSurObj
{
    class Livre
    {
        private string titre;
        private decimal prixHt;
        private decimal tauxTva;

        public Livre(string titre, decimal prix, decimal tauxTva)
        {
            this.titre = titre;
            this.prixHt = prix;
            this.tauxTva = tauxTva;
        }

        public decimal PrixHt
        {
            get { return prixHt; }
            set { prixHt = value; }
        }

        public void HausseAnnuelle()
        {
            prixHt = prixHt * (decimal)1.1;
        }

        public decimal PrixTTC
        {
            get { return (1 + this.tauxTva / 100) * this.prixHt; }
        }

        public override string ToString()
        {
           return this.titre;
        }
    }
}
