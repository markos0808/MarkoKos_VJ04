using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z49
{
    class Slovo
    {
        public char znak { get; set; }
        public int brojPonavljanja { get; set; }

        public Slovo(char slovo)
        {
            this.znak = slovo;
            this.brojPonavljanja = 1;
        }


    }
}
