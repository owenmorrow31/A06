namespace A06
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label numberOfOrdersLabel;
            System.Windows.Forms.Label totalDetailLinesLabel;
            System.Windows.Forms.Label totalPurchasesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.custOrdProdDataSet = new A06.CustOrdProdDataSet();
            this.customerinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerinformationTableAdapter = new A06.CustOrdProdDataSetTableAdapters.customerinformationTableAdapter();
            this.tableAdapterManager = new A06.CustOrdProdDataSetTableAdapters.TableAdapterManager();
            this.customerinformationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerinformationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtNumOrders = new System.Windows.Forms.TextBox();
            this.txtTotalDetails = new System.Windows.Forms.TextBox();
            this.txtTotalPurchases = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new A06.CustOrdProdDataSetTableAdapters.OrderDetailsTableAdapter();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderItemDetailsTableAdapter = new A06.CustOrdProdDataSetTableAdapters.OrderItemDetailsTableAdapter();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnExcelReport = new System.Windows.Forms.Button();
            fullNameLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            numberOfOrdersLabel = new System.Windows.Forms.Label();
            totalDetailLinesLabel = new System.Windows.Forms.Label();
            totalPurchasesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.custOrdProdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinformationBindingNavigator)).BeginInit();
            this.customerinformationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(47, 91);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(71, 16);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name:";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(35, 63);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(83, 16);
            customerIDLabel.TabIndex = 4;
            customerIDLabel.Text = "Customer ID:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(86, 119);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(32, 16);
            cityLabel.TabIndex = 5;
            cityLabel.Text = "City:";
            // 
            // numberOfOrdersLabel
            // 
            numberOfOrdersLabel.AutoSize = true;
            numberOfOrdersLabel.Location = new System.Drawing.Point(0, 151);
            numberOfOrdersLabel.Name = "numberOfOrdersLabel";
            numberOfOrdersLabel.Size = new System.Drawing.Size(118, 16);
            numberOfOrdersLabel.TabIndex = 7;
            numberOfOrdersLabel.Text = "Number Of Orders:";
            // 
            // totalDetailLinesLabel
            // 
            totalDetailLinesLabel.AutoSize = true;
            totalDetailLinesLabel.Location = new System.Drawing.Point(4, 180);
            totalDetailLinesLabel.Name = "totalDetailLinesLabel";
            totalDetailLinesLabel.Size = new System.Drawing.Size(114, 16);
            totalDetailLinesLabel.TabIndex = 9;
            totalDetailLinesLabel.Text = "Total Detail Lines:";
            // 
            // totalPurchasesLabel
            // 
            totalPurchasesLabel.AutoSize = true;
            totalPurchasesLabel.Location = new System.Drawing.Point(10, 211);
            totalPurchasesLabel.Name = "totalPurchasesLabel";
            totalPurchasesLabel.Size = new System.Drawing.Size(108, 16);
            totalPurchasesLabel.TabIndex = 11;
            totalPurchasesLabel.Text = "Total Purchases:";
            // 
            // custOrdProdDataSet
            // 
            this.custOrdProdDataSet.DataSetName = "CustOrdProdDataSet";
            this.custOrdProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerinformationBindingSource
            // 
            this.customerinformationBindingSource.DataMember = "customerinformation";
            this.customerinformationBindingSource.DataSource = this.custOrdProdDataSet;
            // 
            // customerinformationTableAdapter
            // 
            this.customerinformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = A06.CustOrdProdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerinformationBindingNavigator
            // 
            this.customerinformationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerinformationBindingNavigator.BindingSource = this.customerinformationBindingSource;
            this.customerinformationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerinformationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerinformationBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.customerinformationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerinformationBindingNavigatorSaveItem});
            this.customerinformationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerinformationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerinformationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerinformationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerinformationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerinformationBindingNavigator.Name = "customerinformationBindingNavigator";
            this.customerinformationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerinformationBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.customerinformationBindingNavigator.TabIndex = 0;
            this.customerinformationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // customerinformationBindingNavigatorSaveItem
            // 
            this.customerinformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerinformationBindingNavigatorSaveItem.Enabled = false;
            this.customerinformationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerinformationBindingNavigatorSaveItem.Image")));
            this.customerinformationBindingNavigatorSaveItem.Name = "customerinformationBindingNavigatorSaveItem";
            this.customerinformationBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.customerinformationBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // txtFullName
            // 
            this.txtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerinformationBindingSource, "FullName", true));
            this.txtFullName.Location = new System.Drawing.Point(124, 88);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerinformationBindingSource, "CustomerID", true));
            this.txtCustomerID.Location = new System.Drawing.Point(124, 60);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txtCustomerID.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerinformationBindingSource, "City", true));
            this.txtCity.Location = new System.Drawing.Point(124, 116);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 6;
            // 
            // txtNumOrders
            // 
            this.txtNumOrders.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerinformationBindingSource, "NumberOfOrders", true));
            this.txtNumOrders.Location = new System.Drawing.Point(124, 148);
            this.txtNumOrders.Name = "txtNumOrders";
            this.txtNumOrders.Size = new System.Drawing.Size(100, 22);
            this.txtNumOrders.TabIndex = 8;
            // 
            // txtTotalDetails
            // 
            this.txtTotalDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerinformationBindingSource, "TotalDetailLines", true));
            this.txtTotalDetails.Location = new System.Drawing.Point(124, 177);
            this.txtTotalDetails.Name = "txtTotalDetails";
            this.txtTotalDetails.Size = new System.Drawing.Size(100, 22);
            this.txtTotalDetails.TabIndex = 10;
            // 
            // txtTotalPurchases
            // 
            this.txtTotalPurchases.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerinformationBindingSource, "TotalPurchases", true));
            this.txtTotalPurchases.Location = new System.Drawing.Point(124, 208);
            this.txtTotalPurchases.Name = "txtTotalPurchases";
            this.txtTotalPurchases.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPurchases.TabIndex = 12;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.custOrdProdDataSet;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvOrders.DataSource = this.orderDetailsBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(104, 250);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(589, 323);
            this.dgvOrders.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateOrdered";
            this.dataGridViewTextBoxColumn2.HeaderText = "DateOrdered";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "TotalAmount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumberOfDistinctItems";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumberOfDistinctItems";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalQuantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "TotalQuantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // orderItemDetailsBindingSource
            // 
            this.orderItemDetailsBindingSource.DataMember = "OrderItemDetails";
            this.orderItemDetailsBindingSource.DataSource = this.custOrdProdDataSet;
            // 
            // orderItemDetailsTableAdapter
            // 
            this.orderItemDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AutoGenerateColumns = false;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvOrderItems.DataSource = this.orderItemDetailsBindingSource;
            this.dgvOrderItems.Location = new System.Drawing.Point(13, 607);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 24;
            this.dgvOrderItems.Size = new System.Drawing.Size(680, 284);
            this.dgvOrderItems.TabIndex = 14;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn8.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn9.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn10.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TotalCost";
            this.dataGridViewTextBoxColumn11.HeaderText = "TotalCost";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // btnExcelReport
            // 
            this.btnExcelReport.Location = new System.Drawing.Point(524, 203);
            this.btnExcelReport.Name = "btnExcelReport";
            this.btnExcelReport.Size = new System.Drawing.Size(129, 23);
            this.btnExcelReport.TabIndex = 15;
            this.btnExcelReport.Text = "Excel Report";
            this.btnExcelReport.UseVisualStyleBackColor = true;
            this.btnExcelReport.Click += new System.EventHandler(this.btnExcelReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 925);
            this.Controls.Add(this.btnExcelReport);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(totalPurchasesLabel);
            this.Controls.Add(this.txtTotalPurchases);
            this.Controls.Add(totalDetailLinesLabel);
            this.Controls.Add(this.txtTotalDetails);
            this.Controls.Add(numberOfOrdersLabel);
            this.Controls.Add(this.txtNumOrders);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.customerinformationBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.custOrdProdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerinformationBindingNavigator)).EndInit();
            this.customerinformationBindingNavigator.ResumeLayout(false);
            this.customerinformationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustOrdProdDataSet custOrdProdDataSet;
        private System.Windows.Forms.BindingSource customerinformationBindingSource;
        private CustOrdProdDataSetTableAdapters.customerinformationTableAdapter customerinformationTableAdapter;
        private CustOrdProdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerinformationBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton customerinformationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtNumOrders;
        private System.Windows.Forms.TextBox txtTotalDetails;
        private System.Windows.Forms.TextBox txtTotalPurchases;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private CustOrdProdDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource orderItemDetailsBindingSource;
        private CustOrdProdDataSetTableAdapters.OrderItemDetailsTableAdapter orderItemDetailsTableAdapter;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnExcelReport;
    }
}

