using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija.DataBrowseForms
{
    public partial class frmBrowseProducts : Form
    {

        public int ProductID { get; set; }
        public float UnitPrice { get; set; }


        public frmBrowseProducts()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void frmBrowseProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);

        }

        private void productsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            this.ProductID=int.Parse(productsDataGridView["ProductIDColumn", productsDataGridView.CurrentRow.Index].Value.ToString());
            this.UnitPrice = float.Parse(productsDataGridView["UnitPriceColumn", productsDataGridView.CurrentRow.Index].Value.ToString());
        }
    }
}
