namespace POS
{
    partial class POSForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtReceiptId;
        private System.Windows.Forms.Label lblReceiptId;
        private System.Windows.Forms.Label lblAvailableStock;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnNavMainMenu;
        private System.Windows.Forms.Button btnNavBackup;
        private System.Windows.Forms.Button btnNavSales;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Button btnNavDelivery;
        private System.Windows.Forms.Button btnNavMaintenance;
        private System.Windows.Forms.Label lblNavTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtReceiptId = new System.Windows.Forms.TextBox();
            this.lblReceiptId = new System.Windows.Forms.Label();
            this.lblAvailableStock = new System.Windows.Forms.Label();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnNavMainMenu = new System.Windows.Forms.Button();
            this.btnNavBackup = new System.Windows.Forms.Button();
            this.btnNavSales = new System.Windows.Forms.Button();
            this.btnNavInventory = new System.Windows.Forms.Button();
            this.btnNavDelivery = new System.Windows.Forms.Button();
            this.btnNavMaintenance = new System.Windows.Forms.Button();
            this.lblNavTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlNavigation.Controls.Add(this.btnNavMainMenu);
            this.pnlNavigation.Controls.Add(this.btnNavBackup);
            this.pnlNavigation.Controls.Add(this.btnNavSales);
            this.pnlNavigation.Controls.Add(this.btnNavInventory);
            this.pnlNavigation.Controls.Add(this.btnNavDelivery);
            this.pnlNavigation.Controls.Add(this.btnNavMaintenance);
            this.pnlNavigation.Controls.Add(this.lblNavTitle);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(1067, 60);
            this.pnlNavigation.TabIndex = 14;
            // 
            // btnNavMainMenu
            // 
            this.btnNavMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnNavMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMainMenu.FlatAppearance.BorderSize = 0;
            this.btnNavMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnNavMainMenu.Location = new System.Drawing.Point(945, 15);
            this.btnNavMainMenu.Name = "btnNavMainMenu";
            this.btnNavMainMenu.Size = new System.Drawing.Size(100, 30);
            this.btnNavMainMenu.TabIndex = 6;
            this.btnNavMainMenu.Text = "🏠 Main Menu";
            this.btnNavMainMenu.UseVisualStyleBackColor = false;
            this.btnNavMainMenu.Click += new System.EventHandler(this.btnNavMainMenu_Click);
            // 
            // btnNavBackup
            // 
            this.btnNavBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBackup.FlatAppearance.BorderSize = 0;
            this.btnNavBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavBackup.ForeColor = System.Drawing.Color.White;
            this.btnNavBackup.Location = new System.Drawing.Point(850, 15);
            this.btnNavBackup.Name = "btnNavBackup";
            this.btnNavBackup.Size = new System.Drawing.Size(85, 30);
            this.btnNavBackup.TabIndex = 5;
            this.btnNavBackup.Text = "💾 Backup";
            this.btnNavBackup.UseVisualStyleBackColor = false;
            this.btnNavBackup.Click += new System.EventHandler(this.btnNavBackup_Click);
            // 
            // btnNavSales
            // 
            this.btnNavSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSales.FlatAppearance.BorderSize = 0;
            this.btnNavSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSales.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavSales.ForeColor = System.Drawing.Color.White;
            this.btnNavSales.Location = new System.Drawing.Point(765, 15);
            this.btnNavSales.Name = "btnNavSales";
            this.btnNavSales.Size = new System.Drawing.Size(75, 30);
            this.btnNavSales.TabIndex = 4;
            this.btnNavSales.Text = "💰 Sales";
            this.btnNavSales.UseVisualStyleBackColor = false;
            this.btnNavSales.Click += new System.EventHandler(this.btnNavSales_Click);
            // 
            // btnNavInventory
            // 
            this.btnNavInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavInventory.FlatAppearance.BorderSize = 0;
            this.btnNavInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavInventory.ForeColor = System.Drawing.Color.White;
            this.btnNavInventory.Location = new System.Drawing.Point(655, 15);
            this.btnNavInventory.Name = "btnNavInventory";
            this.btnNavInventory.Size = new System.Drawing.Size(100, 30);
            this.btnNavInventory.TabIndex = 3;
            this.btnNavInventory.Text = "📊 Inventory";
            this.btnNavInventory.UseVisualStyleBackColor = false;
            this.btnNavInventory.Click += new System.EventHandler(this.btnNavInventory_Click);
            // 
            // btnNavDelivery
            // 
            this.btnNavDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDelivery.FlatAppearance.BorderSize = 0;
            this.btnNavDelivery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDelivery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavDelivery.ForeColor = System.Drawing.Color.White;
            this.btnNavDelivery.Location = new System.Drawing.Point(555, 15);
            this.btnNavDelivery.Name = "btnNavDelivery";
            this.btnNavDelivery.Size = new System.Drawing.Size(90, 30);
            this.btnNavDelivery.TabIndex = 2;
            this.btnNavDelivery.Text = "📦 Delivery";
            this.btnNavDelivery.UseVisualStyleBackColor = false;
            this.btnNavDelivery.Click += new System.EventHandler(this.btnNavDelivery_Click);
            // 
            // btnNavMaintenance
            // 
            this.btnNavMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMaintenance.FlatAppearance.BorderSize = 0;
            this.btnNavMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMaintenance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnNavMaintenance.Location = new System.Drawing.Point(415, 15);
            this.btnNavMaintenance.Name = "btnNavMaintenance";
            this.btnNavMaintenance.Size = new System.Drawing.Size(130, 30);
            this.btnNavMaintenance.TabIndex = 1;
            this.btnNavMaintenance.Text = "🔧 Maintenance";
            this.btnNavMaintenance.UseVisualStyleBackColor = false;
            this.btnNavMaintenance.Click += new System.EventHandler(this.btnNavMaintenance_Click);
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.AutoSize = true;
            this.lblNavTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNavTitle.ForeColor = System.Drawing.Color.White;
            this.lblNavTitle.Location = new System.Drawing.Point(15, 18);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(178, 21);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "🏪 POS System - POS";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(40, 195);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(987, 369);
            this.dgvCart.TabIndex = 4;
            // 
            // cmbItems
            // 
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(160, 142);
            this.cmbItems.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(332, 25);
            this.cmbItems.TabIndex = 1;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtQuantity.Location = new System.Drawing.Point(627, 142);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 25);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(800, 139);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(160, 31);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "➕ Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(827, 638);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(200, 49);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "🛒 Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(667, 589);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(130, 21);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(827, 585);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(62, 25);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "₱0.00";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblItem.Location = new System.Drawing.Point(40, 145);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(84, 19);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Select Item:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(533, 145);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 19);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(400, 75);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Point of Sales";
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReceiptId.Location = new System.Drawing.Point(160, 110);
            this.txtReceiptId.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.ReadOnly = true;
            this.txtReceiptId.Size = new System.Drawing.Size(200, 25);
            this.txtReceiptId.TabIndex = 10;
            // 
            // lblReceiptId
            // 
            this.lblReceiptId.AutoSize = true;
            this.lblReceiptId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReceiptId.Location = new System.Drawing.Point(40, 113);
            this.lblReceiptId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiptId.Name = "lblReceiptId";
            this.lblReceiptId.Size = new System.Drawing.Size(82, 19);
            this.lblReceiptId.TabIndex = 11;
            this.lblReceiptId.Text = "Receipt ID:";
            // 
            // lblAvailableStock
            // 
            this.lblAvailableStock.AutoSize = true;
            this.lblAvailableStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblAvailableStock.Location = new System.Drawing.Point(500, 145);
            this.lblAvailableStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailableStock.Name = "lblAvailableStock";
            this.lblAvailableStock.Size = new System.Drawing.Size(126, 19);
            this.lblAvailableStock.TabIndex = 12;
            this.lblAvailableStock.Text = "Available Stock: 0";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveFromCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(40, 589);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(180, 35);
            this.btnRemoveFromCart.TabIndex = 13;
            this.btnRemoveFromCart.Text = "🗑️ Remove Selected";
            this.btnRemoveFromCart.UseVisualStyleBackColor = false;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 712);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.lblAvailableStock);
            this.Controls.Add(this.lblReceiptId);
            this.Controls.Add(this.txtReceiptId);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales - POS System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
