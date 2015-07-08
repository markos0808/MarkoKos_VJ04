using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z36
{
    class Mjesec
    {
        int v1,v2;
        string s="";

        public Mjesec(int a, int b)
        {
            this.v1 = a;
            this.v2 = b;
        }

        public string popMj()
        {
            for (int i = (v1) + 1; i <= (v2) - 1; i++)
            {
                s += i.ToString() + ',';
            }
            return s;
        }
    }
}
