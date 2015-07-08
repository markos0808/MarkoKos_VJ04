using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z23
{
    public partial class Form1 : Form
    {
        private Broji broj { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.broj = new Broji();
            this.BackColor = broj.trenutnaBoja;
            this.btnKlik.Click += ClickHandler;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            this.broj.racunaj();
            this.btnKlik.Text = this.broj.brojac.ToString();
            this.BackColor = this.broj.trenutnaBoja;
        }
    }
}
