using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z33
{
    class Suma
    {
        int a, b, c;
        int suma = 0;
    
        public Suma(int jedan, int dva, int tri)
        {
            this.a = jedan;
            this.b = dva;
            this.c = tri;
        }
       

        public int Izracun()
        {
            for (int i = a; i <= b; i++)
            {
                if (i % c != 0)
                {
                    suma+=i;
                }
                
            }
            return suma;
        }
    }
}
