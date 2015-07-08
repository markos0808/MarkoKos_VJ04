using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z31
{
    class PromjenaPozicije
    {
        public PromjenaPozicije() { }

        public void promjena(Form1 forma)
        {
            Random r = new Random();
            int x = r.Next(0, 1000);
            int y = r.Next(0, 1000);
            forma.Location = new Point(x, y);

        }
    }
}
