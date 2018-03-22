using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPDiagrammeDeSequence
{
    class Client : Personne
    {

        public void SeMetATable(Waiter unServeur)
        {
            Console.WriteLine("Help Serveur");
            unServeur.OrderFood(this);
            
        }
        public void ServeFood(Cashier leCaissier)
        {
            Console.WriteLine("Merci, A Table");
            leCaissier.Pay();
        }
        public void ServeWine()
        {
            Console.WriteLine("Enfin, j'ai soif !");
        }
    }
}
