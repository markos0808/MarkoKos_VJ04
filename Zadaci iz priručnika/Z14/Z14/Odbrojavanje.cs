using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z14
{
    class Odbrojavanje
    {
        public Odbrojavanje() { }

        public void sekDoUtakmice(Form1 forma)
        {
            long a = 20 * 60 * 60 + 45 * 60;
            long b = DateTime.Now.Hour * 60 * 60 + DateTime.Now.Minute * 60 + DateTime.Now.Second;
            forma.lblOdbr.Text = (a - b).ToString();
        }
    }
}
