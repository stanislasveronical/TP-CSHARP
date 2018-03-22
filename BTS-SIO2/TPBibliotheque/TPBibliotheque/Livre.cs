using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPBibliotheque
{
    class Livre
    {
        private string titre;
        private Genre leGenre;

        public string GetTitre() {
            return titre;
        }

        public Livre(string titre, Genre unGenre)
        {
            this.titre = titre;
            this.leGenre = unGenre;
            this.leGenre.PlaceLivre(this);
        }

    }
}
