using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVjezbaOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozila automobil = new Vozila("Automobil",4);
            Vozila motocikl = new Vozila("Motocikl", 2);
            Console.WriteLine("Upisite max brzinu auta: ");
            automobil.MaxBrzina=  Convert.ToInt32(Console.ReadLine());
            motocikl.MaxBrzina = automobil.MaxBrzina * 13 / 10;
            Console.WriteLine(automobil.ToString());
            Console.WriteLine(motocikl.ToString());
            Console.ReadKey();
        }
    }
}
