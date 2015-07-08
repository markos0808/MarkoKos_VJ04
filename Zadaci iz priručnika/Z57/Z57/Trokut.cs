using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z57
{
    class Trokut
    {
        private float strA;
        private float strB;
        private float strC;

        public Trokut(float a, float b, float c)
        {
            this.strA = a;
            this.strB = b;
            this.strC = c;
        }

        public float IzracunajOpseg()
        {
            return strA + strB + strC;
        }

        public float IzracunajPovrsinu()
        {
            float s = IzracunajOpseg() / 2;
            return (float)Math.Sqrt(s * (s - strA) * (s - strB) * (s - strC));
        }
    }
}
