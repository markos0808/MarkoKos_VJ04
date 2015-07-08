using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z51
{
    class Intervali
    {
        int a = 0, b = 0, c = 0, d = 0;
        public Intervali(int jedan, int dva, int tri, int cetiri)
        {
            this.a = jedan;
            this.b = dva;
            this.c = tri;
            this.d = cetiri;
        }

        public string presjekSkupova()
        {
            List<int> prviDio = new List<int>();
            List<int> drugiDio = new List<int>();

            for (int i = a; i <= b; i++)
            {
                prviDio.Add(i);
            }

            for (int i = c; i <= d; i++)
            {
                drugiDio.Add(i);
            }

            List<int> presjek = new List<int>();
            foreach (int x in prviDio)
            {
                if (drugiDio.Contains(x))
                {
                    presjek.Add(x);
                }
            }
            string ispis = "";
            foreach (int x in presjek)
            {
                ispis += x.ToString() + ',';
            }
            return ispis;
        }
    }
}
