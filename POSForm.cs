using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace POS
{
    public partial class POSForm : Form
    {
        private DataTable cartTable;

        public POSForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeCart();
            LoadItems();
            GenerateReceiptId();
            this.Activated += POSForm_Activated;
        }

        private void POSForm_Activated(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void GenerateReceiptId()
        {
            // Generate receipt ID based on timestamp
            txtReceiptId.Text = "R" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void InitializeCart()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("ItemId", typeof(int));
            cartTable.Columns.Add("Item Name", typeof(string));
            cartTable.Columns.Add("Price", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Available", typeof(int));
            cartTable.Columns.Add("Total", typeof(decimal));
            dgvCart.DataSource = cartTable;

            // Hide ItemId and Available columns
            if (dgvCart.Columns["ItemId"] != null)
                dgvCart.Columns["ItemId"].Visible = false;
            if (dgvCart.Columns["Available"] != null)
                dgvCart.Columns["Available"].Visible = false;
        }

        private void LoadItems()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ItemId, ItemName, BasePrice FROM Items ORDER BY ItemName";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Store current selection
                    object currentValue = cmbItems.SelectedValue;

                    cmbItems.DataSource = dt;
                    cmbItems.DisplayMember = "ItemName";
                    cmbItems.ValueMember = "ItemId";

                    // Restore selection if it still exists
                    if (currentValue != null && dt.Rows.Count > 0)
                    {
                        cmbItems.SelectedValue = currentValue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetAvailableStock(int itemId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT IFNULL(Quantity, 0) FROM Inventory WHERE ItemId = @itemId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemId", itemId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
            catch
            {
                return 0;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedValue == null)
            {
                MessageBox.Show("Please select an item!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selectedRow = (DataRowView)cmbItems.SelectedItem;
            int itemId = Convert.ToInt32(selectedRow["ItemId"]);
            string itemName = selectedRow["ItemName"].ToString();
            decimal price = Convert.ToDecimal(selectedRow["BasePrice"]);

            // Check available stock
            int availableStock = GetAvailableStock(itemId);

            // Check if item already in cart
            int cartQuantity = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                if (Convert.ToInt32(row["ItemId"]) == itemId)
                {
                    cartQuantity = Convert.ToInt32(row["Quantity"]);
                    break;
                }
            }

            // Validate stock availability
            if (cartQuantity + quantity > availableStock)
            {
                MessageBox.Show($"Insufficient stock! Available: {availableStock}, In cart: {cartQuantity}",
                    "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal total = price * quantity;

            // Check if item already exists in cart
            bool itemExists = false;
            foreach (DataRow row in cartTable.Rows)
            {
                if (Convert.ToInt32(row["ItemId"]) == itemId)
                {
                    row["Quantity"] = Convert.ToInt32(row["Quantity"]) + quantity;
                    row["Total"] = Convert.ToDecimal(row["Price"]) * Convert.ToInt32(row["Quantity"]);
                    itemExists = true;
                    break;
                }
            }

            if (!itemExists)
            {
                cartTable.Rows.Add(itemId, itemName, price, quantity, availableStock, total);
            }

            CalculateTotal();
            txtQuantity.Text = "1";
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                total += Convert.ToDecimal(row["Total"]);
            }
            lblTotalAmount.Text = "₱" + total.ToString("N2");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        string receiptId = txtReceiptId.Text;
                        DateTime receiptDate = DateTime.Now;

                        foreach (DataRow row in cartTable.Rows)
                        {
                            int itemId = Convert.ToInt32(row["ItemId"]);
                            int quantity = Convert.ToInt32(row["Quantity"]);
                            decimal totalAmount = Convert.ToDecimal(row["Total"]);

                            // Insert sales record
                            string salesQuery = @"INSERT INTO Sales (ReceiptId, ReceiptDate, ItemId, Quantity, TotalAmount) 
                                                VALUES (@receiptId, @receiptDate, @itemId, @quantity, @totalAmount)";
                            MySqlCommand salesCmd = new MySqlCommand(salesQuery, conn, transaction);
                            salesCmd.Parameters.AddWithValue("@receiptId", receiptId);
                            salesCmd.Parameters.AddWithValue("@receiptDate", receiptDate);
                            salesCmd.Parameters.AddWithValue("@itemId", itemId);
                            salesCmd.Parameters.AddWithValue("@quantity", quantity);
                            salesCmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                            salesCmd.ExecuteNonQuery();

                            // Update inventory (deduct quantity)
                            string inventoryQuery = "UPDATE Inventory SET Quantity = Quantity - @quantity WHERE ItemId = @itemId";
                            MySqlCommand inventoryCmd = new MySqlCommand(inventoryQuery, conn, transaction);
                            inventoryCmd.Parameters.AddWithValue("@quantity", quantity);
                            inventoryCmd.Parameters.AddWithValue("@itemId", itemId);
                            inventoryCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"Checkout completed successfully!\n\nReceipt ID: {receiptId}\nTotal: {lblTotalAmount.Text}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset form
                        cartTable.Clear();
                        CalculateTotal();
                        GenerateReceiptId();
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
                MessageBox.Show("Error processing checkout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
                CalculateTotal();
                MessageBox.Show("Item removed from cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an item to remove!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItems.SelectedValue != null && cmbItems.SelectedValue is int)
            {
                int availableStock = GetAvailableStock(Convert.ToInt32(cmbItems.SelectedValue));
                lblAvailableStock.Text = $"Available Stock: {availableStock}";
            }
        }

        private void POSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Don't exit application, just close the form
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
