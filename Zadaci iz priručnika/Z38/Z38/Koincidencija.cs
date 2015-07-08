using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z38
{
    class Koincidencija
    {
        Random r = new Random();
        public Koincidencija() { }

        public void slucajno(Form1 forma)
        {
            forma.setLabel(forma.lbl1, r);
            forma.setLabel(forma.lbl2, r);
            forma.setLabel(forma.lbl3, r);
            forma.setLabel(forma.lbl4, r);
            forma.setLabel(forma.lbl5, r);
        }
    }
}
