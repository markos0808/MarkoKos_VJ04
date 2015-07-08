using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z64
{
    class BojaFont
    {
        public BojaFont() { }

        public void promjena(Form1 forma)
        {
            forma.fontDialog1.ShowDialog();
            forma.colorDialog1.ShowDialog();
            forma.lblPI.Font = forma.fontDialog1.Font;
            forma.BackColor = forma.colorDialog1.Color;
        }
    }
}
