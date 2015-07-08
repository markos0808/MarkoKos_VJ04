using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPomnozi_Click(object sender, EventArgs e)
        {
            DateTime dt=new DateTime();
            dt=DateTime.Now;
            string[] brojevi = txt1.Text.Split(',');
            int a = int.Parse(brojevi[0]);
            int b = int.Parse(brojevi[1]);
            Mnozenje mul = new Mnozenje(a, b);
            txt2.Text = mul.izracun().ToString() + " " + Environment.NewLine + dt.ToString() + Environment.NewLine;
        }
    }
}
