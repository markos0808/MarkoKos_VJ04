using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z46
{
    class Pravokutnik
    {
        private float visina,sirina;

        public Pravokutnik(int a, int b)
        {
            this.visina = a;
            this.sirina = b;
        }

        public float IzracunajPovrsinu()
        {
            return visina * sirina;
        }

        public float IzracunajOpseg()
        {
            return (2 * visina) + (2 * sirina);
        }

        public float IzracunajDijagonalu()
        {
            return (float)(Math.Sqrt(visina*visina+sirina*sirina));
        }



    }
}
