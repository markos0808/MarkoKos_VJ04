using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_2_Testiranje
{
    public partial class frmKrug : Form
    {
        public frmKrug()
        {
            InitializeComponent();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            float radius = float.Parse(txtRadius.Text);
            Krug krug = new Krug(radius);
            txtPovrsina.Text = krug.Povrsina().ToString();
            txtOpseg.Text = krug.Opseg().ToString();

        }

        private void frmKrug_Load(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
