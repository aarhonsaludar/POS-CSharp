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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(40, 135);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.Size = new System.Drawing.Size(987, 369);
            this.dgvCart.TabIndex = 4;
            // 
            // cmbItems
            // 
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(160, 82);
            this.cmbItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(332, 24);
            this.cmbItems.TabIndex = 1;
            this.cmbItems.SelectedIndexChanged += new System.EventHandler(this.cmbItems_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(627, 82);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(800, 80);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(160, 31);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.Location = new System.Drawing.Point(827, 578);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(200, 49);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(667, 529);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(148, 25);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Green;
            this.lblTotalAmount.Location = new System.Drawing.Point(827, 529);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(68, 25);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "₱0.00";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(40, 86);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(76, 16);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Select Item:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(533, 86);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 16);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(400, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Point of Sales";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 652);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
