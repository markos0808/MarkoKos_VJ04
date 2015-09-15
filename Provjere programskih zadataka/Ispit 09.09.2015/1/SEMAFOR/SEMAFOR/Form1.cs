using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMAFOR
{
    public partial class Forma : Form
    {
        Semafor semafor = new Semafor();

        public Forma()
        {
            InitializeComponent();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            timer.Start();
        }


        public void OsvjeziPrikazSemafora()
        {
            picCrvena.BackColor = SystemColors.Control;
            picZuta.BackColor = SystemColors.Control;
            picZelena.BackColor = SystemColors.Control;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string stanje = semafor.DohvatiTrenutnoStanje();

            if (stanje == "Crveno")
            {
                OsvjeziPrikazSemafora();
                picCrvena.BackColor = Color.Red;
                semafor.PromijeniStanje();
            }

            else if (stanje == "Zuto")
            {
                OsvjeziPrikazSemafora();
                picZuta.BackColor = Color.Yellow;
                semafor.PromijeniStanje();
            }

            else if (stanje == "Zeleno")
            {
                OsvjeziPrikazSemafora();
                picZelena.BackColor = Color.Green;
                semafor.PromijeniStanje();
            }
        }

        private void Forma_Load(object sender, EventArgs e)
        {
            string st = semafor.DohvatiTrenutnoStanje();

            if (st == "Crveno")
            {
                picCrvena.BackColor = Color.Red;
            }
        }
    }
}
