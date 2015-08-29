using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab_2_4_EvidencijaStudenata
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Dohvaća listu timova uz pomoć statičke metode DohvatiTimove,
        /// te ih prikazuje u DataGridView kontroli.
        /// </summary>
        private void OsvjeziTimove()
        {
            List<Tim> listaTimova = Tim.DohvatiTimove();
            dgvTimovi.DataSource = listaTimova;
        }



        /// <summary>
        /// Rukuje događajem pokretanja forme, kada će se osvježiti prikaz timova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            OsvjeziTimove();
            
        }


        /// <summary>
        /// Rukuje događajem klika na gumb btnDodajTim. Otvara formu frmNoviTim 
        /// u kojoj se upisuju podaci, a nakon zatvaranja forme osvježava se prikaz timova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajTim_Click(object sender, EventArgs e)
        {
            NoviTim frmNoviTim = new NoviTim();
            frmNoviTim.ShowDialog();
            OsvjeziTimove();
        }



        /// <summary>
        /// Rukuje događajem klika na gumb btnIzmijeniTim. Dohvaća selektirani Tim
        /// iz DataGridView kontrole, prosljeđuje ga formi frmNoviTim i otvara formu.
        /// Nakon zatvaranja forme osvježava se popis timova.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmijeniTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                Tim odabraniTim = dgvTimovi.SelectedRows[0].DataBoundItem as Tim;
                NoviTim frmNoviTim = new NoviTim(odabraniTim);
                frmNoviTim.ShowDialog();
                OsvjeziTimove();
            }
        }




        /// <summary>
        /// Rukuje događajem klika na gumb btnObrisiTim. Dohvaća selektirani tim/timove iz 
        /// DataGridView kontrole, te ih briše. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTimovi.SelectedRows)
                {
                    Tim odabraniTim = row.DataBoundItem as Tim;
                    odabraniTim.Obrisi();
                }
            }
            OsvjeziTimove();
        }



        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            NoviStudent frmNoviStudent = new NoviStudent();
            frmNoviStudent.ShowDialog();
            
            
        }






        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmijeniStudenta_Click(object sender, EventArgs e)
        {
       
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
          
        }











    }
}
