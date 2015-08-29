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
    public partial class FrmPopisStudenata : Form
    {
        public FrmPopisStudenata()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb za dodavanje novog tima.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNoviTim_Click(object sender, EventArgs e)
        {
            FrmNoviTim forma = new FrmNoviTim();
            forma.ShowDialog();
            PrikaziTimove();
        }

        /// <summary>
        /// Rukuje događajem klika na gumb za dodavanje novog studenta.
        /// </summary>
        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            FrmNoviStudent forma = new FrmNoviStudent(timBindingSource.Current as Tim);
            forma.ShowDialog();
            PrikaziStudente(timBindingSource.Current as Tim);
        }

        #region Methods

        /// <summary>
        /// Dohvaća listu svih timova iz kolekcije timova u kontekstu, te ih prikazuje
        /// u DataGridView-u.
        /// </summary>
        private void PrikaziTimove()
        {
            BindingList<Tim> listaTimova = null;
            using (var db = new EvidencijaStudenataEntities4())
            {
                listaTimova = new BindingList<Tim>(db.Timovi.ToList());
            }
            timBindingSource.DataSource = listaTimova;
        }

        /// <summary>
        /// Dohvaća listu studenata proslijeđenog tima te ih prikazuje u DataGridView-u.
        /// </summary>
        /// <param name="tim">Tim čije studente želimo prikazati.</param>
        private void PrikaziStudente(Tim tim)
        {
            BindingList<Student> listaStudenata = null;
            using (var db = new EvidencijaStudenataEntities4())
            {
                db.Timovi.Attach(tim);
                listaStudenata = new BindingList<Student>(tim.Studenti.ToList<Student>());
            }
            studentBindingSource.DataSource = listaStudenata;
        }

        /// <summary>
        /// Rukuje događajem pokretanja forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPopisStudenata_Load(object sender, EventArgs e)
        {
            PrikaziTimove();
            PrikaziStudente(timBindingSource.Current as Tim);
        }

        #endregion

        /// <summary>
        /// Rukuje događajem promjene selektiranog retka u tablici.
        /// </summary>
        private void dgvTimovi_SelectionChanged(object sender, EventArgs e)
        {
            Tim selektiraniTim = timBindingSource.Current as Tim;
            if (selektiraniTim != null)
            {
                PrikaziStudente(selektiraniTim);
            }
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Izmijeni.
        /// </summary>
        private void btnIzmijeniTim_Click(object sender, EventArgs e)
        {
            Tim selektiraniTim = timBindingSource.Current as Tim;
            if (selektiraniTim != null)
            {
                FrmNoviTim forma = new FrmNoviTim(selektiraniTim);
                forma.ShowDialog();
                PrikaziTimove();
            }
        }

        /// <summary>
        /// Rukuje događajem klika na gumb za brisanje tima.
        /// </summary>
        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            Tim selektiraniTim = timBindingSource.Current as Tim;
            if (selektiraniTim != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new EvidencijaStudenataEntities4())
                    {
                        //Registriramo tim.
                        db.Timovi.Attach(selektiraniTim);   
                        //Provjeravamo da li tim sadrži studente.
                        if (selektiraniTim.Studenti.Count == 0)
                        {
                            db.Timovi.Remove(selektiraniTim);   //Brišemo tim iz kolekcije.
                            db.SaveChanges();    //Spremamo promjene u bazu.
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati tim koji sadrži studente!");
                        }
                    }

                    PrikaziTimove();    //Ažuriramo popis timova.
                }
            }
        }
        
    }
}
