using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Brojac_klikova
    {
        int brojac = 0;
        int vrijednost;

        public Brojac_klikova(int jedan, int dva)
        {
            this.brojac = jedan;
            this.vrijednost = dva;
        }

        public int Racun()
        {
            if (brojac > vrijednost)
                brojac = 0;
            return brojac;
        }
    }
}
