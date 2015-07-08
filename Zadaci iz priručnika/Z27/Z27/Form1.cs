using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z27
{
    public partial class Form1 : Form
    {
        private Brojac broj { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.broj = new Brojac();
            this.btnKlik.Click += ClickHandler;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            this.broj.racunaj(this);
            this.lblbrojacKlikova.Text = this.broj.brojac.ToString();
        }
    }
}
