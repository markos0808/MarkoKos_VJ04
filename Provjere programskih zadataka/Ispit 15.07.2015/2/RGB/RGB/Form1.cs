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
        List<MyColor> mojaBoja = new List<MyColor>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            panelPrikazBoje.BackColor = Color.FromArgb((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyColor mcolor = new MyColor((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value, txtName.Text);
            mojaBoja.Add(mcolor);

            BindingSource bs = new BindingSource(mojaBoja, null);
            dgvBoje.DataSource = bs;
        }

        private void dgvBoje_SelectionChanged(object sender, EventArgs e)
        {
            MyColor color = dgvBoje.CurrentRow.DataBoundItem as MyColor;
            panelPrikazBoje.BackColor = color.GetColor();
        }


    }
}
