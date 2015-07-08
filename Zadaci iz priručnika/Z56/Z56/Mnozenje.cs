using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z56
{
    class Mnozenje
    {
        int rezultat = 1;
        private int n, m;

        public Mnozenje(int a, int b)
        {
            this.n = a;
            this.m = b;
        }

        public int izracun()
        {
            for (int i = n; i <= m; i++)
            {
                rezultat = rezultat * i;
            }
            return rezultat;
        }
    }
}
