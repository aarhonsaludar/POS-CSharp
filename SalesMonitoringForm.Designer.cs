namespace POS
{
    partial class SalesMonitoringForm
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
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnNavMainMenu = new System.Windows.Forms.Button();
            this.btnNavBackup = new System.Windows.Forms.Button();
            this.btnNavPOS = new System.Windows.Forms.Button();
            this.btnNavInventory = new System.Windows.Forms.Button();
            this.btnNavDelivery = new System.Windows.Forms.Button();
            this.btnNavMaintenance = new System.Windows.Forms.Button();
            this.lblNavTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlNavigation.Controls.Add(this.btnNavMainMenu);
            this.pnlNavigation.Controls.Add(this.btnNavBackup);
            this.pnlNavigation.Controls.Add(this.btnNavPOS);
            this.pnlNavigation.Controls.Add(this.btnNavInventory);
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
            // btnNavPOS
            // 
            this.btnNavPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPOS.FlatAppearance.BorderSize = 0;
            this.btnNavPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPOS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNavPOS.ForeColor = System.Drawing.Color.White;
            this.btnNavPOS.Location = new System.Drawing.Point(710, 15);
            this.btnNavPOS.Name = "btnNavPOS";
            this.btnNavPOS.Size = new System.Drawing.Size(65, 30);
            this.btnNavPOS.TabIndex = 4;
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
            this.btnNavInventory.Location = new System.Drawing.Point(600, 15);
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
            this.btnNavDelivery.Location = new System.Drawing.Point(500, 15);
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
            this.btnNavMaintenance.Location = new System.Drawing.Point(360, 15);
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
            this.lblNavTitle.Size = new System.Drawing.Size(195, 21);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "🏪 POS System - Sales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Monitoring";
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(20, 180);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(960, 350);
            this.dgvSales.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(100, 127);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 25);
            this.dtpStartDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(270, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(345, 127);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 25);
            this.dtpEndDate.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(520, 125);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "🔍 Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(640, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.lblTotalTransactions);
            this.panel1.Controls.Add(this.lblTotalSales);
            this.panel1.Location = new System.Drawing.Point(20, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 60);
            this.panel1.TabIndex = 8;
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AutoSize = true;
            this.lblTotalTransactions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblTotalTransactions.Location = new System.Drawing.Point(500, 20);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(149, 19);
            this.lblTotalTransactions.TabIndex = 1;
            this.lblTotalTransactions.Text = "Total Transactions: 0";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblTotalSales.Location = new System.Drawing.Point(20, 20);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(103, 19);
            this.lblTotalSales.TabIndex = 0;
            this.lblTotalSales.Text = "Total Sales: ₱0";
            // 
            // SalesMonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.label1);
            this.Name = "SalesMonitoringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Monitoring - POS System";
            this.Load += new System.EventHandler(this.SalesMonitoringForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalTransactions;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Button btnNavMaintenance;
        private System.Windows.Forms.Button btnNavDelivery;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Button btnNavPOS;
        private System.Windows.Forms.Button btnNavBackup;
        private System.Windows.Forms.Button btnNavMainMenu;
    }
}
