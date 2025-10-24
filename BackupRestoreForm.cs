using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace POS
{
    public partial class BackupRestoreForm : Form
    {
        private string mysqldumpPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe";
        private string mysqlPath = @"C:\Program Files\MySQL\MySQL Server 8.0\bin\mysql.exe";

        public BackupRestoreForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*";
                sfd.FileName = $"pos_backup_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
                sfd.Title = "Select Backup Location";
                sfd.DefaultExt = "sql";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtBackupPath.Text = sfd.FileName;
                }
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBackupPath.Text))
            {
                MessageBox.Show("Please select a backup file location!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string backupPath = txtBackupPath.Text;

                // Check if mysqldump exists
                if (!File.Exists(mysqldumpPath))
                {
                    MessageBox.Show("MySQL dump tool not found! Please install MySQL or update the path.\n\nExpected location: " + mysqldumpPath,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtbLog.AppendText($"[{DateTime.Now}] ERROR: mysqldump not found at: {mysqldumpPath}\n");
                    return;
                }

                rtbLog.AppendText($"[{DateTime.Now}] Starting database backup...\n");

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = mysqldumpPath,
                    Arguments = $"--user=root --password=admin --host=localhost pos_db",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    using (StreamWriter sw = new StreamWriter(backupPath))
                    {
                        string output = process.StandardOutput.ReadToEnd();
                        sw.Write(output);
                    }

                    string errors = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        rtbLog.AppendText($"[{DateTime.Now}] SUCCESS: Backup created at: {backupPath}\n");
                        MessageBox.Show($"Database backup created successfully!\n\nLocation: {backupPath}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        rtbLog.AppendText($"[{DateTime.Now}] ERROR: {errors}\n");
                        MessageBox.Show($"Backup failed!\n\n{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                rtbLog.AppendText($"[{DateTime.Now}] EXCEPTION: {ex.Message}\n");
                MessageBox.Show($"Error creating backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*";
                ofd.Title = "Select Backup File to Restore";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtRestorePath.Text = ofd.FileName;
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRestorePath.Text))
            {
                MessageBox.Show("Please select a backup file to restore!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(txtRestorePath.Text))
            {
                MessageBox.Show("The selected backup file does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "WARNING: This will replace all current data in the database!\n\nAre you sure you want to continue?",
                "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                string restorePath = txtRestorePath.Text;

                // Check if mysql exists
                if (!File.Exists(mysqlPath))
                {
                    MessageBox.Show("MySQL client tool not found! Please install MySQL or update the path.\n\nExpected location: " + mysqlPath,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtbLog.AppendText($"[{DateTime.Now}] ERROR: mysql not found at: {mysqlPath}\n");
                    return;
                }

                rtbLog.AppendText($"[{DateTime.Now}] Starting database restore...\n");

                string sqlContent = File.ReadAllText(restorePath);

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = mysqlPath,
                    Arguments = $"--user=root --password=admin --host=localhost pos_db",
                    RedirectStandardInput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (Process process = Process.Start(psi))
                {
                    process.StandardInput.Write(sqlContent);
                    process.StandardInput.Close();

                    string errors = process.StandardError.ReadToEnd();
                    process.WaitForExit();

                    if (process.ExitCode == 0)
                    {
                        rtbLog.AppendText($"[{DateTime.Now}] SUCCESS: Database restored from: {restorePath}\n");
                        MessageBox.Show("Database restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        rtbLog.AppendText($"[{DateTime.Now}] ERROR: {errors}\n");
                        MessageBox.Show($"Restore failed!\n\n{errors}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                rtbLog.AppendText($"[{DateTime.Now}] EXCEPTION: {ex.Message}\n");
                MessageBox.Show($"Error restoring database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupRestoreForm_Load(object sender, EventArgs e)
        {
            rtbLog.AppendText($"[{DateTime.Now}] Database Backup and Restore tool initialized.\n");
            rtbLog.AppendText($"[{DateTime.Now}] mysqldump path: {mysqldumpPath}\n");
            rtbLog.AppendText($"[{DateTime.Now}] mysql path: {mysqlPath}\n\n");
        }

        // Navigation Methods
        private void btnNavMaintenance_Click(object sender, EventArgs e)
        {
            this.Hide();
            MaintenanceForm form = new MaintenanceForm();
            form.FormClosed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void btnNavDelivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryForm form = new DeliveryForm();
            form.FormClosed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void btnNavInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryMonitoringForm form = new InventoryMonitoringForm();
            form.FormClosed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void btnNavPOS_Click(object sender, EventArgs e)
        {
            this.Hide();
            POSForm form = new POSForm();
            form.FormClosed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void btnNavSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesMonitoringForm form = new SalesMonitoringForm();
            form.FormClosed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void btnNavMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
