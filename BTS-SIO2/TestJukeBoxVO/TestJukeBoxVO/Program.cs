using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestJukeBoxVO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juke Box VO");

            Database db1 = new Database();
            Video v1 = new Video("Brasil", "Terry Gillian", 90);
            Cd cd1 = new Cd("Going for the one", "Yes", 6, 65);

            db1.Add(v1);
            db1.Add(cd1);
            db1.Editer();
            Console.Read();
        }
    }
}
