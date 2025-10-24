using System.Windows.Forms;
using System.Drawing;

namespace POS
{
    partial class BackupRestoreForm
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
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRestore = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBrowseRestore = new System.Windows.Forms.Button();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnNavMainMenu = new System.Windows.Forms.Button();
            this.btnNavSales = new System.Windows.Forms.Button();
            this.btnNavPOS = new System.Windows.Forms.Button();
            this.btnNavInventory = new System.Windows.Forms.Button();
            this.btnNavDelivery = new System.Windows.Forms.Button();
            this.btnNavMaintenance = new System.Windows.Forms.Button();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.grpBackup.SuspendLayout();
            this.grpRestore.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlNavigation.Controls.Add(this.btnNavMainMenu);
            this.pnlNavigation.Controls.Add(this.btnNavSales);
            this.pnlNavigation.Controls.Add(this.btnNavPOS);
            this.pnlNavigation.Controls.Add(this.btnNavInventory);
            this.pnlNavigation.Controls.Add(this.btnNavDelivery);
            this.pnlNavigation.Controls.Add(this.btnNavMaintenance);
            this.pnlNavigation.Controls.Add(this.lblNavTitle);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(900, 60);
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
            this.btnNavMainMenu.Location = new System.Drawing.Point(780, 15);
            this.btnNavMainMenu.Name = "btnNavMainMenu";
            this.btnNavMainMenu.Size = new System.Drawing.Size(100, 30);
            this.btnNavMainMenu.TabIndex = 6;
            this.btnNavMainMenu.Text = "🏠 Main Menu";
            this.btnNavMainMenu.UseVisualStyleBackColor = false;
            this.btnNavMainMenu.Click += new System.EventHandler(this.btnNavMainMenu_Click);
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
            this.btnNavSales.Location = new System.Drawing.Point(695, 15);
            this.btnNavSales.Name = "btnNavSales";
            this.btnNavSales.Size = new System.Drawing.Size(75, 30);
            this.btnNavSales.TabIndex = 5;
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
            this.btnNavPOS.Location = new System.Drawing.Point(620, 15);
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
            this.btnNavInventory.Location = new System.Drawing.Point(510, 15);
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
            this.btnNavDelivery.Location = new System.Drawing.Point(410, 15);
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
            this.btnNavMaintenance.Location = new System.Drawing.Point(270, 15);
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
            this.lblNavTitle.Size = new System.Drawing.Size(207, 21);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "🏪 POS System - Backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Backup and Restore";
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackup);
            this.grpBackup.Controls.Add(this.btnBrowseBackup);
            this.grpBackup.Controls.Add(this.txtBackupPath);
            this.grpBackup.Controls.Add(this.label2);
            this.grpBackup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpBackup.Location = new System.Drawing.Point(25, 130);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(650, 120);
            this.grpBackup.TabIndex = 1;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Backup Database";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(520, 70);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(110, 35);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "💾 Backup";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseBackup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseBackup.Location = new System.Drawing.Point(520, 30);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(110, 28);
            this.btnBrowseBackup.TabIndex = 2;
            this.btnBrowseBackup.Text = "📁 Browse...";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(20, 55);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.ReadOnly = true;
            this.txtBackupPath.Size = new System.Drawing.Size(480, 25);
            this.txtBackupPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select backup location:";
            // 
            // grpRestore
            // 
            this.grpRestore.Controls.Add(this.btnRestore);
            this.grpRestore.Controls.Add(this.btnBrowseRestore);
            this.grpRestore.Controls.Add(this.txtRestorePath);
            this.grpRestore.Controls.Add(this.label3);
            this.grpRestore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpRestore.Location = new System.Drawing.Point(25, 270);
            this.grpRestore.Name = "grpRestore";
            this.grpRestore.Size = new System.Drawing.Size(650, 120);
            this.grpRestore.TabIndex = 2;
            this.grpRestore.TabStop = false;
            this.grpRestore.Text = "Restore Database";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(520, 70);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(110, 35);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "♻️ Restore";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseRestore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowseRestore.Location = new System.Drawing.Point(520, 30);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(110, 28);
            this.btnBrowseRestore.TabIndex = 2;
            this.btnBrowseRestore.Text = "📁 Browse...";
            this.btnBrowseRestore.UseVisualStyleBackColor = true;
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Location = new System.Drawing.Point(20, 55);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.ReadOnly = true;
            this.txtRestorePath.Size = new System.Drawing.Size(480, 25);
            this.txtRestorePath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select backup file:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operation Log:";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbLog.ForeColor = System.Drawing.Color.Lime;
            this.rtbLog.Location = new System.Drawing.Point(25, 430);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(850, 150);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpRestore);
            this.Controls.Add(this.grpBackup);
            this.Controls.Add(this.label1);
            this.Name = "BackupRestoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Backup and Restore - POS System";
            this.Load += new System.EventHandler(this.BackupRestoreForm_Load);
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpRestore.ResumeLayout(false);
            this.grpRestore.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox grpRestore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBrowseRestore;
        private System.Windows.Forms.TextBox txtRestorePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Button btnNavMaintenance;
        private System.Windows.Forms.Button btnNavDelivery;
        private System.Windows.Forms.Button btnNavInventory;
        private System.Windows.Forms.Button btnNavPOS;
        private System.Windows.Forms.Button btnNavSales;
        private System.Windows.Forms.Button btnNavMainMenu;
    }
}
