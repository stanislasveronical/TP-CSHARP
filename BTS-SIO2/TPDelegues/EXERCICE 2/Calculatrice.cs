using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXERCICE_2
{
    public enum Choix { Addition, Soustraction, Division, Multiplication };

    public class Calculatrice
    {
        
        
        public delegate int PrototypeOperation(int i, int j);
        PrototypeOperation dlgOperation = null;
        
        private List<int> lesNombres;

        public Calculatrice()
        {
            dlgOperation += Calculer;
            this.lesNombres = new List<int>();
        }

        public void Add(int n) 
        {
            lesNombres.Add(n);
        }
   
        public int Calculer() 
        {
            int calculer = 0;
            //for (int i = 0; i < lesNombres.Count; i++)
            //{
            //    calculer = calculer + lesNombres[i];
            //}
            calculer = lesNombres[0] + lesNombres[1] - lesNombres[2];
            Console.WriteLine("{0}+{1}-{2}={3}", lesNombres[0],lesNombres[1],lesNombres[2],calculer);
            return calculer; 
        }

        public int Calculer(int n1, int n2) 
        {
            int calculer = 0;
            Choix unChoix = Choix.Addition;
            if (unChoix == Choix.Addition)
            {
                calculer = n1 + n2;
            }
            else
            {
                calculer = n1 - n2;
            }
            return calculer; 
        }
        
        public void ChoixOperation(Choix choix) 
        {
            //Choix unChoix = Choix.Addition;
            //if (unChoix == Choix.Addition)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            switch (choix)
            {
                case Choix.Addition:
                    dlgOperation += Addition;
                    break;
                case Choix.Soustraction:
                    dlgOperation += Soustraction;
                    break;
            }
        }

        public int Soustraction(int n1, int n2) 
        {
            int resultat = n1 - n2;
            return resultat;  
        }
        public int Addition(int n1, int n2)
        {
            int resultat = n1 + n2;
            return resultat;
        }


    }
}
