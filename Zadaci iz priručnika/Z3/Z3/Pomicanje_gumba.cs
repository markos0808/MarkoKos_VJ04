using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z3
{
    class Pomicanje_gumba
    {
        public Pomicanje_gumba() { }

        public void Pomakni(Form1 forma)
        {
            Random r = new Random();
            int a = r.Next(0, 250);
            int b = r.Next(0, 250);
            forma.btnPremjesti.Location = new Point(a, b);

        }
    }
}
