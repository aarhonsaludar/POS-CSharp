namespace POS
{
    partial class MaintenanceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.TabPage tabItems;

        // Users Tab Controls
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtUserUsername;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblUserUsername;
        private System.Windows.Forms.Label lblUserPassword;

        // Category Tab Controls
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblCategoryName;

        // Supplier Tab Controls
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierContact;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierContact;

        // Items Tab Controls
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox cmbItemCategory;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemCategory;
        private System.Windows.Forms.Label lblItemPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserUsername = new System.Windows.Forms.TextBox();
            this.lblUserUsername = new System.Windows.Forms.Label();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSupplierContact = new System.Windows.Forms.TextBox();
            this.lblSupplierContact = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.tabSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Controls.Add(this.tabCategory);
            this.tabControl.Controls.Add(this.tabSupplier);
            this.tabControl.Controls.Add(this.tabItems);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1090, 631);
            this.tabControl.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dgvUsers);
            this.tabUsers.Controls.Add(this.btnAddUser);
            this.tabUsers.Controls.Add(this.txtUserPassword);
            this.tabUsers.Controls.Add(this.lblUserPassword);
            this.tabUsers.Controls.Add(this.txtUserUsername);
            this.tabUsers.Controls.Add(this.lblUserUsername);
            this.tabUsers.Location = new System.Drawing.Point(4, 25);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(4);
            this.tabUsers.Size = new System.Drawing.Size(1082, 602);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(27, 98);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(1000, 455);
            this.dgvUsers.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(427, 37);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(133, 31);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(133, 58);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(265, 22);
            this.txtUserPassword.TabIndex = 3;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(27, 62);
            this.lblUserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(70, 16);
            this.lblUserPassword.TabIndex = 6;
            this.lblUserPassword.Text = "Password:";
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.Location = new System.Drawing.Point(133, 21);
            this.txtUserUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Size = new System.Drawing.Size(265, 22);
            this.txtUserUsername.TabIndex = 1;
            // 
            // lblUserUsername
            // 
            this.lblUserUsername.AutoSize = true;
            this.lblUserUsername.Location = new System.Drawing.Point(27, 25);
            this.lblUserUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserUsername.Name = "lblUserUsername";
            this.lblUserUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUserUsername.TabIndex = 7;
            this.lblUserUsername.Text = "Username:";
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.dgvCategory);
            this.tabCategory.Controls.Add(this.btnAddCategory);
            this.tabCategory.Controls.Add(this.txtCategoryName);
            this.tabCategory.Controls.Add(this.lblCategoryName);
            this.tabCategory.Location = new System.Drawing.Point(4, 25);
            this.tabCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(4);
            this.tabCategory.Size = new System.Drawing.Size(1082, 602);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Item Category";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(27, 74);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.Size = new System.Drawing.Size(1000, 480);
            this.dgvCategory.TabIndex = 3;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(453, 18);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(133, 31);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(160, 21);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(265, 22);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(27, 25);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(105, 16);
            this.lblCategoryName.TabIndex = 4;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // tabSupplier
            // 
            this.tabSupplier.Controls.Add(this.dgvSupplier);
            this.tabSupplier.Controls.Add(this.btnAddSupplier);
            this.tabSupplier.Controls.Add(this.txtSupplierContact);
            this.tabSupplier.Controls.Add(this.lblSupplierContact);
            this.tabSupplier.Controls.Add(this.txtSupplierAddress);
            this.tabSupplier.Controls.Add(this.lblSupplierAddress);
            this.tabSupplier.Controls.Add(this.txtSupplierName);
            this.tabSupplier.Controls.Add(this.lblSupplierName);
            this.tabSupplier.Location = new System.Drawing.Point(4, 25);
            this.tabSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Size = new System.Drawing.Size(1082, 602);
            this.tabSupplier.TabIndex = 2;
            this.tabSupplier.Text = "Supplier";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(27, 135);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.Size = new System.Drawing.Size(1000, 418);
            this.dgvSupplier.TabIndex = 7;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(453, 55);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(133, 31);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSupplierContact
            // 
            this.txtSupplierContact.Location = new System.Drawing.Point(160, 95);
            this.txtSupplierContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.Size = new System.Drawing.Size(265, 22);
            this.txtSupplierContact.TabIndex = 5;
            // 
            // lblSupplierContact
            // 
            this.lblSupplierContact.AutoSize = true;
            this.lblSupplierContact.Location = new System.Drawing.Point(27, 98);
            this.lblSupplierContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierContact.Name = "lblSupplierContact";
            this.lblSupplierContact.Size = new System.Drawing.Size(106, 16);
            this.lblSupplierContact.TabIndex = 8;
            this.lblSupplierContact.Text = "Contact Number:";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(160, 58);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(265, 22);
            this.txtSupplierAddress.TabIndex = 3;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Location = new System.Drawing.Point(27, 62);
            this.lblSupplierAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(61, 16);
            this.lblSupplierAddress.TabIndex = 9;
            this.lblSupplierAddress.Text = "Address:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(160, 21);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(265, 22);
            this.txtSupplierName.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(27, 25);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(100, 16);
            this.lblSupplierName.TabIndex = 10;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // tabItems
            // 
            this.tabItems.Controls.Add(this.dgvItems);
            this.tabItems.Controls.Add(this.btnAddItem);
            this.tabItems.Controls.Add(this.txtItemPrice);
            this.tabItems.Controls.Add(this.lblItemPrice);
            this.tabItems.Controls.Add(this.cmbItemCategory);
            this.tabItems.Controls.Add(this.lblItemCategory);
            this.tabItems.Controls.Add(this.txtItemName);
            this.tabItems.Controls.Add(this.lblItemName);
            this.tabItems.Location = new System.Drawing.Point(4, 25);
            this.tabItems.Margin = new System.Windows.Forms.Padding(4);
            this.tabItems.Name = "tabItems";
            this.tabItems.Size = new System.Drawing.Size(1082, 602);
            this.tabItems.TabIndex = 3;
            this.tabItems.Text = "Items";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(603, 21);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(400, 418);
            this.dgvItems.TabIndex = 7;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(116, 318);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(133, 31);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(64, 251);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(265, 22);
            this.txtItemPrice.TabIndex = 5;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Location = new System.Drawing.Point(142, 192);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(76, 16);
            this.lblItemPrice.TabIndex = 8;
            this.lblItemPrice.Text = "Base Price:";
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(64, 133);
            this.cmbItemCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(265, 24);
            this.cmbItemCategory.TabIndex = 3;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Location = new System.Drawing.Point(143, 98);
            this.lblItemCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(65, 16);
            this.lblItemCategory.TabIndex = 9;
            this.lblItemCategory.Text = "Category:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(64, 52);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(265, 22);
            this.txtItemName.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(143, 21);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(75, 16);
            this.lblItemName.TabIndex = 10;
            this.lblItemName.Text = "Item Name:";
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 631);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.tabControl.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.tabCategory.ResumeLayout(false);
            this.tabCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.tabSupplier.ResumeLayout(false);
            this.tabSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.tabItems.ResumeLayout(false);
            this.tabItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
