using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z52
{
    class Klikovi
    {
        int brojac, max;

        public Klikovi(int a, int b)
        {
            this.brojac = a;
            this.max = b;
        }

        public void bojaGumba(Form1 forma)
        {
            if (brojac > max)
            {
                brojac = 0;
                forma.btnKreni.BackColor = Color.FromArgb(100, 100, 100);
            }

            else
            {
                int povecanje = 155 / max;
                Color trenutnaBoja = forma.btnKreni.BackColor;
                forma.btnKreni.BackColor = Color.FromArgb(trenutnaBoja.R + povecanje, 100, 100);
            }
            forma.btnKreni.Text = brojac.ToString();
        }
    }
}
