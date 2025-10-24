using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace POS
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Ensure the user icon is set properly
            try
            {
                // Make sure the PictureBox image is set
                IcoUser.Image = Properties.Resources.User;
                IcoUser.SizeMode = PictureBoxSizeMode.StretchImage;
                IcoUser.Visible = true;
                IcoUser.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user icon: " + ex.Message);
            }
            
            LoadAllData();
            ShowPanel(pnlUsers); // Show Users panel by default
            SetActiveButton(btnNavUsers); // Highlight Users button by default
        }

        private void LoadAllData()
        {
            LoadUsers();
            LoadCategories();
            LoadSuppliers();
            LoadItems();
        }

        // Navigation methods for sidebar
        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavUsers);
            ShowPanel(pnlUsers);
        }

        private void btnNavCategory_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavCategory);
            ShowPanel(pnlCategory);
        }

        private void btnNavSupplier_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavSupplier);
            ShowPanel(pnlSupplier);
        }

        private void btnNavItems_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavItems);
            ShowPanel(pnlItems);
        }

        // Back button to return to main form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Helper method to show selected panel and hide others
        private void ShowPanel(Panel panelToShow)
        {
            pnlUsers.Visible = false;
            pnlCategory.Visible = false;
            pnlSupplier.Visible = false;
            pnlItems.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        // Helper method to highlight active button
        private void SetActiveButton(Button activeButton)
        {
            Color defaultColor = Color.FromArgb(52, 73, 94);
            Color activeColor = Color.FromArgb(41, 128, 185);

            // Reset all buttons
            btnNavUsers.BackColor = defaultColor;
            btnNavCategory.BackColor = defaultColor;
            btnNavSupplier.BackColor = defaultColor;
            btnNavItems.BackColor = defaultColor;

            // Set active button
            activeButton.BackColor = activeColor;
        }

        // USERS TAB
        private void LoadUsers()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Query without UserId - the Users table likely only has username and password
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT username, CASE WHEN LENGTH(password) > 20 THEN '[Hashed]' ELSE '[Plain Text - Update Required]' END AS password_status FROM Users", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                    
                    // Format columns
                    if (dgvUsers.Columns.Count > 0)
                    {
                        dgvUsers.Columns["username"].HeaderText = "Username";
                        dgvUsers.Columns["password_status"].HeaderText = "Password Status";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserUsername.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("Please enter username and password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate password strength
            string password = txtUserPassword.Text;
            if (!PasswordHelper.ValidatePasswordStrength(password))
            {
                MessageBox.Show("Password must be at least 6 characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    
                    // Hash the password before storing
                    string hashedPassword = PasswordHelper.HashPassword(password);
                    
                    string query = "INSERT INTO Users (username, password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUserUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.ExecuteNonQuery();
                    
                    string strengthMessage = PasswordHelper.GetPasswordStrengthMessage(password);
                    MessageBox.Show($"User added successfully!\n\nPassword Strength: {strengthMessage}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    txtUserUsername.Clear();
                    txtUserPassword.Clear();
                    txtUserUsername.Focus();
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062) // Duplicate entry error
            {
                MessageBox.Show("This username already exists!", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CATEGORY TAB
        private void LoadCategories()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT CategoryId, CategoryName FROM ItemCategory", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCategory.DataSource = dt;

                    // Format columns
                    if (dgvCategory.Columns.Count > 0)
                    {
                        dgvCategory.Columns["CategoryId"].HeaderText = "Category ID";
                        dgvCategory.Columns["CategoryName"].HeaderText = "Category Name";
                    }

                    // Also load to combo box in Items tab
                    cmbItemCategory.DataSource = dt.Copy();
                    cmbItemCategory.DisplayMember = "CategoryName";
                    cmbItemCategory.ValueMember = "CategoryId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter a category name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO ItemCategory (CategoryName) VALUES (@name)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    txtCategoryName.Clear();
                    txtCategoryName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SUPPLIER TAB
        private void LoadSuppliers()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT SupplierId, SupplierName, Address, ContactNumber FROM Supplier", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSupplier.DataSource = dt;

                    // Format columns
                    if (dgvSupplier.Columns.Count > 0)
                    {
                        dgvSupplier.Columns["SupplierId"].HeaderText = "Supplier ID";
                        dgvSupplier.Columns["SupplierName"].HeaderText = "Supplier Name";
                        dgvSupplier.Columns["Address"].HeaderText = "Address";
                        dgvSupplier.Columns["ContactNumber"].HeaderText = "Contact Number";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Please enter a supplier name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Supplier (SupplierName, Address, ContactNumber) VALUES (@name, @address, @contact)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtSupplierName.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtSupplierAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtSupplierContact.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                    txtSupplierName.Clear();
                    txtSupplierAddress.Clear();
                    txtSupplierContact.Clear();
                    txtSupplierName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ITEMS TAB
        private void LoadItems()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT i.ItemId, i.ItemName, c.CategoryName, i.BasePrice, IFNULL(inv.Quantity, 0) AS Stock 
                                   FROM Items i 
                                   INNER JOIN ItemCategory c ON i.CategoryId = c.CategoryId
                                   LEFT JOIN Inventory inv ON i.ItemId = inv.ItemId
                                   ORDER BY i.ItemName";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvItems.DataSource = dt;

                    // Format columns
                    if (dgvItems.Columns.Count > 0)
                    {
                        dgvItems.Columns["ItemId"].HeaderText = "Item ID";
                        dgvItems.Columns["ItemName"].HeaderText = "Item Name";
                        dgvItems.Columns["CategoryName"].HeaderText = "Category";
                        dgvItems.Columns["BasePrice"].HeaderText = "Base Price";
                        dgvItems.Columns["BasePrice"].DefaultCellStyle.Format = "₱#,##0.00";
                        dgvItems.Columns["Stock"].HeaderText = "Current Stock";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an item name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbItemCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtItemPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        // Insert item
                        string itemQuery = "INSERT INTO Items (ItemName, CategoryId, BasePrice) VALUES (@name, @categoryId, @price)";
                        MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@name", txtItemName.Text.Trim());
                        itemCmd.Parameters.AddWithValue("@categoryId", cmbItemCategory.SelectedValue);
                        itemCmd.Parameters.AddWithValue("@price", price);
                        itemCmd.ExecuteNonQuery();

                        // Get the newly inserted ItemId
                        long itemId = itemCmd.LastInsertedId;

                        // Insert initial stock if quantity is greater than 0
                        int initialStock = (int)nudInitialStock.Value;
                        if (initialStock > 0)
                        {
                            string inventoryQuery = "INSERT INTO Inventory (ItemId, Quantity) VALUES (@itemId, @quantity)";
                            MySqlCommand inventoryCmd = new MySqlCommand(inventoryQuery, conn, transaction);
                            inventoryCmd.Parameters.AddWithValue("@itemId", itemId);
                            inventoryCmd.Parameters.AddWithValue("@quantity", initialStock);
                            inventoryCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show($"Item added successfully!\n\nItem: {txtItemName.Text}\nPrice: ₱{price:N2}\nInitial Stock: {initialStock}", 
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        LoadItems();
                        txtItemName.Clear();
                        txtItemPrice.Clear();
                        nudInitialStock.Value = 0;
                        txtItemName.Focus();
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click if needed
        }
    }
}