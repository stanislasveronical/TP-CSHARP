using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS2ConcessionAutomobile
{
    class Voiture : Vehicule
    {
        private Modèle possède;

        public Voiture(string immatriculation, Modèle possede) : base(immatriculation)
        {
            this.possède = possede;
        }

        public double CalculerPrix() {
            double prix = 0;
            prix = this.possède.GetPrix;
            for (int i = 0; i < this.possède.Count; i++)
            {
                prix = prix + this.possède[i].GetPrix();
            }
            for (int i = 0; i < this.Count; i++)
            {
                prix = prix + this[i].GetPrix();
            }
            return prix;
        }

        public new string ToString() {
            Console.WriteLine("Modèle : {0} GetPrix : {1}", this.possède.nom.ToString(), this.possède.prix.ToString()); 
            
            
            for (int i = 0; i < this.possède.Count; i++)
            {
                Console.WriteLine("{0} {1}", this.possède[i].GetLibelle(), this.possède[i].GetPrix());
            }
            base.ToString();

            Console.WriteLine("Prix total : {0}",CalculerPrix());
            

            return string.Format("");
        }


    }
}
