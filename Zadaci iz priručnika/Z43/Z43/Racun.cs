using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z43
{
    class Racun
    {
        int a, b;
        int c = 0;

        public Racun(int jedan, int dva)
        {
            this.a = jedan;
            this.b = dva;
        }

        public int Zbroj()
        {
            c = a + b;
            return c;
        }

        public int Razlika()
        {
            c = a - b;
            return c;
        }

        
    }
}
