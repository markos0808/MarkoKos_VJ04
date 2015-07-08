using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z65
{
    class Kredit
    {
        double iznos, rok;

        public Kredit(double a, double b)
        {
            this.iznos = a;
            this.rok = b;
        }

        public void iznosZaOtplatu(Form1 forma)
        {
            double iznosZaOtplatu=iznos+(double)(1+(forma.numKamata.Value/100));
            double mjesecnaRata = iznosZaOtplatu / rok;
            double preostaloDuga = iznosZaOtplatu;

            for (int i = 0; i < rok; i++)
            {
                preostaloDuga = preostaloDuga - mjesecnaRata;
                forma.lvOtplata.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), mjesecnaRata.ToString("F2"), preostaloDuga.ToString("F2") }));
            }
        }
    }
}
