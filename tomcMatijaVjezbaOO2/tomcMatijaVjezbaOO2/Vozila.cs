using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVjezbaOO2
{
    class Vozila
    {
        string vrsta;
        int maxBrzina;
        int brojKotaca;

        public override string ToString()
        {
            string ispis = "\nVrsta: " + vrsta + "\nMax brzina: " + maxBrzina + " km/h" + "\nBroj kotača: " + brojKotaca;
            return ispis;
        }
        public string Vrsta { get => vrsta; set => vrsta = value; }
        public int MaxBrzina { get => maxBrzina; set => maxBrzina = value; }
        public int BrojKotaca { get => brojKotaca; set => brojKotaca = value; }

        public Vozila(string vrsta, int brojKotaca)
        {
            this.vrsta = vrsta;
            this.brojKotaca = brojKotaca;
        }
    }
}
