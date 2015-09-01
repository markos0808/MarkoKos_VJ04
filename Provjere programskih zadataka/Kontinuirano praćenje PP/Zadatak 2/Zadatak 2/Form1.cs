using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_2
{
    public partial class Form1 : Form
    {
        List<Measurement> lista = new List<Measurement>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivMjerenja.Text;
            int temperatura = int.Parse(txtTemperatura.Text);
            DateTime vrijeme = dtpVrijeme.Value;

            Measurement mjera = new Measurement(naziv, temperatura, vrijeme);
            lista.Add(mjera);
            CalculateAverage();
            
            BindingSource bs = new BindingSource(lista, null);
            dgvStatistika.DataSource = bs;                 
        }

        private void CalculateAverage()
        {
            int brojac = lista.Count;
            int suma = 0;
            int av = 0;

            foreach (Measurement m in lista)
            {
                suma = suma + m.Temperature;
            }
            
            av = suma / brojac;
            lblRez.Text = av.ToString();

            if (av > 0)
            {
                lblRez.ForeColor = Color.Red;
            }

            else
            {
                lblRez.ForeColor = Color.Blue;
            }
        }
    }
}
