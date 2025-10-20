    using System;
    using System.Windows.Forms;

    namespace POS
    {
        public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void btnMaintenance_Click(object sender, EventArgs e)
            {
                MaintenanceForm maintenanceForm = new MaintenanceForm();
                maintenanceForm.ShowDialog();
            }

            private void btnPOS_Click(object sender, EventArgs e)
            {
                POSForm posForm = new POSForm();
                posForm.ShowDialog();
            }

            private void btnLogout_Click(object sender, EventArgs e)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }

            private void lblTitle_Click(object sender, EventArgs e)
            {

            }

            private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit(); // Forces all message loops to end and closes the app
            }

        }
    }
