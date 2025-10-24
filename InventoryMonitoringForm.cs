using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace POS
{
    public partial class InventoryMonitoringForm : Form
    {
        public InventoryMonitoringForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadInventory();
            HighlightCurrentModule();
        }

        private void HighlightCurrentModule()
        {
            // Highlight the Inventory button since we're on Inventory form
            Color activeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            // Note: We don't have btnNavInventory since we ARE inventory, but we could add it grayed out
        }

        private void LoadInventory()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Query to get inventory sorted by quantity (least to highest)
                    string query = @"SELECT 
                                        i.ItemId,
                                        i.ItemName,
                                        c.CategoryName,
                                        i.BasePrice,
                                        IFNULL(inv.Quantity, 0) AS Quantity,
                                        (IFNULL(inv.Quantity, 0) * i.BasePrice) AS TotalValue
                                    FROM Items i
                                    INNER JOIN ItemCategory c ON i.CategoryId = c.CategoryId
                                    LEFT JOIN Inventory inv ON i.ItemId = inv.ItemId
                                    ORDER BY Quantity ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvInventory.DataSource = dt;

                    // Format the DataGridView
                    if (dgvInventory.Columns.Count > 0)
                    {
                        dgvInventory.Columns["ItemId"].HeaderText = "Item ID";
                        dgvInventory.Columns["ItemName"].HeaderText = "Item Name";
                        dgvInventory.Columns["CategoryName"].HeaderText = "Category";
                        dgvInventory.Columns["BasePrice"].HeaderText = "Base Price";
                        dgvInventory.Columns["BasePrice"].DefaultCellStyle.Format = "₱#,##0.00";
                        dgvInventory.Columns["Quantity"].HeaderText = "Stock Quantity";
                        dgvInventory.Columns["TotalValue"].HeaderText = "Total Value";
                        dgvInventory.Columns["TotalValue"].DefaultCellStyle.Format = "₱#,##0.00";

                        // Highlight low stock items (quantity < 10)
                        foreach (DataGridViewRow row in dgvInventory.Rows)
                        {
                            if (row.Cells["Quantity"].Value != null)
                            {
                                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                                if (qty < 10)
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 200, 200);
                                }
                                else if (qty == 0)
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 150, 150);
                                    row.DefaultCellStyle.ForeColor = Color.White;
                                }
                            }
                        }
                    }

                    // Calculate totals
                    CalculateTotals(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotals(DataTable dt)
        {
            int totalItems = dt.Rows.Count;
            int lowStockCount = 0;
            int outOfStockCount = 0;
            decimal totalInventoryValue = 0;

            foreach (DataRow row in dt.Rows)
            {
                int qty = Convert.ToInt32(row["Quantity"]);
                if (qty == 0)
                    outOfStockCount++;
                else if (qty < 10)
                    lowStockCount++;
                totalInventoryValue += Convert.ToDecimal(row["TotalValue"]);
            }

            lblTotalItems.Text = $"Total Items: {totalItems}";
            lblLowStock.Text = $"Low Stock Items: {lowStockCount} (Out of Stock: {outOfStockCount})";
            lblTotalValue.Text = $"Total Inventory Value: ₱{totalInventoryValue:#,##0.00}";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadInventory();
            MessageBox.Show("Inventory refreshed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvInventory.DataSource != null)
                {
                    DataTable dt = (DataTable)dgvInventory.DataSource;
                    DataView dv = dt.DefaultView;

                    if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        dv.RowFilter = $"ItemName LIKE '%{txtSearch.Text}%' OR CategoryName LIKE '%{txtSearch.Text}%'";
                    }
                    else
                    {
                        dv.RowFilter = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InventoryMonitoringForm_Load(object sender, EventArgs e)
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
