using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    /// <summary>
    /// Centralized navigation helper for the POS system
    /// Handles form navigation and lifecycle management
    /// </summary>
    public static class NavigationHelper
    {
        /// <summary>
        /// Navigate from one form to another with proper lifecycle management
        /// </summary>
        /// <param name="sourceForm">The current form to hide/close</param>
        /// <param name="targetFormName">The name of the form to navigate to</param>
        public static void NavigateTo(Form sourceForm, string targetFormName)
        {
            Form targetForm = CreateForm(targetFormName);

            if (targetForm != null)
            {
                // Hide source form
                sourceForm.Hide();

                // When target form closes, close source form
                targetForm.FormClosed += (s, args) => sourceForm.Close();

                // Show target form as dialog
                targetForm.ShowDialog();
            }
        }

        /// <summary>
        /// Creates a form instance based on the form name
        /// </summary>
        private static Form CreateForm(string formName)
        {
            switch (formName.ToLower())
            {
                case "maintenance":
                    return new MaintenanceForm();
                case "delivery":
                    return new DeliveryForm();
                case "inventory":
                    return new InventoryMonitoringForm();
                case "pos":
                    return new POSForm();
                case "sales":
                    return new SalesMonitoringForm();
                case "backup":
                    return new BackupRestoreForm();
                case "mainmenu":
                case "main":
                    // Don't create a new form, just return null to close current
                    return null;
                default:
                    MessageBox.Show($"Unknown form: {formName}", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
            }
        }

        /// <summary>
        /// Return to the main menu by closing the current form
        /// </summary>
        public static void ReturnToMainMenu(Form currentForm)
        {
            currentForm.Close();
        }

        /// <summary>
        /// Setup navigation panel for a form
        /// </summary>
        /// <param name="form">The form to setup navigation for</param>
        /// <param name="currentModule">The current module name for highlighting</param>
        public static Panel CreateNavigationPanel(Form form, string currentModule)
        {
            Panel pnlNavigation = new Panel
            {
                BackColor = Color.FromArgb(52, 73, 94),
                Dock = DockStyle.Top,
                Height = 60,
                Name = "pnlNavigation"
            };

            // Title label
            Label lblTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(15, 18),
                Text = $"?? POS System - {currentModule}",
                Name = "lblNavTitle"
            };
            pnlNavigation.Controls.Add(lblTitle);

            // Navigation buttons
            Color defaultColor = Color.FromArgb(52, 73, 94);
            Color activeColor = Color.FromArgb(41, 128, 185);
            Color hoverColor = Color.FromArgb(41, 128, 185);

            // Button configurations
            var buttons = new[]
            {
                new { Name = "Maintenance", Text = "?? Maintenance", Location = new Point(270, 15), Module = "maintenance" },
                new { Name = "Delivery", Text = "?? Delivery", Location = new Point(410, 15), Module = "delivery" },
                new { Name = "Inventory", Text = "?? Inventory", Location = new Point(510, 15), Module = "inventory" },
                new { Name = "POS", Text = "?? POS", Location = new Point(620, 15), Module = "pos" },
                new { Name = "Sales", Text = "?? Sales", Location = new Point(695, 15), Module = "sales" }
            };

            foreach (var btnConfig in buttons)
            {
                Button btn = new Button
                {
                    BackColor = btnConfig.Module.ToLower() == currentModule.ToLower() ? activeColor : defaultColor,
                    Cursor = Cursors.Hand,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = btnConfig.Location,
                    Name = "btnNav" + btnConfig.Name,
                    Size = new Size(btnConfig.Text == "?? Maintenance" ? 130 : 
                                   btnConfig.Text == "?? Delivery" ? 90 :
                                   btnConfig.Text == "?? Inventory" ? 100 :
                                   btnConfig.Text == "?? POS" ? 65 : 75, 30),
                    Text = btnConfig.Text,
                    UseVisualStyleBackColor = false
                };

                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = hoverColor;

                // Add click event handler
                string targetModule = btnConfig.Module;
                btn.Click += (s, e) => NavigateTo(form, targetModule);

                pnlNavigation.Controls.Add(btn);
            }

            // Main Menu button (different color)
            Button btnMainMenu = new Button
            {
                BackColor = Color.FromArgb(231, 76, 60),
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(780, 15),
                Name = "btnNavMainMenu",
                Size = new Size(100, 30),
                Text = "?? Main Menu",
                UseVisualStyleBackColor = false
            };
            btnMainMenu.FlatAppearance.BorderSize = 0;
            btnMainMenu.Click += (s, e) => ReturnToMainMenu(form);

            pnlNavigation.Controls.Add(btnMainMenu);

            return pnlNavigation;
        }

        /// <summary>
        /// Highlight the active navigation button
        /// </summary>
        public static void HighlightActiveModule(Panel navigationPanel, string moduleName)
        {
            Color defaultColor = Color.FromArgb(52, 73, 94);
            Color activeColor = Color.FromArgb(41, 128, 185);

            foreach (Control control in navigationPanel.Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("btnNav") && !btn.Name.Contains("MainMenu"))
                {
                    btn.BackColor = defaultColor;
                    
                    // Highlight active module
                    if (btn.Name.ToLower().Contains(moduleName.ToLower()))
                    {
                        btn.BackColor = activeColor;
                    }
                }
            }
        }
    }
}
