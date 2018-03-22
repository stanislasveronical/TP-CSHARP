using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPDiagrammeDeSequence
{
    class Cook : Personne
    {


        public void OrderFood(Waiter unServeur)
        {
            Console.WriteLine("Plat du jour, ça marche !");
            unServeur.PickUp();
        }
    }
}
