using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z27
{
    class Brojac
    {
        public int brojac { get; private set; }

        public Brojac()
        {
            this.brojac = 0;
        }

        public Brojac racunaj(Form1 forma)
        {
            this.brojac += 1;
            if (this.brojac % 2 == 0)
            {
                forma.lblbrojacKlikova.ForeColor = Color.Red;
            }

            else
                forma.lblbrojacKlikova.ForeColor = Color.Black;

            if (this.brojac > 10)
            {
                forma.WindowState = FormWindowState.Maximized;
            }
            return this;
        }
    }
}
