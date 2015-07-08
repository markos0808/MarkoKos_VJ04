using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z35
{
    class Lokacija
    {
        public Lokacija() { }

        public void location(Form1 forma, MouseEventArgs e)
        {
            forma.progressBarX.Value = e.X;
            forma.progressBarY.Value = e.Y;
        }
    }
}
