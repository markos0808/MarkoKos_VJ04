using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z39
{
    class Povecaj
    {
        public Povecaj() { }

        public void povecaj(Form1 forma)
        {
            forma.lblTekst.Font = new Font(forma.lblTekst.Font.FontFamily, forma.lblTekst.Font.Size + 1);
        }
    }
}
