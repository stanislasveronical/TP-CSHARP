using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice1
{
    class Cétacé:Mammifère
    {
        protected int DuréeApnée;
        protected int ProfondeurPlongée;

        public Cétacé(string nom, string LieuHabitation, string monCrie, string jeSuisDomestique, int DuréeApnée, 
            int ProfondeurPlongée):base(nom,LieuHabitation,monCrie,jeSuisDomestique)
        {
            this.DuréeApnée = DuréeApnée;
            this.ProfondeurPlongée = ProfondeurPlongée;
        }

        public new void Afficher() 
        {
            Console.WriteLine("Cétacé: Je suis {0} habite {1} et j'ai un crie {2}. Suis-je domestique? {3} J'ai une durée d'apnée de {4} et une profondeur de plongée de {5}",
                nom,LieuHabitation,monCrie,jeSuisDomestique,DuréeApnée,ProfondeurPlongée);
        }
    }
}
