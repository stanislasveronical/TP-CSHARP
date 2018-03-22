using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPDiagrammeDeSequence
{
    class Waiter : Personne
    {
        Cook monCuisinier;
        Client monClient;
        Cashier unCaissier;

        public Waiter(Cook unCuisinier, Cashier leCaissier)
        {
            this.unCaissier = leCaissier;
            this.monCuisinier = unCuisinier;    
         }

        public void OrderFood(Client monClient)
        {
            this.monClient = monClient;
            Console.WriteLine("A votre disposition ! Que voulez-vous ?");
            monCuisinier.OrderFood(this);  
        }
        
        public void PickUp()
        {
            this.monClient.ServeWine();
            this.monClient.ServeFood(this.unCaissier);
        }
    }
}
