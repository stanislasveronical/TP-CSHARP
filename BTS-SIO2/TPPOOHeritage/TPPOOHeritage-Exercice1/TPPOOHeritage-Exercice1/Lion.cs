using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice1
{
    class Lion:Félin
    {
        public Lion(string nom, string LieuHabitation, string monCrie, string jeSuisDomestique, int nombrePattes)
            :base(nom,LieuHabitation,monCrie,jeSuisDomestique,nombrePattes)
        {

        }

        public new void Afficher() { }

    }
}
