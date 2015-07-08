using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_1_EvidencijaStudenataX
{
    public partial class FrmNoviTim : Form
    {
        private Tim timZaIzmjenu;

        /// <summary>
        /// Konstruktor forme koji koristimo za kreiranje novog tima.
        /// </summary>
        public FrmNoviTim()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor forme koji koristimo za izmjenu postojećeg tima.
        /// </summary>
        /// <param name="tim">Tim koji treba izmijeniti.</param>
        public FrmNoviTim(Tim tim)
        {
            InitializeComponent();
            timZaIzmjenu = tim;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Rukuje događajem Load pokretanja forme.
        /// </summary>
        private void FrmNoviTim_Load(object sender, EventArgs e)
        {
            txtOznakaTima.Focus();
            if (timZaIzmjenu != null)
            {
                txtId.Text = timZaIzmjenu.Id.ToString();
                txtOznakaTima.Text = timZaIzmjenu.OznakaTima;
                txtNazivProjekta.Text = timZaIzmjenu.NazivProjekta;
                txtOpisProjekta.Text = timZaIzmjenu.OpisProjekta;
                txtNapomena.Text = timZaIzmjenu.Napomena;
            }
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Uredu.
        /// </summary>
        private void btnUredu_Click(object sender, EventArgs e)
        {
            using (var db = new EvidencijaStudenataEntities4())
            {
                if (timZaIzmjenu == null)
                {
                    //Kreiramo novi objekt klase Tim i popunjavamo ga
                    //podacima sa forme.
                    Tim tim = new Tim
                    {
                        OznakaTima = txtOznakaTima.Text,
                        NazivProjekta = txtNazivProjekta.Text,
                        OpisProjekta = txtOpisProjekta.Text,
                        Napomena = txtNapomena.Text
                    };

                    db.Timovi.Add(tim);     //Dodajemo tim u odgovarajuću kolekciju u kontekstu.
                    db.SaveChanges();       //Spremamo napravljene promjene u bazu podataka.
                }
                else   //Mijenjamo postojeći tim
                {
                    db.Timovi.Attach(timZaIzmjenu);     //registriramo prosljeđeni tim.

                    timZaIzmjenu.OznakaTima = txtOznakaTima.Text;
                    timZaIzmjenu.NazivProjekta = txtNazivProjekta.Text;
                    timZaIzmjenu.OpisProjekta = txtOpisProjekta.Text;
                    timZaIzmjenu.Napomena = txtNapomena.Text;

                    db.SaveChanges();   //Spremamo promjene u bazu.
                }
            }

            Close();
        }
    }
}
