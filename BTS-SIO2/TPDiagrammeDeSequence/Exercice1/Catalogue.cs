using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1
{
    public class Catalogue
    {
        private List<Article> leCatalogue;

        public Catalogue() 
        {
            leCatalogue = new List<Article>();        
        }

        public void AjouterArticle(Article unArticle)
        {
            leCatalogue.Add(unArticle);
            Console.WriteLine("L'article vient d'être ajouté au catalogue.");
        }
        public void AugmenterPetitPrix(double prixHorsTaxe) 
        { 

        }
        public void AfficherCatalogue() 
        {
            Console.WriteLine(leCatalogue); 
        }
    }
}
