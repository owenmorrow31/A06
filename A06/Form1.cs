using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace A06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'custOrdProdDataSet.OrderItemDetails' table. You can move, or remove it, as needed.
                this.orderItemDetailsTableAdapter.Fill(this.custOrdProdDataSet.OrderItemDetails);
                // TODO: This line of code loads data into the 'custOrdProdDataSet.OrderDetails' table. You can move, or remove it, as needed.
                this.orderDetailsTableAdapter.Fill(this.custOrdProdDataSet.OrderDetails);
                // TODO: This line of code loads data into the 'custOrdProdDataSet.customerinformation' table. You can move, or remove it, as needed.
                this.customerinformationTableAdapter.Fill(this.custOrdProdDataSet.customerinformation);
            }
         catch (Exception ex)
            {
                MessageBox.Show("Error loading the data");
            }
        }


        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["OrderID"].Value);
                LoadOrderItemData(orderId);
            }
        }

        private void LoadOrderItemData(int orderId)
        {
           
            DataView orderItemView = new DataView(custOrdProdDataSet.OrderItemDetails);
            orderItemView.RowFilter = $"OrderID = {orderId}";

            dgvOrderItems.DataSource = orderItemView;
        }

       





    }
}
