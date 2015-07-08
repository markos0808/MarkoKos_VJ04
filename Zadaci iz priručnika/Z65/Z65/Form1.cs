using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z65
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzracun_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            lvOtplata.Items.Clear();
            double iznos = 0;
            double rok = 0;
            if (!double.TryParse(txtIznos.Text, out iznos))
            {
                MessageBox.Show("Neispravni iznos kredita!");
                return;
            }

            if (!double.TryParse(txtRok.Text, out rok))
            {
                MessageBox.Show("Neispravni format za broj mjeseci!");
                return;
            }

            Kredit kredit = new Kredit(iznos, rok);
            kredit.iznosZaOtplatu(this);
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtIznos.Text))
            {
                MessageBox.Show("Polje za iznos kredita ne smije biti prazno!");
                return false;
            }

            if (string.IsNullOrEmpty(txtRok.Text))
            {
                MessageBox.Show("Polje za unos broja mjeseci otplate kredita ne smije biti prazno!");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvOtplata.View = View.Details;
            lvOtplata.GridLines = true;
            lvOtplata.FullRowSelect = true;
            lvOtplata.Columns.Add("Redni broj mjeseca");
            lvOtplata.Columns.Add("Mjesečna rata");
            lvOtplata.Columns.Add("Preostalo duga");
        }
    }
}
