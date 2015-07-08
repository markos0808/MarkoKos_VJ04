using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Z61
{
    class Dretve
    {
        public void dretvaA()
        {
            while (true)
            {
                Console.WriteLine("Ovo je dretva A");
                Thread.Sleep(2000);
            }
        }
        public void dretvaB()
        {
            while (true)
            {
                Console.WriteLine("Ovo je dretva B");
                Thread.Sleep(3000);
            }
        }

    }
}
