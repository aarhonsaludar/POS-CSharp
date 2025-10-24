using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySqlConnector;

namespace POS
{
    public partial class MaintenanceForm : Form
    {
        // Track selected IDs for editing
        private string selectedUsername = null;
        private int selectedCategoryId = 0;
        private int selectedSupplierId = 0;
        private int selectedItemId = 0;

        public MaintenanceForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
            
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
            ClearUserFields();
        }

        private void btnNavCategory_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavCategory);
            ShowPanel(pnlCategory);
            ClearCategoryFields();
        }

        private void btnNavSupplier_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavSupplier);
            ShowPanel(pnlSupplier);
            ClearSupplierFields();
        }

        private void btnNavItems_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNavItems);
            ShowPanel(pnlItems);
            ClearItemFields();
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

        // ===== USERS TAB =====
        private void LoadUsers()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT username, CASE WHEN LENGTH(password) > 20 THEN '[Hashed]' ELSE '[Plain Text - Update Required]' END AS password_status FROM Users", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                    
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

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                selectedUsername = row.Cells["username"].Value.ToString();
                txtUserUsername.Text = selectedUsername;
                txtUserPassword.Clear();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserUsername.Text) || string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("Please enter username and password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    string hashedPassword = PasswordHelper.HashPassword(password);
                    string query = "INSERT INTO Users (username, password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUserUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.ExecuteNonQuery();
                    
                    string strengthMessage = PasswordHelper.GetPasswordStrengthMessage(password);
                    MessageBox.Show($"User added successfully!\n\nPassword Strength: {strengthMessage}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    ClearUserFields();
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("This username already exists!", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUsername))
            {
                MessageBox.Show("Please select a user to edit!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                MessageBox.Show("Please enter a new password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    string hashedPassword = PasswordHelper.HashPassword(password);
                    string query = "UPDATE Users SET password = @password WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@username", selectedUsername);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("User password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                    ClearUserFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUsername))
            {
                MessageBox.Show("Please select a user to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete user '{selectedUsername}'?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Users WHERE username = @username";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", selectedUsername);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                        ClearUserFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearUserFields()
        {
            txtUserUsername.Clear();
            txtUserPassword.Clear();
            selectedUsername = null;
            txtUserUsername.Focus();
        }

        // ===== CATEGORY TAB =====
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

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];
                selectedCategoryId = Convert.ToInt32(row.Cells["CategoryId"].Value);
                txtCategoryName.Text = row.Cells["CategoryName"].Value.ToString();
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
                    ClearCategoryFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category to edit!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    string query = "UPDATE ItemCategory SET CategoryName = @name WHERE CategoryId = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedCategoryId);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCategories();
                    ClearCategoryFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == 0)
            {
                MessageBox.Show("Please select a category to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete this category?\n\nWarning: This will also affect items in this category!", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM ItemCategory WHERE CategoryId = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedCategoryId);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Category deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCategories();
                        ClearCategoryFields();
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1451) // Foreign key constraint
                {
                    MessageBox.Show("Cannot delete this category because it has associated items. Please delete the items first.", 
                        "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearCategoryFields()
        {
            txtCategoryName.Clear();
            selectedCategoryId = 0;
            txtCategoryName.Focus();
        }

        // ===== SUPPLIER TAB =====
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

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                selectedSupplierId = Convert.ToInt32(row.Cells["SupplierId"].Value);
                txtSupplierName.Text = row.Cells["SupplierName"].Value.ToString();
                txtSupplierAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                txtSupplierContact.Text = row.Cells["ContactNumber"].Value?.ToString() ?? "";
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
                    ClearSupplierFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Please select a supplier to edit!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    string query = "UPDATE Supplier SET SupplierName = @name, Address = @address, ContactNumber = @contact WHERE SupplierId = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtSupplierName.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", txtSupplierAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", txtSupplierContact.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedSupplierId);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Supplier updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                    ClearSupplierFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (selectedSupplierId == 0)
            {
                MessageBox.Show("Please select a supplier to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete this supplier?", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Supplier WHERE SupplierId = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedSupplierId);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSuppliers();
                        ClearSupplierFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearSupplierFields()
        {
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierContact.Clear();
            selectedSupplierId = 0;
            txtSupplierName.Focus();
        }

        // ===== ITEMS TAB =====
        private void LoadItems()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT i.ItemId, i.ItemName, c.CategoryName, i.CategoryId, i.BasePrice, IFNULL(inv.Quantity, 0) AS Stock 
                                   FROM Items i 
                                   INNER JOIN ItemCategory c ON i.CategoryId = c.CategoryId
                                   LEFT JOIN Inventory inv ON i.ItemId = inv.ItemId
                                   ORDER BY i.ItemName";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvItems.DataSource = dt;

                    if (dgvItems.Columns.Count > 0)
                    {
                        dgvItems.Columns["ItemId"].HeaderText = "Item ID";
                        dgvItems.Columns["ItemName"].HeaderText = "Item Name";
                        dgvItems.Columns["CategoryName"].HeaderText = "Category";
                        dgvItems.Columns["CategoryId"].Visible = false; // Hide CategoryId
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

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItems.Rows[e.RowIndex];
                selectedItemId = Convert.ToInt32(row.Cells["ItemId"].Value);
                txtItemName.Text = row.Cells["ItemName"].Value.ToString();
                txtItemPrice.Text = row.Cells["BasePrice"].Value.ToString();
                
                // Set category
                int categoryId = Convert.ToInt32(row.Cells["CategoryId"].Value);
                cmbItemCategory.SelectedValue = categoryId;
                
                // Set current stock (read-only, shown for reference)
                nudInitialStock.Value = Convert.ToInt32(row.Cells["Stock"].Value);
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
                        string itemQuery = "INSERT INTO Items (ItemName, CategoryId, BasePrice) VALUES (@name, @categoryId, @price)";
                        MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@name", txtItemName.Text.Trim());
                        itemCmd.Parameters.AddWithValue("@categoryId", cmbItemCategory.SelectedValue);
                        itemCmd.Parameters.AddWithValue("@price", price);
                        itemCmd.ExecuteNonQuery();

                        long itemId = itemCmd.LastInsertedId;

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
                        ClearItemFields();
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

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please select an item to edit!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an item name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        // Update item details
                        string itemQuery = "UPDATE Items SET ItemName = @name, CategoryId = @categoryId, BasePrice = @price WHERE ItemId = @id";
                        MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@name", txtItemName.Text.Trim());
                        itemCmd.Parameters.AddWithValue("@categoryId", cmbItemCategory.SelectedValue);
                        itemCmd.Parameters.AddWithValue("@price", price);
                        itemCmd.Parameters.AddWithValue("@id", selectedItemId);
                        itemCmd.ExecuteNonQuery();

                        // Update inventory if needed
                        int newStock = (int)nudInitialStock.Value;
                        string checkInventory = "SELECT COUNT(*) FROM Inventory WHERE ItemId = @itemId";
                        MySqlCommand checkCmd = new MySqlCommand(checkInventory, conn, transaction);
                        checkCmd.Parameters.AddWithValue("@itemId", selectedItemId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Update existing inventory
                            string updateInvQuery = "UPDATE Inventory SET Quantity = @quantity WHERE ItemId = @itemId";
                            MySqlCommand updateInvCmd = new MySqlCommand(updateInvQuery, conn, transaction);
                            updateInvCmd.Parameters.AddWithValue("@quantity", newStock);
                            updateInvCmd.Parameters.AddWithValue("@itemId", selectedItemId);
                            updateInvCmd.ExecuteNonQuery();
                        }
                        else if (newStock > 0)
                        {
                            // Insert new inventory record
                            string insertInvQuery = "INSERT INTO Inventory (ItemId, Quantity) VALUES (@itemId, @quantity)";
                            MySqlCommand insertInvCmd = new MySqlCommand(insertInvQuery, conn, transaction);
                            insertInvCmd.Parameters.AddWithValue("@itemId", selectedItemId);
                            insertInvCmd.Parameters.AddWithValue("@quantity", newStock);
                            insertInvCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadItems();
                        ClearItemFields();
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

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (selectedItemId == 0)
            {
                MessageBox.Show("Please select an item to delete!", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete this item?\n\nWarning: This will also delete inventory and sales records!", 
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        MySqlTransaction transaction = conn.BeginTransaction();

                        try
                        {
                            // Delete from Inventory first (if exists)
                            string deleteInvQuery = "DELETE FROM Inventory WHERE ItemId = @itemId";
                            MySqlCommand deleteInvCmd = new MySqlCommand(deleteInvQuery, conn, transaction);
                            deleteInvCmd.Parameters.AddWithValue("@itemId", selectedItemId);
                            deleteInvCmd.ExecuteNonQuery();

                            // Delete the item
                            string deleteItemQuery = "DELETE FROM Items WHERE ItemId = @itemId";
                            MySqlCommand deleteItemCmd = new MySqlCommand(deleteItemQuery, conn, transaction);
                            deleteItemCmd.Parameters.AddWithValue("@itemId", selectedItemId);
                            deleteItemCmd.ExecuteNonQuery();

                            transaction.Commit();
                            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadItems();
                            ClearItemFields();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (MySqlException ex) when (ex.Number == 1451) // Foreign key constraint
                {
                    MessageBox.Show("Cannot delete this item because it has associated records (sales or deliveries). Please delete those records first.", 
                        "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearItemFields()
        {
            txtItemName.Clear();
            txtItemPrice.Clear();
            nudInitialStock.Value = 0;
            selectedItemId = 0;
            if (cmbItemCategory.Items.Count > 0)
                cmbItemCategory.SelectedIndex = 0;
            txtItemName.Focus();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Legacy method - kept for compatibility
        }
    }
}