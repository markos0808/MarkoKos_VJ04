using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z8
{
    class Zamjena
    {
        string a, b, c;

        public Zamjena(string jedan, string dva, string tri)
        {
            this.a = jedan;
            this.b = dva;
            this.c = tri;
        }

        public string zamjenaPozicija()
        {
            c = c.Replace(a, b);
            return c;
        }
    }
}
