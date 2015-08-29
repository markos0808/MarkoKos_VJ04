using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2_4_EvidencijaStudenata
{
    public partial class NoviTim : Form
    {
        //Referenca na postojeći tim.
        private Tim tim = null;


        /// <summary>
        /// Konstruktor forme koji pozivamo kada kreiramo novi tim.
        /// </summary>
        public NoviTim()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Konstruktor forme koji pozivamo kada mijenjamo postojeći tim.
        /// </summary>
        /// <param name="odabraniTim"> Postojeći tim čije podatke mijenjam. </param>
        public NoviTim(Tim odabraniTim)
        {
            InitializeComponent();
            tim = odabraniTim;
        }


        /// <summary>
        /// Rukuje događajem pokretanja forme. Ako se radi o izmjeni postojećeg 
        /// tima, tada se kontrole popunjavaju s postojećim podacima.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoviTim_Load(object sender, EventArgs e)
        {
            txtOznakaTima.Focus();
            if (tim != null)
            {
                txtId.Text = tim.Id.ToString();
                txtOznakaTima.Text = tim.OznakaTima;
                txtNazivProjekta.Text = tim.NazivProjekta;
                txtOpisProjekta.Text = tim.OpisProjekta;
                txtNapomena.Text = tim.Napomena;
            }
        }



        /// <summary>
        /// Rukuje događajem klika na gumb btnSpremi. Mijenja podatke
        /// tima u skladu sa unesenim podacima na formi, te ih zapisuje u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (tim == null)
            {
                tim = new Tim();
            }
            tim.OznakaTima = txtOznakaTima.Text;
            tim.NazivProjekta = txtNazivProjekta.Text;
            tim.OpisProjekta = txtOpisProjekta.Text;
            tim.Napomena = txtNapomena.Text;
            tim.Spremi();
            this.Close();
        }



        /// <summary>
        /// Rukuje događajem klika na gumb btnOdustani. Zatvara formu bez spremanja podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }







    }
}
