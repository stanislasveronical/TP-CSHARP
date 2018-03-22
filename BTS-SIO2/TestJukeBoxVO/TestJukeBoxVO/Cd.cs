using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJukeBoxVO
{
    class Cd : Media
    {
        private string artiste;
        private int nombrePiste;

        public Cd(string titre, string artiste, int nombreDePistes, int duree) :base(titre,duree)
        {
            this.artiste = artiste;
            this.nombrePiste = nombrePiste;
        }

        public void Afficher() 
        {
            base.Afficher();
            Console.WriteLine("C'est un Cd");
            Console.WriteLine(" " + artiste);
            Console.WriteLine("  pistes : " + nombrePiste);
        }
    }
}
