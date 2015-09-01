using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string a = textBoxNazivDrzave.Text;
            int b = int.Parse(textBoxBrojStanovnika.Text);
            float c = float.Parse(textBoxStopaRasta.Text);
            Drzava drzava = new Drzava(a, b, c, this);
            
        }

   

        private void trackBarGodina_ValueChanged(object sender, EventArgs e)
        {
            labelRast.Text = trackBarGodina.Value.ToString();
            string a = textBoxNazivDrzave.Text;
            int b = int.Parse(textBoxBrojStanovnika.Text);
            float c = float.Parse(textBoxStopaRasta.Text);
            Drzava drzava = new Drzava(a, b, c, this);
            drzava.Izracunaj(this);
        }        
    }
}
