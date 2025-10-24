namespace POS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnInventoryMonitoring;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnSalesMonitoring;
        private System.Windows.Forms.Button btnBackupRestore;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlButtons;

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
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnInventoryMonitoring = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnSalesMonitoring = new System.Windows.Forms.Button();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(30, 20);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(200, 80);
            this.btnMaintenance.TabIndex = 0;
            this.btnMaintenance.Text = "🔧 Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelivery.FlatAppearance.BorderSize = 0;
            this.btnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Location = new System.Drawing.Point(250, 20);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(200, 80);
            this.btnDelivery.TabIndex = 1;
            this.btnDelivery.Text = "📦 Delivery";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnInventoryMonitoring
            // 
            this.btnInventoryMonitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnInventoryMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventoryMonitoring.FlatAppearance.BorderSize = 0;
            this.btnInventoryMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryMonitoring.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventoryMonitoring.ForeColor = System.Drawing.Color.White;
            this.btnInventoryMonitoring.Location = new System.Drawing.Point(470, 20);
            this.btnInventoryMonitoring.Name = "btnInventoryMonitoring";
            this.btnInventoryMonitoring.Size = new System.Drawing.Size(200, 80);
            this.btnInventoryMonitoring.TabIndex = 2;
            this.btnInventoryMonitoring.Text = "📊 Inventory\r\nMonitoring";
            this.btnInventoryMonitoring.UseVisualStyleBackColor = false;
            this.btnInventoryMonitoring.Click += new System.EventHandler(this.btnInventoryMonitoring_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(30, 120);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(200, 80);
            this.btnPOS.TabIndex = 3;
            this.btnPOS.Text = "🛒 Point of Sale";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnSalesMonitoring
            // 
            this.btnSalesMonitoring.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnSalesMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesMonitoring.FlatAppearance.BorderSize = 0;
            this.btnSalesMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesMonitoring.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalesMonitoring.ForeColor = System.Drawing.Color.White;
            this.btnSalesMonitoring.Location = new System.Drawing.Point(250, 120);
            this.btnSalesMonitoring.Name = "btnSalesMonitoring";
            this.btnSalesMonitoring.Size = new System.Drawing.Size(200, 80);
            this.btnSalesMonitoring.TabIndex = 4;
            this.btnSalesMonitoring.Text = "💰 Sales\r\nMonitoring";
            this.btnSalesMonitoring.UseVisualStyleBackColor = false;
            this.btnSalesMonitoring.Click += new System.EventHandler(this.btnSalesMonitoring_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnBackupRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackupRestore.FlatAppearance.BorderSize = 0;
            this.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupRestore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBackupRestore.ForeColor = System.Drawing.Color.White;
            this.btnBackupRestore.Location = new System.Drawing.Point(470, 120);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(200, 80);
            this.btnBackupRestore.TabIndex = 5;
            this.btnBackupRestore.Text = "💾 Backup &&\r\nRestore";
            this.btnBackupRestore.UseVisualStyleBackColor = false;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(280, 230);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏪 Sales Inventory System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnMaintenance);
            this.pnlButtons.Controls.Add(this.btnDelivery);
            this.pnlButtons.Controls.Add(this.btnInventoryMonitoring);
            this.pnlButtons.Controls.Add(this.btnPOS);
            this.pnlButtons.Controls.Add(this.btnSalesMonitoring);
            this.pnlButtons.Controls.Add(this.btnBackupRestore);
            this.pnlButtons.Controls.Add(this.btnLogout);
            this.pnlButtons.Location = new System.Drawing.Point(0, 80);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(700, 300);
            this.pnlButtons.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu - POS System";
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
