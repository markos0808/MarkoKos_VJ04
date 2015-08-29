using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V5G9
{
    public partial class FrmTrokut : Form
    {
        public FrmTrokut()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float a, b, gama;
            float.TryParse(txtA.Text, out a);
            float.TryParse(txtB.Text, out b);
            float.TryParse(txtGama.Text, out gama);

            Trokut t = new Trokut(TipTrokuta.Raznostranični);
            t.A = a;
            t.B = b;
            t.Gama = gama;

            t.IzracunajC();

            MessageBox.Show("Dužina stranice C = " + t.C.ToString(), "Rješenje");
        }
    }
}
