using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaVjezbaOO
{
    class Neboder
    {
        float visina;
        int brojKatova;

        public override string ToString()
        {
            string ispis = "\nVisina: " + visina + " m" + "\nBroj katova " + brojKatova ;
            return ispis;
        }
        public float getVisina()
        {
            return visina;
        }
        public void setVisina(float visina)
        {
            this.visina = visina;
        }

        public int getBrojKatova()
        {
            return brojKatova;
        }
        public void setBrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }

        public Neboder(float visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }
    }
}
