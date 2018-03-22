using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice3
{
    class Camion:Vehicule
    {
        public bool semiRemorque;
        public int essieux;

        public Camion(string immatriculation, int anneeDeConstruction, string marque, string modele,bool semiRemorque,int essieux)
            : base(immatriculation, anneeDeConstruction, marque, modele)
        {
            
            this.semiRemorque = semiRemorque;
            this.essieux=essieux;
        }

        public void AffichersemiRemorque()
        {
            if (semiRemorque == false)
            {
                Console.Write("Camion ");
            }
            else
            {
                Console.Write("Semi Remorque ");
            }
        }

        public void AfficherEssieux()
        {
            Console.Write(" avec " + essieux + " essieux ");
        }
    }
}
