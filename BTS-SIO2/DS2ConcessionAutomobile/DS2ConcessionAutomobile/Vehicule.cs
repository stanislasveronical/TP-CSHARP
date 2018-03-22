using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS2ConcessionAutomobile
{
    class Vehicule
    {
        public string immatriculation;
        private List<Option> optionsBase;

        public Vehicule(string immatriculation){
            this.immatriculation = immatriculation;
            this.optionsBase = new List<Option>();
        }
     
        public void AddOption(Option option)
        {
            optionsBase.Add(option);
        }

        public bool possèdeOption(string libellé) {
            return true;
        }
        

        public Option this[int index] { get { return this.optionsBase[index]; } }

        public int Count { get { return this.optionsBase.Count; } }

        public new string ToString() {

            Console.WriteLine("Vehicule : {0}", this.immatriculation);
            for (int i = 0; i < optionsBase.Count; i++)
            {
                Console.WriteLine("{0} {1}", optionsBase[i].GetLibelle(), optionsBase[i].GetPrix());
            }
            

            return string.Format("");
        }
        

    }
}
