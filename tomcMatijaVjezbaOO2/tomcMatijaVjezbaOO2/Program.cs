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
            Vozila auto = new Vozila("Auto",4);
            Console.WriteLine("Upisite max brzinu auta: ");
            auto.MaxBrzina=  Convert.ToInt32(Console.ReadLine());
        }
    }
}
