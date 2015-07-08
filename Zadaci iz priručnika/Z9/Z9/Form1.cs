using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            string a = txtAdresa.Text;
            Ucitaj uc = new Ucitaj(a);
            uc.ucitavanjeStranice(webBrowser1);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Boja boja = new Boja();
            boja.uspjesnoUcitano(this);
        }


    }
}
