using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z28
{
    class NovaLokacija
    {
        public NovaLokacija() { }

        public void pomakni(Form1 forma)
        {
            Random r = new Random();
            int x = r.Next(0, forma.Width);
            int y = r.Next(0, forma.Height);
            forma.btnRnd.Location = new Point(x, y);
        }
    }
}
