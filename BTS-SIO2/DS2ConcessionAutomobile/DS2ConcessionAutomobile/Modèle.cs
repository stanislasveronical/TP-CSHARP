using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS2ConcessionAutomobile
{
    class Modèle
    {
        public string nom;
        public double prix;
        private List<Option> optionsModèle;

        public Modèle(string nom, double prix){
            this.nom=nom;
            this.prix=prix;
            optionsModèle=new List<Option>();
        }

        public double GetPrix
        {
            get { return prix; }
        }

        public void AddOption(Option option)
        {
            optionsModèle.Add(option);
        }

        public Option this[int index]
        {
            get { return this.optionsModèle[index]; }
        }

        public bool PossèdeOption(string libellé)
        {
            return true;
        }

        public int Count
        {
            get { return this.optionsModèle.Count; }
        }

        public new string ToString() {
            Console.WriteLine("Modèle : {0} GetPrix : {1}", this.nom, this.GetPrix);
            for (int i = 0; i < optionsModèle.Count; i++)
            {
                Console.WriteLine("{0} {1}", optionsModèle[i].GetLibelle(), optionsModèle[i].GetPrix());
            }
            Console.WriteLine();
            return string.Format("");
        }

    }
}
