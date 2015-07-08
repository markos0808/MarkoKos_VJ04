using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z47
{
    class GeneriranjeLabela
    {
        public GeneriranjeLabela() { }

        public void generiraj(Form1 forma)
        {
            Random brojevi = new Random();
            int provjera;

            for (int i = 0; i < 100; i++)
            {
                Label labela = new Label();
                provjera = brojevi.Next(0, 1000);

                if (provjera < 500 && provjera % 2 == 0)
                {
                    labela.Location = new Point(brojevi.Next(forma.Width / 2, forma.Width), brojevi.Next(forma.Height / 2, forma.Height));
                    labela.Text = provjera.ToString();
                }

                if (provjera > 500 && provjera % 2 == 0)
                {
                    labela.Location = new Point(brojevi.Next(forma.Width / 2, forma.Width), brojevi.Next(0,forma.Height / 2));
                    labela.Text = provjera.ToString();
                }

                if (provjera < 500 && provjera % 2 != 0)
                {
                    labela.Location = new Point(brojevi.Next(0,forma.Width / 2), brojevi.Next(forma.Height / 2, forma.Height));
                    labela.Text = provjera.ToString();
                }

                if (provjera > 500 && provjera % 2 != 0)
                {
                    labela.Location = new Point(brojevi.Next(0,forma.Width / 2), brojevi.Next(0,forma.Height / 2));
                    labela.Text = provjera.ToString();
                }
                forma.Controls.Add(labela);


            }
        }
    }
}
