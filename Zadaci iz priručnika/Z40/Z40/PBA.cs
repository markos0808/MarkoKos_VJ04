using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z40
{
    class PBA
    {
        public PBA() { }

        public void vrijednost(Form1 forma)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int vrijednost = r.Next(0, 100);
                forma.pb[i].Value = vrijednost;
            }
        }
    }
}
