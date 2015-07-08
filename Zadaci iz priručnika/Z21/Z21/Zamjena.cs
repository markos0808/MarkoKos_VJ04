using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z21
{
    class Zamjena
    {
        public Zamjena() { }

        public void zamjenaSlova(Form1 forma)
        {
            forma.txtA.Text = forma.txtA.Text.Replace('a', 'b');
            forma.txtA.Text = forma.txtA.Text.Replace('b', 'b');
            forma.txtA.Select(forma.txtA.Text.Length, 0);
        }
    }
}
