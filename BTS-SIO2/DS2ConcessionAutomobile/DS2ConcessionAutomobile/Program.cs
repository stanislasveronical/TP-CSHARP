using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS2ConcessionAutomobile
{
    class Program
    {
        static void Main(string[] args)
        {
            Modèle m = new Modèle("Clio", 12000);
            Vehicule v = new Voiture("474 qq 95", m);
            Voiture vo = new Voiture ("372 qq 95", m);

            Option cd = new Option("CdAudio", 230);
            Option air = new Option("AirConditionné", 395);
            Option direction = new Option("DirectionAssisté", 250);
            Option airBag = new Option("AirBag", 320);

            m.AddOption(direction);
            m.AddOption(airBag);
            v.AddOption(cd);
            v.AddOption(air);
            vo.AddOption(cd);
            vo.AddOption(air);

            m.ToString();
            
            v.ToString();
            Console.WriteLine();
            vo.ToString();

            Console.ReadLine();
        }
    }
}
