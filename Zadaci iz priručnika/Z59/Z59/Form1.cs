using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z59
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRezultat_Click(object sender, EventArgs e)
        {
            string[] brojevi = txtRacunaj.Text.Split('+');
            int a = int.Parse(brojevi[0]);
            int b = int.Parse(brojevi[1]);
            string rezultat = txtRacunaj.Text;
            txtRacunaj.Clear();

            Racun rac = new Racun(a, b);
            txtRacunaj.Text = rezultat + "=" + rac.Izracunaj().ToString();
        }
    }
}
