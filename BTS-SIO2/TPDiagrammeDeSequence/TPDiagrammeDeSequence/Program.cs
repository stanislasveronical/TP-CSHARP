using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPDiagrammeDeSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Client Fred = new Client();
            Cook Hank = new Cook();
            Cashier Renee = new Cashier();
            Waiter Bob = new Waiter(Hank, Renee);
            
            Fred.SeMetATable(Bob);
            

            Console.ReadLine();
        }
    }
}
