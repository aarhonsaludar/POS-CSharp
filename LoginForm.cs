using MySqlConnector;
using System;
using System.Windows.Forms;

namespace POS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // Center form on screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT password FROM Users WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPassword = result.ToString();
                        bool isAuthenticated = false;

                        // Check if password is hashed or plain text (for backward compatibility)
                        if (PasswordHelper.IsPlainText(storedPassword))
                        {
                            // Legacy plain text password - direct comparison
                            if (password == storedPassword)
                            {
                                isAuthenticated = true;

                                // Auto-upgrade to hashed password
                                string hashedPassword = PasswordHelper.HashPassword(password);
                                string updateQuery = "UPDATE Users SET password = @hashedPassword WHERE username = @username";
                                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                                updateCmd.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                                updateCmd.Parameters.AddWithValue("@username", username);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Hashed password - verify using PasswordHelper
                            isAuthenticated = PasswordHelper.VerifyPassword(password, storedPassword);
                        }

                        if (isAuthenticated)
                        {
                            // Clear password field for security
                            txtPassword.Clear();
                            
                            // Hide login form and show main form
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.FormClosed += (s, args) => this.Close(); // Close login when main closes
                            mainForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit application when login form is closed
            Application.Exit();
        }
    }
}
