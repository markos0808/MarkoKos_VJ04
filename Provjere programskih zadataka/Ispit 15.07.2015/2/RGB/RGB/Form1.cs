using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB
{
    public partial class frmMain : Form
    {
        List<MyColor> color = new List<MyColor>();

        public frmMain()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {          
            int prvi = (int)nudRed.Value;
            int drugi = (int)nudGreen.Value;
            int treci = (int)nudBlue.Value;
            string cetvrti = txtName.Text;

            MyColor boja = new MyColor(this, prvi, drugi, treci, cetvrti);
            color.Add(boja);
            BindingSource bs = new BindingSource(color, null);
            dgvVrijednosti.DataSource = bs;                                                      
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            int prvi = (int)nudRed.Value;
            int drugi = (int)nudGreen.Value;
            int treci = (int)nudBlue.Value;
            string cetvrti = txtName.Text;
            MyColor moja = new MyColor(this, prvi, drugi, treci, cetvrti);
            panelBoja.BackColor = moja.FromArgb2(this, prvi, drugi, treci, cetvrti);
          
        }

        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            int prvi = (int)nudRed.Value;
            int drugi = (int)nudGreen.Value;
            int treci = (int)nudBlue.Value;
            string cetvrti = txtName.Text;
            MyColor moja = new MyColor(this, prvi, drugi, treci, cetvrti);
            panelBoja.BackColor = moja.FromArgb2(this, prvi, drugi, treci, cetvrti);
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            int prvi = (int)nudRed.Value;
            int drugi = (int)nudGreen.Value;
            int treci = (int)nudBlue.Value;
            string cetvrti = txtName.Text;
            MyColor moja = new MyColor(this, prvi, drugi, treci, cetvrti);
            panelBoja.BackColor = moja.FromArgb2(this, prvi, drugi, treci, cetvrti);
        }

        private void dgvVrijednosti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVrijednosti.SelectedRows.Count > 0)
            {
                int prvi=(int)dgvVrijednosti.SelectedCells[0].Value;
                int drugi=(int)dgvVrijednosti.SelectedCells[1].Value;
                int treci=(int)dgvVrijednosti.SelectedCells[2].Value;
                string cetvrti=dgvVrijednosti.SelectedCells[3].Value.ToString();
                MyColor kolor = dgvVrijednosti.SelectedRows[0].DataBoundItem as MyColor;
                panelBoja.BackColor = kolor.FromArgb2(this, prvi, drugi, treci, cetvrti);
            }
        }
    }
}
