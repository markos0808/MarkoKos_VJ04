using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Z61
{
    class Program
    {
        static void Main(string[] args)
        {
            Dretve instA = new Dretve();
            Dretve instB = new Dretve();

            Thread A = new Thread(new ThreadStart(instA.dretvaA));
            A.Start();

            Thread B = new Thread(new ThreadStart(instB.dretvaB));
            B.Start();
        }
    }
}
