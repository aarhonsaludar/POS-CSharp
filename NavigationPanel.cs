using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class NavigationPanel : UserControl
    {
        public event EventHandler MaintenanceClicked;
        public event EventHandler DeliveryClicked;
        public event EventHandler InventoryClicked;
        public event EventHandler POSClicked;
        public event EventHandler SalesClicked;
        public event EventHandler BackupClicked;
        public event EventHandler MainMenuClicked;

        public NavigationPanel()
        {
            InitializeComponent();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceClicked?.Invoke(this, e);
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            DeliveryClicked?.Invoke(this, e);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryClicked?.Invoke(this, e);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSClicked?.Invoke(this, e);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesClicked?.Invoke(this, e);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            BackupClicked?.Invoke(this, e);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuClicked?.Invoke(this, e);
        }

        public void HighlightButton(string formName)
        {
            // Reset all buttons
            Color defaultColor = Color.FromArgb(52, 73, 94);
            Color activeColor = Color.FromArgb(41, 128, 185);

            btnMaintenance.BackColor = defaultColor;
            btnDelivery.BackColor = defaultColor;
            btnInventory.BackColor = defaultColor;
            btnPOS.BackColor = defaultColor;
            btnSales.BackColor = defaultColor;
            btnBackup.BackColor = defaultColor;

            // Highlight active button
            switch (formName.ToLower())
            {
                case "maintenance":
                    btnMaintenance.BackColor = activeColor;
                    break;
                case "delivery":
                    btnDelivery.BackColor = activeColor;
                    break;
                case "inventory":
                    btnInventory.BackColor = activeColor;
                    break;
                case "pos":
                    btnPOS.BackColor = activeColor;
                    break;
                case "sales":
                    btnSales.BackColor = activeColor;
                    break;
                case "backup":
                    btnBackup.BackColor = activeColor;
                    break;
            }
        }
    }
}
