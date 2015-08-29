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
    public partial class frmBrowseOrders : Form
    {
        public frmBrowseOrders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_DetailsBindingSource.EndEdit();
            this.ordersBindingSource.EndEdit();
            


        }

        private void frmBrowseOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);
            this.ordersTableAdapter.Fill(this.northwndDataSet.Orders);
        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.RowCount > 0)
            {
                int orderID = int.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.order_DetailsTableAdapter.FillByOrderID(this.northwndDataSet.Order_Details, orderID);
            }
        }


        private void spremiDetalj()
        {
            this.Validate();
            this.order_DetailsBindingSource.EndEdit();
            this.order_DetailsTableAdapter.Update(this.northwndDataSet);
        }



        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int brojRedova = order_DetailsDataGridView.Rows.Count;
            if (MessageBox.Show("Do you wish to delete this order?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) ;
            { //delete order details
                for (int i = 0; i < brojRedova; i++)
                {
                    order_DetailsDataGridView.Rows.RemoveAt(0);
                    spremiDetalj();
                }
                ordersDataGridView.Rows.RemoveAt(ordersDataGridView.CurrentRow.Index);
                spremiDetalj();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataCreateForms.frmCreateOrder frmOrder = new DataCreateForms.frmCreateOrder();
            frmOrder.ShowDialog();  // <- dialog nedozvoljava fokus drugih kontroli
        }

        private void editToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            int OrderID = int.Parse(ordersDataGridView.SelectedRows[0].Cells["OrderID"].Value.ToString());
            DataCreateForms.frmCreateOrder order = new DataCreateForms.frmCreateOrder(OrderID);
            order.ShowDialog();
        }

        private void ordersDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DataGridView.HitTestInfo hitTest = ordersDataGridView.HitTest(e.X, e.Y);
                ordersDataGridView.ClearSelection();
                ordersDataGridView.Rows[hitTest.RowIndex].Selected = true;

                cmsBrowseOrders.Show(ordersDataGridView, e.Location);
            }
        }
    }
}
