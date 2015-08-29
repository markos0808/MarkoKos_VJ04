using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija.DataCreateForms
{
    public partial class frmCreateDetails : Form
    {

        public int OrderId { get; set; }
        public bool Editing { get; set; }


        public frmCreateDetails(int orderId)
        {
            InitializeComponent();
            this.OrderId = orderId;
            Editing = false;
        }

        private void order_DetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            SaveCurrent();
        }

        private void frmCreateDetails_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.FillByOrderID(this.northwndDataSet.Order_Details, OrderId);
            if (!Editing)
            {
                addNewEntry();
            }

        }

        private void btnListaSvihProizvoda_Click(object sender, EventArgs e)
        {
            DataBrowseForms.frmBrowseProducts frmProducts = new DataBrowseForms.frmBrowseProducts();
            frmProducts.ShowDialog();

            productIDTextBox.Text = frmProducts.ProductID.ToString();
            unitPriceTextBox.Text = frmProducts.UnitPrice.ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            addNewEntry();
        }

        private void addNewEntry()
        {
            try
            {
                this.order_DetailsBindingSource.AddNew();
                orderIDTextBox.Text = OrderId.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void SaveCurrent()
        {
            this.Validate();
            this.order_DetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);
        }
    }
}
