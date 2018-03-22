using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice3
{
    class Vehicule
    {
        public string immatriculation;
        public int anneeDeConstruction;
        public string marque;
        public string modele;

        public Vehicule(string immatriculation, int anneeDeConstruction, string marque, string modele)
        {
            this.immatriculation = immatriculation;
            this.anneeDeConstruction = anneeDeConstruction;
            this.marque = marque;
            this.modele = modele;
        }

        public new string ToString()
        {
            return string.Format("\n Immatriculation : {0} \n Année de Construction : {1} \n Marque : {2} \n Modèle : {3} \n",immatriculation,anneeDeConstruction,marque,modele);
        }

    }
}
