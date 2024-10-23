using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;




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


        




        private void btnExcelReport_Click(object sender, EventArgs e)
        {
            String strConn = "Data Source=OWENSHP\\NEWSERVER;Initial Catalog=CustOrdProd;Integrated Security=True"; // Your connection string
            SqlConnection cnnOrder;
            SqlCommand cmdOrder;
            SqlDataReader rdrOrder;
            String strSQL;

            try
            {
                // SQL query to get the order information
                strSQL = "Select oi.OrderId, oi.ProductId, p.ProductName, oi.Quantity, oi.UnitPrice * oi.Quantity as [Charge] " +
                   "From (OrderItem oi join Product p on oi.ProductId = p.Id) join [Order] o on oi.OrderId = o.Id " +
                   "Where o.CustomerId = " + txtCustomerID.Text + " " +
                   "Order by oi.OrderId asc, oi.ProductId asc";

                // Open the database connection and then run the query
                cnnOrder = new SqlConnection(strConn);
                cnnOrder.Open();
                cmdOrder = new SqlCommand(strSQL, cnnOrder);
                rdrOrder = cmdOrder.ExecuteReader();

                // Check if there are any rows returned 
                if (!rdrOrder.HasRows)
                {
                    MessageBox.Show("No rows found.");
                    cnnOrder.Close();
                    return;  // Stop if there was no data found 
                }

                // Create the Excel app
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;
                Workbook workbook = excelApp.Workbooks.Add();
                Worksheet worksheet1 = workbook.Worksheets[1];

                // Create the title and customer info
                worksheet1.Cells[1, "A"] = "CUSTOMER REPORT";
                worksheet1.Cells[2, "A"] = "Customer ID";
                worksheet1.Cells[2, "B"] = txtCustomerID.Text;
                worksheet1.Cells[2, "C"] = "Customer Name";
                worksheet1.Cells[2, "D"] = txtCustomerID.Text;

                // Set column headers
                worksheet1.Cells[4, "A"] = "Order ID";
                worksheet1.Cells[4, "B"] = "Product ID";
                worksheet1.Cells[4, "C"] = "Product Name";
                worksheet1.Cells[4, "D"] = "Quantity";
                worksheet1.Cells[4, "E"] = "Charge";

                // Setting the rows where the order details will begin
                int row = 5;
                double totalCharge = 0;

                // loop throught the data and fill Excel sheet
                while (rdrOrder.Read())
                {
                    worksheet1.Cells[row, "A"] = rdrOrder["OrderId"].ToString();
                    worksheet1.Cells[row, "B"] = rdrOrder["ProductId"].ToString();
                    worksheet1.Cells[row, "C"] = rdrOrder["ProductName"].ToString();
                    worksheet1.Cells[row, "D"] = rdrOrder["Quantity"].ToString();
                    worksheet1.Cells[row, "E"] = String.Format("{0:C2}", rdrOrder["Charge"]);  // Format as currency

                    //Add to the total cost
                    totalCharge += Convert.ToDouble(rdrOrder["Charge"]);
                    row++; // move to the next row
                }

                // Add total cost row at the bottom
                worksheet1.Cells[row, "D"] = "Total Cost:";
                worksheet1.Cells[row, "E"] = String.Format("{0:C2}", totalCharge);

                // Add footer with your name
                worksheet1.Cells[row + 2, "A"] = "Created by Owen and Cristian";  

                // Autofit columns to fit the content
                worksheet1.Columns.AutoFit();

                // Close SQL reader and connection
                rdrOrder.Close();
                cnnOrder.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
