using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z42
{
    class Racun
    {
        double a, b;

        public Racun(double jedan, double dva)
        {
            this.a = jedan;
            this.b = dva;
        }

        public double Izracun()
        {
            double c = a / b;
            return c;
        }
    }
}
