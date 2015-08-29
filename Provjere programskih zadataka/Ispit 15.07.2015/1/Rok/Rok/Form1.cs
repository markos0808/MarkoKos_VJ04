using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rok
{
    public partial class frmIspitniRok : Form
    {

        List<IspitniRok> ispit = new List<IspitniRok>();
        public frmIspitniRok()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmUnosPitanja forma = new frmUnosPitanja();
            forma.ShowDialog();
        }

        private void btnKreirajRok_Click(object sender, EventArgs e)
        {
            string jedan = txtNazivPredmeta.Text;
            string dva = txtNazivIspita.Text;
            DateTime dt = dtpDatum.Value;

            IspitniRok rk = new IspitniRok(jedan, dva, dt);
            ispit.Add(rk);
            BindingSource bs = new BindingSource(ispit, null);
            dgvPitanja.DataSource = bs;
        }
    }
}
