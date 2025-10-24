using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace POS
{
    public partial class SalesMonitoringForm : Form
    {
        public SalesMonitoringForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadSales();
            dtpStartDate.Value = DateTime.Now.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
        }

        private void LoadSales()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Query to get sales sorted by receipt date (descending)
                    string query = @"SELECT 
                                        s.SaleId,
                                        s.ReceiptId,
                                        s.ReceiptDate,
                                        i.ItemName,
                                        s.Quantity,
                                        s.TotalAmount
                                    FROM Sales s
                                    INNER JOIN Items i ON s.ItemId = i.ItemId
                                    ORDER BY s.ReceiptDate DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSales.DataSource = dt;

                    // Format the DataGridView
                    if (dgvSales.Columns.Count > 0)
                    {
                        dgvSales.Columns["SaleId"].HeaderText = "Sale ID";
                        dgvSales.Columns["ReceiptId"].HeaderText = "Receipt ID";
                        dgvSales.Columns["ReceiptDate"].HeaderText = "Date";
                        dgvSales.Columns["ReceiptDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                        dgvSales.Columns["ItemName"].HeaderText = "Item Name";
                        dgvSales.Columns["Quantity"].HeaderText = "Quantity";
                        dgvSales.Columns["TotalAmount"].HeaderText = "Total Amount";
                        dgvSales.Columns["TotalAmount"].DefaultCellStyle.Format = "₱#,##0.00";
                    }

                    CalculateTotals(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotals(DataTable dt)
        {
            decimal totalSales = 0;
            int totalTransactions = 0;

            // Get unique receipt IDs
            DataView dv = new DataView(dt);
            DataTable distinctReceipts = dv.ToTable(true, "ReceiptId");
            totalTransactions = distinctReceipts.Rows.Count;

            foreach (DataRow row in dt.Rows)
            {
                totalSales += Convert.ToDecimal(row["TotalAmount"]);
            }

            lblTotalSales.Text = $"Total Sales: ₱{totalSales:#,##0.00}";
            lblTotalTransactions.Text = $"Total Transactions: {totalTransactions}";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate date range
                if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
                {
                    MessageBox.Show("Start date cannot be later than end date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                                        s.SaleId,
                                        s.ReceiptId,
                                        s.ReceiptDate,
                                        i.ItemName,
                                        s.Quantity,
                                        s.TotalAmount
                                    FROM Sales s
                                    INNER JOIN Items i ON s.ItemId = i.ItemId
                                    WHERE DATE(s.ReceiptDate) BETWEEN @startDate AND @endDate
                                    ORDER BY s.ReceiptDate DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@startDate", dtpStartDate.Value.Date);
                    cmd.Parameters.AddWithValue("@endDate", dtpEndDate.Value.Date);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSales.DataSource = dt;
                    CalculateTotals(dt);
                    
                    MessageBox.Show($"Filter applied! Found {dt.Rows.Count} sales records.", "Filter Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSales();
            // Reset date filters to default
            dtpStartDate.Value = DateTime.Now.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            MessageBox.Show("Sales data refreshed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SalesMonitoringForm_Load(object sender, EventArgs e)
        {

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

        private void btnNavBackup_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackupRestoreForm form = new BackupRestoreForm();
            form.FormClosed += (s, args) => this.Close();
            form.ShowDialog();
        }

        private void btnNavMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
