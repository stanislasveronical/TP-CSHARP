using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPBibliotheque
{
    class Genre
    {
        private string libelle;
        private Etagere lEtagere;
        private List<Livre> lesLivres;

        public Genre(string l, Etagere e) { }

        public void PlaceLivre(Livre unLivre) 
        {
            int i = rangLivre(unLivre.GetTitre());
            lesLivres.Insert(i, unLivre);
        }
        private int rangLivre(string titre) 
        {
            int index = 0;

            while ((lesLivres[index].GetTitre().CompareTo(titre) == 1) && (index < this.lesLivres.Count))
            {
                index = index + 1;
            }
            return index;

                  
        }


    }
}
