using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z10
{
    class Lokacija
    {
        int a, b;
        public Lokacija(){}

        public void lokacijaMisa(Form1 forma, MouseEventArgs e)
        {
            a = e.X;
            b = e.Y;
            forma.label1.Text = (a + " , " + b).ToString();
        }
    }
}
