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
    public partial class frmCreateOrder : Form
    {
        private bool Editing{get; set;}
        public int OrderID { get; set; }


        public frmCreateOrder()
        {
            InitializeComponent();
            OrderID = -10; //mora biti postavljena pa koristimo neutralnu vrijednost -10
        }


        public frmCreateOrder(int OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
            this.Editing = true;
        }



        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);

        }

        private void frmCreateOrder_Load(object sender, EventArgs e)
        {
          
            this.employeesTableAdapter.Fill(this.northwndDataSet.Employees);
            this.customersTableAdapter.Fill(this.northwndDataSet.Customers);
            
            if (this.OrderID != -10)
            {
                this.ordersTableAdapter.FillByOrderID(this.northwndDataSet.Orders, this.OrderID); //ako je ažuriranje popuni prema ID-u
            }

            else
            {
                ordersBindingSource.AddNew(); //ako nije ažuriranje 
            }
            
            
            
        }

        private void btnAddDetails_MouseUp(object sender, MouseEventArgs e)
        {
            createNewEntry();
            int OrderId = (int)northwndDataSet.Orders.Rows[0]["OrderID"];
            //frmCreateDetails ćemo kreirati nešto kasnije, no ovdje prosljedimo ID
            frmCreateDetails frmCreateDetails = new frmCreateDetails(OrderId);
            if (Editing) frmCreateDetails.Editing = true;
            frmCreateDetails.ShowDialog();
        }

        private void btnCreate_MouseUp(object sender, MouseEventArgs e)
        {
            createNewEntry();
        }

        private void createNewEntry()
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwndDataSet);
        }

        private void btnClear_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
