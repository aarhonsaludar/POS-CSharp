using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace POS
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadUsers();
            LoadCategories();
            LoadSuppliers();
            LoadItems();
        }

        // USERS TAB
        private void LoadUsers()
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Users", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Users (username, password) VALUES (@username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", txtUserUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtUserPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!");
                    LoadUsers();
                    txtUserUsername.Clear();
                    txtUserPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ItemCategory", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCategory.DataSource = dt;

                    // Also load to combo box in Items tab
                    cmbItemCategory.DataSource = dt.Copy();
                    cmbItemCategory.DisplayMember = "CategoryName";
                    cmbItemCategory.ValueMember = "CategoryId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO ItemCategory (CategoryName) VALUES (@name)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtCategoryName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category added successfully!");
                    LoadCategories();
                    txtCategoryName.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM Supplier", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSupplier.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Supplier (SupplierName, Address, ContactNumber) VALUES (@name, @address, @contact)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@address", txtSupplierAddress.Text);
                    cmd.Parameters.AddWithValue("@contact", txtSupplierContact.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier added successfully!");
                    LoadSuppliers();
                    txtSupplierName.Clear();
                    txtSupplierAddress.Clear();
                    txtSupplierContact.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    string query = @"SELECT i.ItemId, i.ItemName, c.CategoryName, i.BasePrice 
                                   FROM Items i 
                                   INNER JOIN ItemCategory c ON i.CategoryId = c.CategoryId";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvItems.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Items (ItemName, CategoryId, BasePrice) VALUES (@name, @categoryId, @price)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@categoryId", cmbItemCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtItemPrice.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully!");
                    LoadItems();
                    txtItemName.Clear();
                    txtItemPrice.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void MaintenanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Forces all message loops to end and closes the app
        }
    }
}