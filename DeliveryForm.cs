using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace POS
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadItems();
            GenerateDeliveryId();
            dtpDeliveryDate.Value = DateTime.Now;
            HighlightCurrentModule();
        }

        private void HighlightCurrentModule()
        {
            // Highlight the Delivery button since we're on Delivery form
            btnNavInventory.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnNavMaintenance.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnNavPOS.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnNavSales.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnNavBackup.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            
            // Current module highlighted (this would be Delivery button when added)
        }

        private void GenerateDeliveryId()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT IFNULL(MAX(DeliveryId), 0) + 1 FROM Delivery";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    int nextId = Convert.ToInt32(cmd.ExecuteScalar());
                    txtDeliveryId.Text = nextId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating delivery ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadItems()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ItemId, ItemName FROM Items ORDER BY ItemName";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbItem.DataSource = dt;
                    cmbItem.DisplayMember = "ItemName";
                    cmbItem.ValueMember = "ItemId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItem.SelectedValue != null && cmbItem.SelectedValue is int)
            {
                DisplayCurrentStock();
            }
        }

        private void DisplayCurrentStock()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT IFNULL(Quantity, 0) FROM Inventory WHERE ItemId = @itemId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemId", cmbItem.SelectedValue);
                    object result = cmd.ExecuteScalar();
                    int currentStock = result != null ? Convert.ToInt32(result) : 0;
                    lblCurrentStock.Text = "Current Stock: " + currentStock;
                }
            }
            catch (Exception ex)
            {
                lblCurrentStock.Text = "Current Stock: 0";
            }
        }

        private void btnSaveDelivery_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedValue == null || nudQuantity.Value <= 0)
            {
                MessageBox.Show("Please select an item and enter a valid quantity!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MySqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Insert delivery record
                        string deliveryQuery = "INSERT INTO Delivery (DeliveryDate, ItemId, Quantity) VALUES (@date, @itemId, @quantity)";
                        MySqlCommand deliveryCmd = new MySqlCommand(deliveryQuery, conn, transaction);
                        deliveryCmd.Parameters.AddWithValue("@date", dtpDeliveryDate.Value.Date);
                        deliveryCmd.Parameters.AddWithValue("@itemId", cmbItem.SelectedValue);
                        deliveryCmd.Parameters.AddWithValue("@quantity", nudQuantity.Value);
                        deliveryCmd.ExecuteNonQuery();

                        // Check if item exists in inventory
                        string checkQuery = "SELECT COUNT(*) FROM Inventory WHERE ItemId = @itemId";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn, transaction);
                        checkCmd.Parameters.AddWithValue("@itemId", cmbItem.SelectedValue);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            // Update existing inventory
                            string updateQuery = "UPDATE Inventory SET Quantity = Quantity + @quantity WHERE ItemId = @itemId";
                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn, transaction);
                            updateCmd.Parameters.AddWithValue("@quantity", nudQuantity.Value);
                            updateCmd.Parameters.AddWithValue("@itemId", cmbItem.SelectedValue);
                            updateCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            // Insert new inventory record
                            string insertQuery = "INSERT INTO Inventory (ItemId, Quantity) VALUES (@itemId, @quantity)";
                            MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn, transaction);
                            insertCmd.Parameters.AddWithValue("@itemId", cmbItem.SelectedValue);
                            insertCmd.Parameters.AddWithValue("@quantity", nudQuantity.Value);
                            insertCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"Delivery saved successfully!\n\nItem: {cmbItem.Text}\nQuantity: {nudQuantity.Value}\nInventory updated.", 
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form
                        GenerateDeliveryId();
                        nudQuantity.Value = 1;
                        DisplayCurrentStock();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving delivery: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nudQuantity.Value = 1;
            if (cmbItem.Items.Count > 0)
                cmbItem.SelectedIndex = 0;
            dtpDeliveryDate.Value = DateTime.Now;
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
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
