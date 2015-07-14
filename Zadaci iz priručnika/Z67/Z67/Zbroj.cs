using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z67
{
    class Zbroj
    {
        int n, m;
        int suma = 0;

        public Zbroj(int prvi, int drugi)
        {
            this.n = prvi;
            this.m = drugi;
        }

        public int zbrajanje()
        {
            return suma = n + m;
        }

    }
}
