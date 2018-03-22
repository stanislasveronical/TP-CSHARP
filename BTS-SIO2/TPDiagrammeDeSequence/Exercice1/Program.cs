using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue unCatalogue = new Catalogue();
            Article unProcesseur = new Article("Processeur",150.0,19.6);
            Article uneBaretteMemoire = new Article("Memoire",30.0,19.6);
            Article uneCarteMere = new Article("CarteMere",80,19.6);

            unCatalogue.AjouterArticle(unProcesseur);
            unCatalogue.AjouterArticle(uneBaretteMemoire);
            unCatalogue.AjouterArticle(uneCarteMere);
            unCatalogue.AugmenterPetitPrix(10);

            Console.ReadLine();
        }
    }
}
