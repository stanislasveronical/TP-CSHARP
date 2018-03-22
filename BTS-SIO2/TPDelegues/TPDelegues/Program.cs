using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPDelegues
{
    class Program
    {
        //Déclarez le bon prototype de chaque délégué
        //Si méthode peut être multicast regroupez toutes les méthodes de même signature
        delegate void PrototypeSurp1p4p7(int i, string s);
        delegate void PrototypeSurp2p5p9(int i1, int i2, int i3);
        delegate void PrototypeSurp3(string s1, string s2, string s3);
        delegate void PrototypeSurp6(string s1, string s2, int i);
        delegate void PrototypeSurp8(double d, string s);
        delegate int PrototypeSurf1();
        delegate string PrototypeSurf2(int i);
        delegate double PrototypeSurf3();
        delegate decimal PrototypeSurf4(decimal d1, decimal d2);
        delegate int PrototypeSurf5(string s1, string s2, string s3);
        delegate bool PrototypeSurf6(int i,string s);
        delegate DateTime PrototypeSurf7(double d, string s);
        delegate double PrototypeSurf8(bool b1, bool b2);
        delegate int PrototypeSurf9(int i, DateTime dt);
        
        

        static void Main(string[] args)
        {
            //Créez un délégué par prototype
            PrototypeSurp1p4p7 deleguep1p4p7 = null;
            PrototypeSurp2p5p9 deleguep2p5p9 = null;
            PrototypeSurp3 deleguep3 = null;
            PrototypeSurp6 deleguep6 = null;
            PrototypeSurp8 deleguep8 = null;
            PrototypeSurf1 deleguef1 = null;
            PrototypeSurf2 deleguef2 = null;
            PrototypeSurf3 deleguef3 = null;
            PrototypeSurf4 deleguef4 = null;
            PrototypeSurf5 deleguef5 = null;
            PrototypeSurf6 deleguef6 = null;
            PrototypeSurf7 deleguef7 = null;
            PrototypeSurf8 deleguef8 = null;
            PrototypeSurf9 deleguef9 = null;

            //Inscrivez chaque méthodes dans un délégué
            deleguep1p4p7 += p1;
            deleguep1p4p7 += p4;
            deleguep1p4p7 += p7;

            deleguep2p5p9 += p2;
            deleguep2p5p9 += p5;
            deleguep2p5p9 += p9;

            deleguep3 += p3;

            deleguep6 += p6;

            deleguep8 += p8;

            deleguef1 += f1;
            deleguef2 += f2;
            deleguef3 += f3;
            deleguef4 += f4;
            deleguef5 += f5;
            deleguef6 += f6;
            deleguef7 += f7;
            deleguef8 += f8;
            deleguef9 += f9;

            //Executez les méthodes au travers des délégués
            
            //Pour délégués multicast lancez chacune des méthodes du délégué multicast grace a InvocationList
            /*deleguep1p4p7(7, "Hello");*/
            int val = 7;
            foreach (PrototypeSurp1p4p7 uneMethode in deleguep1p4p7.GetInvocationList())
            {
                uneMethode(val, "Hello");
                val = val + 10;
            }
            /*deleguep2p5p9(8, 9, 7);*/
            int val1 = 8;
            int val2 = 9;
            
            foreach (PrototypeSurp2p5p9 uneMethode in deleguep2p5p9.GetInvocationList())
            {
                uneMethode(val1, val2, val);
                val = val + 10;
            }

            deleguep3("He", "ll", "o");
            deleguep6("Hello", "World", 7);
            deleguep8(7.7, "Hello");

            deleguef1();
            deleguef2(7);
            deleguef3();
            deleguef4((decimal)7.7, (decimal)7.7);
            deleguef5("He", "ll", "o");
            deleguef6(7, "Hello");
            deleguef7(7.7, "Hello");
            deleguef8(true, true);
            deleguef9(7, DateTime.Today);

            Console.ReadLine();
        }

        static void p1(int i1, string s1)
        {
            Console.WriteLine("je suis p1");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}",i1,s1);
        }
        static void p2(int i1, int i2,int i3)
        {
            Console.WriteLine("je suis p2");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}-{2}", i1, i2,i3);
        }
        static void p3(string s1, string s2, string s3)
        {
            Console.WriteLine("je suis p3");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}-{2}", s1, s2, s3);
        }
        static void p4(int i1, string s)
        {
            Console.WriteLine("je suis p4");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", i1, s);
        }
        static void p5(int i1, int i2, int i3)
        {
            Console.WriteLine("je suis p5");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}-{2}", i1, i2, i3);
        }
        static void p6(string s1, string s2, int i3)
        {
            Console.WriteLine("je suis p6");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}-{2}", s1, s2, i3);
        }
        static void p7(int i1, string s1)
        {
            Console.WriteLine("je suis p7");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", i1, s1);
        }
        static void p8(double d1, string s1)
        {
            Console.WriteLine("je suis p8");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", d1, s1);
        }
        static void p9(int j,int k, int l)
        {
            Console.WriteLine("je suis p9");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}-{2}", j, k, l);
        }
        static int f1() 
        {
            Console.WriteLine("je suis f1");
            return 0;
        }
        static string f2(int i) 
        {
            Console.WriteLine("je suis f2");
            Console.WriteLine("la valeur de mes paramètres est {0}", i);
            return null; 
        }
        static double f3() 
        {
            Console.WriteLine("je suis f3");
            return 0; 
        }
        static decimal f4(decimal d1, decimal d2) 
        {
            Console.WriteLine("je suis f4");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", d1,d2);
            return 0; 
        }
        static int f5(string s1, string s2, string s3) 
        {
            Console.WriteLine("je suis f5");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}-{2}", s1, s2,s3);
            return 0; 
        }
        static bool f6(int i, string s) 
        {
            Console.WriteLine("je suis f6");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", i,s);
            return true; 
        }
        static DateTime f7(double d1, string s) 
        {
            Console.WriteLine("je suis f7");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", d1, s);
            return default(DateTime); 
        }
        static double f8(bool b1, bool b2) 
        {
            Console.WriteLine("je suis f8");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", b1,b2);
            return 0; 
        }
        static int f9(int i, DateTime dt) 
        {
            Console.WriteLine("je suis f9");
            Console.WriteLine("la valeur de mes paramètres est {0}-{1}", i, dt);
            return 0; 
        }
    }
}
