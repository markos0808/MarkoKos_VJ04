using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z44
{
    class Labele
    {
        public Labele() { }

        public void generiraj(Form1 forma)
        {
            int broj = int.Parse(forma.txtBrojLabela.Text);
            Label labela;
            Random r = new Random();

            for (int i = 0; i < broj; i++)
            {
                labela = new Label();
                int a = r.Next(0, forma.Width);
                int b = r.Next(0, forma.Height);
                labela.Location = new Point(a, b);
                labela.Text = r.Next().ToString();
                forma.Controls.Add(labela);
            }
        }
    }
}
