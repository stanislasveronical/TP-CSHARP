using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPPOOHeritage_Exercice1
{
    class Félin:Mammifère
    {
        protected int nombrePattes;

        public Félin(string nom, string LieuHabitation, string monCrie, string jeSuisDomestique, int nombrePattes)
            :base(nom,LieuHabitation,monCrie,jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
        }

        public new void Afficher() { }
    }
}
