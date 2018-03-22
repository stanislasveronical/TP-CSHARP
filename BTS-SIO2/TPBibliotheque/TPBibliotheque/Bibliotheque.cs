    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPBibliotheque
{
    class Bibliotheque
    {
        private List<Etagere> mesEtageres;

        public Bibliotheque() { }

        public Genre GetGenre(string libelleGenre) {
            return mesEtageres;
        }

        public Livre NouveauLivre(string titre, string libelleGenre) {
            Livre NouveauLivre;
            Genre unGenre = this.GetGenre(libelleGenre);
            if (unGenre == null)
            {
                NouveauLivre = null;
            }
            else
            {
                NouveauLivre = new Livre(titre, unGenre);
                unGenre.PlaceLivre(NouveauLivre);
            }
            return NouveauLivre;
 
        }

        public void Add(Etagere e)
        {
            this.mesEtageres = e;
        }

    }
}
