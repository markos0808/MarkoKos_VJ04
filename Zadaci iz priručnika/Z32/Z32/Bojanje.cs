using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z32
{
    class Bojanje
    {
        public Bojanje() { }

        public void Boja(Form1 forma)
        {
            forma.BackColor = Color.FromArgb(forma.trackBarR.Value, forma.trackBarG.Value, forma.trackBarB.Value);
        }
    }
}
