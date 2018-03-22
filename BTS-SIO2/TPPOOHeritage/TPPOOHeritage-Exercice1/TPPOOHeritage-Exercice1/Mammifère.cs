using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice1
{
    class Mammifère:Object
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCrie;
        protected string jeSuisDomestique;

        public Mammifère(string nom, string LieuHabitation, string monCrie, string jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        public bool JeSuisDangereux()
        {
            if (monCrie=="moyen") {
                Console.Write("Je suis dangereux ");
                return true;
            }
            else {
                Console.Write("Je ne suis pas dangereux ");
                return false;
            }
        }

        public void Afficher() 
        {
            Console.WriteLine("Présentation d'Animaux de compagnie (Votre choix selon sa dangérosité) \n");
        }

        public new string ToString() 
        {
            return string.Format("Je suis : {0} \n J'habite : {1} \n J'ai un crie d'intensité : {2} \n Suis-je domestique ? {3} \n",nom,LieuHabitation,monCrie,jeSuisDomestique);
        }
        
    }
}
