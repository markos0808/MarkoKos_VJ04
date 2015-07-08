using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z58
{
    class Krug
    {
        double polumjer;

        public Krug(double r)
        {
            this.polumjer = r;
        }

        public double IzracunajOpseg()
        {
            return 2 * polumjer * Math.PI;
        }

        public double IzracunajPovrsinu()
        {
            return Math.Pow(polumjer,2) * Math.PI;
        }
    }
}
