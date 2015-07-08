using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z37
{
    class Promjena
    {
        public Promjena() { }

        public void promjena(Form1 forma)
        {
            if (forma.txtBjezi.Text[forma.txtBjezi.Text.Length - 1] == 'T')
            {
                Random r = new Random();
                int x = r.Next(0, forma.Width);
                int y = r.Next(0, forma.Height);
                forma.txtBjezi.Location = new Point(x, y); 
            }
        }
    }
}
