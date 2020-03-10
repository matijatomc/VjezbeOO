using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVjezbaOO
{
    class Program
    {
        static void Main(string[] args)
        {
            float prVisinaKata;
            
            Neboder Tower = new Neboder(200, 100);

            Tower.setVisina(Tower.getVisina() + 10);
            Tower.setBrojKatova(Tower.getBrojKatova()+1);

            prVisinaKata = Tower.getVisina() / Tower.getBrojKatova();

            Console.WriteLine(Tower.ToString() + "\nProsjećna visina kata " + prVisinaKata + "m");
            Console.ReadKey();
        }
    }
}
