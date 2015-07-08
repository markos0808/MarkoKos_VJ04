using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z39
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPovecaj_Click(object sender, EventArgs e)
        {
            Povecaj pov = new Povecaj();
            pov.povecaj(this);

        }

        private void btnSmanji_Click(object sender, EventArgs e)
        {
            Minus min = new Minus();
            min.smanji(this);
        }

        private void lblTekst_Click(object sender, EventArgs e)
        {
            Provjera pr = new Provjera();
            pr.promjenaTeksta(this);

        }
    }
}
