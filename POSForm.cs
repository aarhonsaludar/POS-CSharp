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
            InitializeCart();
            LoadItems();
            this.Activated += POSForm_Activated;
        }

        private void POSForm_Activated(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void InitializeCart()
        {
            cartTable = new DataTable();
            cartTable.Columns.Add("ItemId", typeof(int));
            cartTable.Columns.Add("Item Name", typeof(string));
            cartTable.Columns.Add("Price", typeof(decimal));
            cartTable.Columns.Add("Quantity", typeof(int));
            cartTable.Columns.Add("Total", typeof(decimal));
            dgvCart.DataSource = cartTable;

            // Hide ItemId column
            if (dgvCart.Columns["ItemId"] != null)
                dgvCart.Columns["ItemId"].Visible = false;
        }

        private void LoadItems()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT ItemId, ItemName, BasePrice FROM Items";
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
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedValue == null)
            {
                MessageBox.Show("Please select an item!");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity!");
                return;
            }

            DataRowView selectedRow = (DataRowView)cmbItems.SelectedItem;
            int itemId = Convert.ToInt32(selectedRow["ItemId"]);
            string itemName = selectedRow["ItemName"].ToString();
            decimal price = Convert.ToDecimal(selectedRow["BasePrice"]);
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
                cartTable.Rows.Add(itemId, itemName, price, quantity, total);
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
                MessageBox.Show("Cart is empty!");
                return;
            }

            MessageBox.Show("Checkout completed! Total: " + lblTotalAmount.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cartTable.Clear();
            CalculateTotal();
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItems();
        }
        private void POSForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Forces all message loops to end and closes the app
        }
    }
}
