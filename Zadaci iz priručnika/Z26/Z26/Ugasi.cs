using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z26
{
    class Ugasi
    {
        double sekunde;

        public Ugasi(double s)
        {
            this.sekunde = s;
        }

        public double brojSekunda(Form1 forma)
        {
            double brojS = double.Parse(forma.txtA.Text);
            double broji = brojS + sekunde;
            return broji;
        }
    }
}
