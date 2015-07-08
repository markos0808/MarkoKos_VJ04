using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z23
{
    class Broji
    {
        public int brojac { get; private set; }
        public Color trenutnaBoja { get; private set; }

        public Broji()
        {
            this.brojac = 0;
            this.trenutnaBoja = Color.Green;
        }

        public Broji racunaj()
        {
            this.brojac += 1;
            if (this.brojac % 10 == 0)
                this.trenutnaBoja = Color.Red;
            else
                this.trenutnaBoja = Color.Green;
            return this;
        }
    }
}
