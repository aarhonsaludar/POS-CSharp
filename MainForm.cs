using System;
using System.Windows.Forms;

namespace POS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
            maintenanceForm.Dispose();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.ShowDialog();
            deliveryForm.Dispose();
        }

        private void btnInventoryMonitoring_Click(object sender, EventArgs e)
        {
            InventoryMonitoringForm inventoryForm = new InventoryMonitoringForm();
            inventoryForm.ShowDialog();
            inventoryForm.Dispose();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSForm posForm = new POSForm();
            posForm.ShowDialog();
            posForm.Dispose();
        }

        private void btnSalesMonitoring_Click(object sender, EventArgs e)
        {
            SalesMonitoringForm salesForm = new SalesMonitoringForm();
            salesForm.ShowDialog();
            salesForm.Dispose();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            BackupRestoreForm backupForm = new BackupRestoreForm();
            backupForm.ShowDialog();
            backupForm.Dispose();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // This will return to login form
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            // Only confirm if not logging out
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to exit the application?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
