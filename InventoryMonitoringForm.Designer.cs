namespace POS
{
    partial class InventoryMonitoringForm
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnNavMainMenu = new System.Windows.Forms.Button();
            this.btnNavBackup = new System.Windows.Forms.Button();
            this.btnNavSales = new System.Windows.Forms.Button();
            this.btnNavPOS = new System.Windows.Forms.Button();
            this.btnNavDelivery = new System.Windows.Forms.Button();
            this.btnNavMaintenance = new System.Windows.Forms.Button();
            this.lblNavTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlNavigation.Controls.Add(this.btnNavMainMenu);
            this.pnlNavigation.Controls.Add(this.btnNavBackup);
            this.pnlNavigation.Controls.Add(this.btnNavSales);
            this.pnlNavigation.Controls.Add(this.btnNavPOS);
            this.pnlNavigation.Controls.Add(this.btnNavDelivery);
            this.pnlNavigation.Controls.Add(this.btnNavMaintenance);
            this.pnlNavigation.Controls.Add(this.lblNavTitle);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(1000, 60);
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
            this.btnNavMainMenu.Location = new System.Drawing.Point(880, 15);
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
            this.btnNavBackup.Location = new System.Drawing.Point(785, 15);
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
            this.btnNavSales.Location = new System.Drawing.Point(700, 15);
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
            this.btnNavPOS.Location = new System.Drawing.Point(625, 15);
            this.btnNavPOS.Name = "btnNavPOS";
            this.btnNavPOS.Size = new System.Drawing.Size(65, 30);
            this.btnNavPOS.TabIndex = 3;
            this.btnNavPOS.Text = "🛒 POS";
            this.btnNavPOS.UseVisualStyleBackColor = false;
            this.btnNavPOS.Click += new System.EventHandler(this.btnNavPOS_Click);
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
            this.btnNavDelivery.Location = new System.Drawing.Point(525, 15);
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
            this.btnNavMaintenance.Location = new System.Drawing.Point(385, 15);
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
            this.lblNavTitle.Size = new System.Drawing.Size(232, 21);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "🏪 POS System - Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Monitoring";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(20, 180);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(960, 350);
            this.dgvInventory.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(80, 127);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(400, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.lblTotalValue);
            this.panel1.Controls.Add(this.lblLowStock);
            this.panel1.Controls.Add(this.lblTotalItems);
            this.panel1.Location = new System.Drawing.Point(20, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 60);
            this.panel1.TabIndex = 5;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalValue.Location = new System.Drawing.Point(650, 20);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(175, 19);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "Total Inventory Value: ₱0";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblLowStock.Location = new System.Drawing.Point(320, 20);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(134, 19);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "Low Stock Items: 0";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTotalItems.Location = new System.Drawing.Point(20, 20);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(97, 19);
            this.lblTotalItems.TabIndex = 0;
            this.lblTotalItems.Text = "Total Items: 0";
            // 
            // InventoryMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.label1);
            this.Name = "InventoryMonitoringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Monitoring - POS System";
            this.Load += new System.EventHandler(this.InventoryMonitoringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Button btnNavMaintenance;
        private System.Windows.Forms.Button btnNavDelivery;
        private System.Windows.Forms.Button btnNavPOS;
        private System.Windows.Forms.Button btnNavSales;
        private System.Windows.Forms.Button btnNavBackup;
        private System.Windows.Forms.Button btnNavMainMenu;
    }
}
