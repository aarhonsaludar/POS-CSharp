namespace POS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnLogout;
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
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMaintenance.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.Location = new System.Drawing.Point(267, 123);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(267, 62);
            this.btnMaintenance.TabIndex = 1;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPOS.Font = new System.Drawing.Font("Arial", 16.2F);
            this.btnPOS.Location = new System.Drawing.Point(267, 209);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(267, 62);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "Point of Sales";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 12.2F);
            this.btnLogout.Location = new System.Drawing.Point(330, 310);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 37);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.Location = new System.Drawing.Point(157, 36);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(511, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sales Inventory System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
