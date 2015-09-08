using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontakt
{
    public partial class FrmGlavna : Form
    {
        List<Contact> kontakti = new List<Contact>();
        public FrmGlavna()
        {
            InitializeComponent();
        }


        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            UkljuciKontrole(false);
        }


        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            UkljuciKontrole(true);
            PrikaziKontakt(null);
        }


        private void btnSpremi_Click(object sender, EventArgs e)
        {       
            
            Contact cont = new Contact();
            cont.Ime = txtIme.Text;
            cont.Prezime = txtPrezime.Text;
            cont.Email = txtEmail.Text;
            cont.Telefon = txtTelefon.Text;
     
            kontakti.Add(cont);

            UkljuciKontrole(false);
            OsvjeziPrikaz(txtTrazi.Text);
        }


        private void listBoxPopisKontakata_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact odabrani = kontakti[listBoxPopisKontakata.SelectedIndex];
            UkljuciKontrole(false);
            PrikaziKontakt(odabrani);
        }


        private void UkljuciKontrole(bool ukljuci)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Enabled = ukljuci;
                }
            }
        }


        private void PrikaziKontakt(Contact kontakt)
        {
            if (kontakt != null)
            {
                txtIme.Text = kontakt.Ime;
                txtPrezime.Text = kontakt.Prezime;
                txtEmail.Text = kontakt.Email;
                txtTelefon.Text = kontakt.Telefon;
          
            }

            else
            {
                txtIme.Text = "";
                txtPrezime.Text = "";
                txtEmail.Text = "";
                txtTelefon.Text = "";
                cmbGrupa.Text = "Općenito";
            }
        }


        private void OsvjeziPrikaz(string trazi)
        {
            listBoxPopisKontakata.Items.Clear();
            bool ok;
            

            foreach (Contact item in kontakti)
            {
                ok = true;
                if (trazi != null && trazi != string.Empty)
                {
                    ok = false;
                    if (item.Ime.Contains(trazi) || item.Prezime.Contains(trazi) || item.Email.Contains(trazi) || item.Telefon.Contains(trazi))
                    {
                        ok = true;
                    }
                }

                if (ok)
                {
                    listBoxPopisKontakata.Items.Add(item.Ime + " " + item.Prezime);
                }
            }
        }


        private void OsvjeziPrikaz()
        {
            OsvjeziPrikaz(null);
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            OsvjeziPrikaz(txtTrazi.Text);
        }
    }
}