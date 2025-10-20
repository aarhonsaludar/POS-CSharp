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

            
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit(); // Ensures the application exits when the main form is closed
        }


        }
    }
