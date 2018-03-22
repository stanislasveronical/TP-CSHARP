using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice3
{
    class Voiture : Vehicule
    {

        public bool Decapotable;
        public bool Climatisation;

        public Voiture(string immatriculation, int anneeDeConstruction, string marque, string modele, bool Decapotable, bool Climatisation)
            : base(immatriculation, anneeDeConstruction, marque, modele)
        {
            this.Decapotable = Decapotable;
            this.Climatisation = Climatisation;
        }

        public void AfficherClimatisation()
        {
            if ( Climatisation == false){
                Console.Write(" Sans Climatisation ");
            }
            else{
                Console.Write(" Avec Climatisation ");
            }
        }

        public void AfficherDecapotable()
        {
            if (Decapotable == false)
            {
                Console.Write("Voiture Non Decapotable");
            }
            else
            {
                Console.Write("Voiture Decapotable");
            }
        }
    }
        
}
