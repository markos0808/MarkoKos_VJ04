using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z25
{
    class Boja
    {
        int r, g, b;

        public Boja(int jedan, int dva, int tri)
        {
            this.r = jedan;
            this.g = dva;
            this.b = tri;
        }

        public void proracunBoje(Form1 forma)
        {
            if (r <= 255 && g <= 255 && b <= 255)
            {
                forma.BackColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
