using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proizvod
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();            
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwndDataSet.Suppliers);
            // TODO: This line of code loads data into the 'northwndDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwndDataSet.Products);

            this.dgvProducts.Sort(this.dgvProducts.Columns[1], ListSortDirection.Ascending);
            this.dgvSuppliers.Sort(this.dgvSuppliers.Columns[1], ListSortDirection.Ascending);
        }


        private void btnVerify_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (dgvProducts.SelectedRows.Count == 1 && dgvSuppliers.SelectedRows.Count == 1)
                {
                    int ID = int.Parse(dgvProducts.SelectedCells[2].Value.ToString());
                    int id = int.Parse(dgvSuppliers.SelectedCells[0].Value.ToString());

                    if (id == ID)
                    {
                        dgvProducts.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                        dgvSuppliers.CurrentRow.DefaultCellStyle.BackColor = Color.Green;
                    }

                    else if (id != ID)
                    {
                        dgvProducts.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                        dgvSuppliers.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
                    }
                }

                else
                {
                    if (MessageBox.Show("Nije odabrani red u svakoj tablici!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }
                    
                }
            }

            dgvProducts.ClearSelection();
            dgvSuppliers.ClearSelection();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }


            foreach (DataGridViewRow row in dgvSuppliers.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }

        }
    }
}
