using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPBibliotheque
{
    class Etagere
    {
        private int numero;
        private List<Genre> lesGenres;

        public Etagere(int numero) { }

        public int GetGenreCount() 
        {
            return numero;
        }

        public Genre GetGenre(int i)
        {
            return lesGenres;
        }
    }
}
