using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice1
{
    class Baleine:Cétacé
    {
        public Baleine(string nom, string LieuHabitation, string monCrie, string jeSuisDomestique, int DuréeApnée, 
            int ProfondeurPlongée):base(nom,LieuHabitation,monCrie,jeSuisDomestique,DuréeApnée,ProfondeurPlongée)
        {

        }

        public new void Afficher() { }
    }
}
