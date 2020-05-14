namespace Order_Winform
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.func_panel = new System.Windows.Forms.Panel();
            this.queryInput_textbox = new System.Windows.Forms.TextBox();
            this.queryByCustomerName_btn = new System.Windows.Forms.Button();
            this.queryByOrderNo_btn = new System.Windows.Forms.Button();
            this.exportOrder_btn = new System.Windows.Forms.Button();
            this.importOrder_btn = new System.Windows.Forms.Button();
            this.addOrder_btn = new System.Windows.Forms.Button();
            this.queryDisplay_panel = new System.Windows.Forms.Panel();
            this.orderItem_dataGridView = new System.Windows.Forms.DataGridView();
            this.productNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.query_dataGridView = new System.Windows.Forms.DataGridView();
            this.orderNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.orderItem_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delete_btn = new System.Windows.Forms.Button();
            this.func_panel.SuspendLayout();
            this.queryDisplay_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItem_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingNavigator)).BeginInit();
            this.order_bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItem_bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // func_panel
            // 
            this.func_panel.Controls.Add(this.delete_btn);
            this.func_panel.Controls.Add(this.queryInput_textbox);
            this.func_panel.Controls.Add(this.queryByCustomerName_btn);
            this.func_panel.Controls.Add(this.queryByOrderNo_btn);
            this.func_panel.Controls.Add(this.exportOrder_btn);
            this.func_panel.Controls.Add(this.importOrder_btn);
            this.func_panel.Controls.Add(this.addOrder_btn);
            this.func_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.func_panel.Location = new System.Drawing.Point(0, 0);
            this.func_panel.Name = "func_panel";
            this.func_panel.Size = new System.Drawing.Size(1184, 35);
            this.func_panel.TabIndex = 0;
            // 
            // queryInput_textbox
            // 
            this.queryInput_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.queryInput_textbox.Location = new System.Drawing.Point(545, 7);
            this.queryInput_textbox.Name = "queryInput_textbox";
            this.queryInput_textbox.Size = new System.Drawing.Size(389, 25);
            this.queryInput_textbox.TabIndex = 7;
            // 
            // queryByCustomerName_btn
            // 
            this.queryByCustomerName_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.queryByCustomerName_btn.Location = new System.Drawing.Point(940, 0);
            this.queryByCustomerName_btn.Name = "queryByCustomerName_btn";
            this.queryByCustomerName_btn.Size = new System.Drawing.Size(124, 35);
            this.queryByCustomerName_btn.TabIndex = 6;
            this.queryByCustomerName_btn.Text = "按客户名查询";
            this.queryByCustomerName_btn.UseVisualStyleBackColor = true;
            this.queryByCustomerName_btn.Click += new System.EventHandler(this.queryByCustomerName_btn_Click);
            // 
            // queryByOrderNo_btn
            // 
            this.queryByOrderNo_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.queryByOrderNo_btn.Location = new System.Drawing.Point(1064, 0);
            this.queryByOrderNo_btn.Name = "queryByOrderNo_btn";
            this.queryByOrderNo_btn.Size = new System.Drawing.Size(120, 35);
            this.queryByOrderNo_btn.TabIndex = 5;
            this.queryByOrderNo_btn.Text = "按订单号查询";
            this.queryByOrderNo_btn.UseVisualStyleBackColor = true;
            this.queryByOrderNo_btn.Click += new System.EventHandler(this.queryByOrderNo_btn_Click);
            // 
            // exportOrder_btn
            // 
            this.exportOrder_btn.Location = new System.Drawing.Point(243, 5);
            this.exportOrder_btn.Name = "exportOrder_btn";
            this.exportOrder_btn.Size = new System.Drawing.Size(75, 30);
            this.exportOrder_btn.TabIndex = 4;
            this.exportOrder_btn.Text = "导出";
            this.exportOrder_btn.UseVisualStyleBackColor = true;
            this.exportOrder_btn.Click += new System.EventHandler(this.exportOrder_btn_Click);
            // 
            // importOrder_btn
            // 
            this.importOrder_btn.Location = new System.Drawing.Point(162, 6);
            this.importOrder_btn.Name = "importOrder_btn";
            this.importOrder_btn.Size = new System.Drawing.Size(75, 30);
            this.importOrder_btn.TabIndex = 3;
            this.importOrder_btn.Text = "导入";
            this.importOrder_btn.UseVisualStyleBackColor = true;
            this.importOrder_btn.Click += new System.EventHandler(this.importOrder_btn_Click);
            // 
            // addOrder_btn
            // 
            this.addOrder_btn.Location = new System.Drawing.Point(81, 5);
            this.addOrder_btn.Name = "addOrder_btn";
            this.addOrder_btn.Size = new System.Drawing.Size(75, 30);
            this.addOrder_btn.TabIndex = 0;
            this.addOrder_btn.Text = "添加";
            this.addOrder_btn.UseVisualStyleBackColor = true;
            this.addOrder_btn.Click += new System.EventHandler(this.addOrder_btn_Click);
            // 
            // queryDisplay_panel
            // 
            this.queryDisplay_panel.Controls.Add(this.orderItem_dataGridView);
            this.queryDisplay_panel.Controls.Add(this.order_bindingNavigator);
            this.queryDisplay_panel.Controls.Add(this.query_dataGridView);
            this.queryDisplay_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDisplay_panel.Location = new System.Drawing.Point(0, 35);
            this.queryDisplay_panel.Name = "queryDisplay_panel";
            this.queryDisplay_panel.Size = new System.Drawing.Size(1184, 640);
            this.queryDisplay_panel.TabIndex = 1;
            // 
            // orderItem_dataGridView
            // 
            this.orderItem_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderItem_dataGridView.AutoGenerateColumns = false;
            this.orderItem_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItem_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNoDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn,
            this.productSumDataGridViewTextBoxColumn});
            this.orderItem_dataGridView.DataMember = "orderItems";
            this.orderItem_dataGridView.DataSource = this.order_bindingSource;
            this.orderItem_dataGridView.Location = new System.Drawing.Point(501, 8);
            this.orderItem_dataGridView.Name = "orderItem_dataGridView";
            this.orderItem_dataGridView.RowHeadersWidth = 51;
            this.orderItem_dataGridView.RowTemplate.Height = 27;
            this.orderItem_dataGridView.Size = new System.Drawing.Size(680, 601);
            this.orderItem_dataGridView.TabIndex = 2;
            // 
            // productNoDataGridViewTextBoxColumn
            // 
            this.productNoDataGridViewTextBoxColumn.DataPropertyName = "productNo";
            this.productNoDataGridViewTextBoxColumn.HeaderText = "productNo";
            this.productNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNoDataGridViewTextBoxColumn.Name = "productNoDataGridViewTextBoxColumn";
            this.productNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "productAmount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "productAmount";
            this.productAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            this.productAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // productSumDataGridViewTextBoxColumn
            // 
            this.productSumDataGridViewTextBoxColumn.DataPropertyName = "productSum";
            this.productSumDataGridViewTextBoxColumn.HeaderText = "productSum";
            this.productSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productSumDataGridViewTextBoxColumn.Name = "productSumDataGridViewTextBoxColumn";
            this.productSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.productSumDataGridViewTextBoxColumn.Width = 125;
            // 
            // order_bindingSource
            // 
            this.order_bindingSource.DataSource = typeof(Order_Console.Order);
            // 
            // order_bindingNavigator
            // 
            this.order_bindingNavigator.AddNewItem = null;
            this.order_bindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.order_bindingNavigator.BindingSource = this.order_bindingSource;
            this.order_bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.order_bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.order_bindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.order_bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.order_bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this.order_bindingNavigator.Location = new System.Drawing.Point(69, 613);
            this.order_bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order_bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order_bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order_bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order_bindingNavigator.Name = "order_bindingNavigator";
            this.order_bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order_bindingNavigator.Size = new System.Drawing.Size(266, 27);
            this.order_bindingNavigator.TabIndex = 1;
            this.order_bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
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
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // query_dataGridView
            // 
            this.query_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.query_dataGridView.AutoGenerateColumns = false;
            this.query_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.query_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn1,
            this.orderTimeDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn1,
            this.orderSumDataGridViewTextBoxColumn1});
            this.query_dataGridView.DataSource = this.order_bindingSource;
            this.query_dataGridView.Location = new System.Drawing.Point(3, 8);
            this.query_dataGridView.Name = "query_dataGridView";
            this.query_dataGridView.RowHeadersWidth = 51;
            this.query_dataGridView.RowTemplate.Height = 27;
            this.query_dataGridView.Size = new System.Drawing.Size(530, 601);
            this.query_dataGridView.TabIndex = 0;
            // 
            // orderNoDataGridViewTextBoxColumn1
            // 
            this.orderNoDataGridViewTextBoxColumn1.DataPropertyName = "orderNo";
            this.orderNoDataGridViewTextBoxColumn1.HeaderText = "orderNo";
            this.orderNoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderNoDataGridViewTextBoxColumn1.Name = "orderNoDataGridViewTextBoxColumn1";
            this.orderNoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderTimeDataGridViewTextBoxColumn1
            // 
            this.orderTimeDataGridViewTextBoxColumn1.DataPropertyName = "orderTime";
            this.orderTimeDataGridViewTextBoxColumn1.HeaderText = "orderTime";
            this.orderTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn1.Name = "orderTimeDataGridViewTextBoxColumn1";
            this.orderTimeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn1
            // 
            this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn1.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
            this.customerNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderSumDataGridViewTextBoxColumn1
            // 
            this.orderSumDataGridViewTextBoxColumn1.DataPropertyName = "orderSum";
            this.orderSumDataGridViewTextBoxColumn1.HeaderText = "orderSum";
            this.orderSumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderSumDataGridViewTextBoxColumn1.Name = "orderSumDataGridViewTextBoxColumn1";
            this.orderSumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderSumDataGridViewTextBoxColumn1.Width = 125;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // orderItem_bindingSource
            // 
            this.orderItem_bindingSource.DataMember = "orderItems";
            this.orderItem_bindingSource.DataSource = typeof(Order_Console.Order);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(324, 5);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(84, 28);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "删除";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 675);
            this.Controls.Add(this.queryDisplay_panel);
            this.Controls.Add(this.func_panel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.func_panel.ResumeLayout(false);
            this.func_panel.PerformLayout();
            this.queryDisplay_panel.ResumeLayout(false);
            this.queryDisplay_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderItem_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_bindingNavigator)).EndInit();
            this.order_bindingNavigator.ResumeLayout(false);
            this.order_bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItem_bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel func_panel;
        private System.Windows.Forms.Button queryByCustomerName_btn;
        private System.Windows.Forms.Button queryByOrderNo_btn;
        private System.Windows.Forms.Button exportOrder_btn;
        private System.Windows.Forms.Button importOrder_btn;
        private System.Windows.Forms.Button addOrder_btn;
        private System.Windows.Forms.Panel queryDisplay_panel;
        private System.Windows.Forms.DataGridView query_dataGridView;
        private System.Windows.Forms.BindingSource order_bindingSource;
        private System.Windows.Forms.TextBox queryInput_textbox;
        private System.Windows.Forms.BindingNavigator order_bindingNavigator;
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
        private System.Windows.Forms.BindingSource orderItem_bindingSource;
        private System.Windows.Forms.DataGridView orderItem_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button delete_btn;
    }
}

