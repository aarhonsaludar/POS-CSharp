namespace POS
{
    partial class DeliveryForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.btnSaveDelivery = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnNavMainMenu = new System.Windows.Forms.Button();
            this.btnNavBackup = new System.Windows.Forms.Button();
            this.btnNavSales = new System.Windows.Forms.Button();
            this.btnNavPOS = new System.Windows.Forms.Button();
            this.btnNavInventory = new System.Windows.Forms.Button();
            this.btnNavMaintenance = new System.Windows.Forms.Button();
            this.lblNavTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(30, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery ID:";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryId.Location = new System.Drawing.Point(150, 147);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.ReadOnly = true;
            this.txtDeliveryId.Size = new System.Drawing.Size(250, 25);
            this.txtDeliveryId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(30, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Delivery Date:";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(150, 187);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(250, 25);
            this.dtpDeliveryDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(30, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item:";
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(150, 227);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(250, 25);
            this.cmbItem.TabIndex = 5;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(30, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudQuantity.Location = new System.Drawing.Point(150, 267);
            this.nudQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(250, 25);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblCurrentStock.Location = new System.Drawing.Point(150, 310);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(109, 19);
            this.lblCurrentStock.TabIndex = 8;
            this.lblCurrentStock.Text = "Current Stock: 0";
            // 
            // btnSaveDelivery
            // 
            this.btnSaveDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSaveDelivery.FlatAppearance.BorderSize = 0;
            this.btnSaveDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDelivery.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveDelivery.ForeColor = System.Drawing.Color.White;
            this.btnSaveDelivery.Location = new System.Drawing.Point(150, 360);
            this.btnSaveDelivery.Name = "btnSaveDelivery";
            this.btnSaveDelivery.Size = new System.Drawing.Size(120, 35);
            this.btnSaveDelivery.TabIndex = 9;
            this.btnSaveDelivery.Text = "Save Delivery";
            this.btnSaveDelivery.UseVisualStyleBackColor = false;
            this.btnSaveDelivery.Click += new System.EventHandler(this.btnSaveDelivery_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(280, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Delivery Receiving";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlNavigation.Controls.Add(this.btnNavMainMenu);
            this.pnlNavigation.Controls.Add(this.btnNavBackup);
            this.pnlNavigation.Controls.Add(this.btnNavSales);
            this.pnlNavigation.Controls.Add(this.btnNavPOS);
            this.pnlNavigation.Controls.Add(this.btnNavInventory);
            this.pnlNavigation.Controls.Add(this.btnNavMaintenance);
            this.pnlNavigation.Controls.Add(this.lblNavTitle);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(800, 60);
            this.pnlNavigation.TabIndex = 12;
            // 
            // btnNavMainMenu
            // 
            this.btnNavMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnNavMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMainMenu.FlatAppearance.BorderSize = 0;
            this.btnNavMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnNavMainMenu.Location = new System.Drawing.Point(680, 15);
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
            this.btnNavBackup.Location = new System.Drawing.Point(585, 15);
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
            this.btnNavSales.Location = new System.Drawing.Point(500, 15);
            this.btnNavSales.Name = "btnNavSales";
            this.btnNavSales.Size = new System.Drawing.Size(75, 30);
            this.btnNavSales.TabIndex = 4;
            this.btnNavSales.Text = "💰 Sales";
            this.btnNavSales.UseVisualStyleBackColor = false;
            this.btnNavSales.Click += new System.EventHandler(this.btnNavSales_Click);
            // 
            // btnNavPOS
            // 
            this.btnNavPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPOS.FlatAppearance.BorderSize = 0;
            this.btnNavPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPOS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavPOS.ForeColor = System.Drawing.Color.White;
            this.btnNavPOS.Location = new System.Drawing.Point(425, 15);
            this.btnNavPOS.Name = "btnNavPOS";
            this.btnNavPOS.Size = new System.Drawing.Size(65, 30);
            this.btnNavPOS.TabIndex = 3;
            this.btnNavPOS.Text = "🛒 POS";
            this.btnNavPOS.UseVisualStyleBackColor = false;
            this.btnNavPOS.Click += new System.EventHandler(this.btnNavPOS_Click);
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
            this.btnNavInventory.Location = new System.Drawing.Point(315, 15);
            this.btnNavInventory.Name = "btnNavInventory";
            this.btnNavInventory.Size = new System.Drawing.Size(100, 30);
            this.btnNavInventory.TabIndex = 2;
            this.btnNavInventory.Text = "📊 Inventory";
            this.btnNavInventory.UseVisualStyleBackColor = false;
            this.btnNavInventory.Click += new System.EventHandler(this.btnNavInventory_Click);
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
            this.btnNavMaintenance.Location = new System.Drawing.Point(175, 15);
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
            this.lblNavTitle.Size = new System.Drawing.Size(125, 21);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "🏪 POS System";
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveDelivery);
            this.Controls.Add(this.lblCurrentStock);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeliveryId);
            this.Controls.Add(this.label1);
            this.Name = "DeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery Form";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Button btnSaveDelivery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Button btnNavMaintenance;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Button btnNavPOS;
        private System.Windows.Forms.Button btnNavSales;
        private System.Windows.Forms.Button btnNavBackup;
        private System.Windows.Forms.Button btnNavMainMenu;
    }
}
