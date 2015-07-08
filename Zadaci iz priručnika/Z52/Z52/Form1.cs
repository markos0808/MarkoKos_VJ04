using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnKreni.BackColor = Color.FromArgb(100, 100, 100);
        }

        int brojac = 0;

        private void btnKreni_Click(object sender, EventArgs e)
        {
            ++brojac;
            int max = int.Parse(txtVrijednost.Text);
            Klikovi klik = new Klikovi(brojac, max);
            klik.bojaGumba(this);
        }


    }
}
