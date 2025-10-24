namespace POS
{
    partial class MaintenanceForm
    {
        private System.ComponentModel.IContainer components = null;
        
        // Sidebar Controls
        internal System.Windows.Forms.Panel pnlSidebar;
        internal System.Windows.Forms.Button btnNavUsers;
        internal System.Windows.Forms.Button btnNavCategory;
        internal System.Windows.Forms.Button btnNavSupplier;
        internal System.Windows.Forms.Button btnNavItems;
        internal System.Windows.Forms.Label lblSidebarTitle;
        
        // Content Panels
        internal System.Windows.Forms.Panel pnlContent;
        internal System.Windows.Forms.Panel pnlUsers;
        internal System.Windows.Forms.Panel pnlCategory;
        internal System.Windows.Forms.Panel pnlSupplier;
        internal System.Windows.Forms.Panel pnlItems;

        // Users Tab Controls
        internal System.Windows.Forms.DataGridView dgvUsers;
        internal System.Windows.Forms.TextBox txtUserUsername;
        internal System.Windows.Forms.TextBox txtUserPassword;
        internal System.Windows.Forms.Button btnAddUser;
        internal System.Windows.Forms.Label lblUserUsername;
        internal System.Windows.Forms.Label lblUserPassword;

        // Category Tab Controls
        internal System.Windows.Forms.DataGridView dgvCategory;
        internal System.Windows.Forms.TextBox txtCategoryName;
        internal System.Windows.Forms.Button btnAddCategory;
        internal System.Windows.Forms.Label lblCategoryName;

        // Supplier Tab Controls
        internal System.Windows.Forms.DataGridView dgvSupplier;
        internal System.Windows.Forms.TextBox txtSupplierName;
        internal System.Windows.Forms.TextBox txtSupplierAddress;
        internal System.Windows.Forms.TextBox txtSupplierContact;
        internal System.Windows.Forms.Button btnAddSupplier;
        internal System.Windows.Forms.Label lblSupplierName;
        internal System.Windows.Forms.Label lblSupplierAddress;
        internal System.Windows.Forms.Label lblSupplierContact;

        // Items Tab Controls
        internal System.Windows.Forms.DataGridView dgvItems;
        internal System.Windows.Forms.TextBox txtItemName;
        internal System.Windows.Forms.ComboBox cmbItemCategory;
        internal System.Windows.Forms.TextBox txtItemPrice;
        internal System.Windows.Forms.NumericUpDown nudInitialStock;
        internal System.Windows.Forms.Button btnAddItem;
        internal System.Windows.Forms.Label lblItemName;
        internal System.Windows.Forms.Label lblItemCategory;
        internal System.Windows.Forms.Label lblItemPrice;
        internal System.Windows.Forms.Label lblInitialStock;

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
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnNavItems = new System.Windows.Forms.Button();
            this.btnNavSupplier = new System.Windows.Forms.Button();
            this.btnNavCategory = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.IcoUser = new System.Windows.Forms.PictureBox();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtUserUsername = new System.Windows.Forms.TextBox();
            this.lblUserUsername = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSupplierContact = new System.Windows.Forms.TextBox();
            this.lblSupplierContact = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.nudInitialStock = new System.Windows.Forms.NumericUpDown();
            this.lblInitialStock = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.cmbItemCategory = new System.Windows.Forms.ComboBox();
            this.lblItemCategory = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoUser)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.pnlSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlSidebar.Controls.Add(this.btnNavItems);
            this.pnlSidebar.Controls.Add(this.btnNavSupplier);
            this.pnlSidebar.Controls.Add(this.btnNavCategory);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.Controls.Add(this.IcoUser);
            this.pnlSidebar.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(333, 777);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnNavItems
            // 
            this.btnNavItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavItems.FlatAppearance.BorderSize = 0;
            this.btnNavItems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavItems.ForeColor = System.Drawing.Color.White;
            this.btnNavItems.Location = new System.Drawing.Point(0, 345);
            this.btnNavItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavItems.Name = "btnNavItems";
            this.btnNavItems.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnNavItems.Size = new System.Drawing.Size(333, 74);
            this.btnNavItems.TabIndex = 4;
            this.btnNavItems.Text = "Items";
            this.btnNavItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavItems.UseVisualStyleBackColor = false;
            this.btnNavItems.Click += new System.EventHandler(this.btnNavItems_Click);
            // 
            // btnNavSupplier
            // 
            this.btnNavSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSupplier.FlatAppearance.BorderSize = 0;
            this.btnNavSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSupplier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSupplier.ForeColor = System.Drawing.Color.White;
            this.btnNavSupplier.Location = new System.Drawing.Point(0, 271);
            this.btnNavSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavSupplier.Name = "btnNavSupplier";
            this.btnNavSupplier.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnNavSupplier.Size = new System.Drawing.Size(333, 74);
            this.btnNavSupplier.TabIndex = 3;
            this.btnNavSupplier.Text = "Supplier";
            this.btnNavSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSupplier.UseVisualStyleBackColor = false;
            this.btnNavSupplier.Click += new System.EventHandler(this.btnNavSupplier_Click);
            // 
            // btnNavCategory
            // 
            this.btnNavCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnNavCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavCategory.FlatAppearance.BorderSize = 0;
            this.btnNavCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavCategory.ForeColor = System.Drawing.Color.White;
            this.btnNavCategory.Location = new System.Drawing.Point(0, 197);
            this.btnNavCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavCategory.Name = "btnNavCategory";
            this.btnNavCategory.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnNavCategory.Size = new System.Drawing.Size(333, 74);
            this.btnNavCategory.TabIndex = 2;
            this.btnNavCategory.Text = "Item Category";
            this.btnNavCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavCategory.UseVisualStyleBackColor = false;
            this.btnNavCategory.Click += new System.EventHandler(this.btnNavCategory_Click);
            // 
            // btnNavUsers
            // 
            this.btnNavUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavUsers.ForeColor = System.Drawing.Color.White;
            this.btnNavUsers.Location = new System.Drawing.Point(0, 123);
            this.btnNavUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.btnNavUsers.Size = new System.Drawing.Size(333, 74);
            this.btnNavUsers.TabIndex = 1;
            this.btnNavUsers.Text = "Users";
            this.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsers.UseVisualStyleBackColor = false;
            this.btnNavUsers.Click += new System.EventHandler(this.btnNavUsers_Click);
            // 
            // IcoUser
            // 
            this.IcoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.IcoUser.Image = global::POS.Properties.Resources.User;
            this.IcoUser.Location = new System.Drawing.Point(32, 123);
            this.IcoUser.Name = "IcoUser";
            this.IcoUser.Size = new System.Drawing.Size(50, 50);
            this.IcoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IcoUser.TabIndex = 8;
            this.IcoUser.TabStop = false;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lblSidebarTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSidebarTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(333, 98);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "MAINTENANCE";
            this.lblSidebarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlUsers);
            this.pnlContent.Controls.Add(this.pnlCategory);
            this.pnlContent.Controls.Add(this.pnlSupplier);
            this.pnlContent.Controls.Add(this.pnlItems);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(333, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1120, 777);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.button1);
            this.pnlUsers.Controls.Add(this.dgvUsers);
            this.pnlUsers.Controls.Add(this.btnAddUser);
            this.pnlUsers.Controls.Add(this.txtUserPassword);
            this.pnlUsers.Controls.Add(this.lblUserPassword);
            this.pnlUsers.Controls.Add(this.txtUserUsername);
            this.pnlUsers.Controls.Add(this.lblUserUsername);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsers.Location = new System.Drawing.Point(0, 0);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1120, 777);
            this.pnlUsers.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1033, 727);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(27, 135);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(978, 615);
            this.dgvUsers.TabIndex = 5;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(569, 49);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(177, 43);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserPassword.Location = new System.Drawing.Point(177, 80);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(352, 30);
            this.txtUserPassword.TabIndex = 3;
            this.txtUserPassword.UseSystemPasswordChar = true;
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserPassword.Location = new System.Drawing.Point(27, 84);
            this.lblUserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(84, 23);
            this.lblUserPassword.TabIndex = 6;
            this.lblUserPassword.Text = "Password:";
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUserUsername.Location = new System.Drawing.Point(177, 31);
            this.txtUserUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Size = new System.Drawing.Size(352, 30);
            this.txtUserUsername.TabIndex = 1;
            // 
            // lblUserUsername
            // 
            this.lblUserUsername.AutoSize = true;
            this.lblUserUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUserUsername.Location = new System.Drawing.Point(27, 34);
            this.lblUserUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserUsername.Name = "lblUserUsername";
            this.lblUserUsername.Size = new System.Drawing.Size(91, 23);
            this.lblUserUsername.TabIndex = 7;
            this.lblUserUsername.Text = "Username:";
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.dgvCategory);
            this.pnlCategory.Controls.Add(this.btnAddCategory);
            this.pnlCategory.Controls.Add(this.txtCategoryName);
            this.pnlCategory.Controls.Add(this.lblCategoryName);
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(1120, 777);
            this.pnlCategory.TabIndex = 1;
            this.pnlCategory.Visible = false;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(27, 98);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersWidth = 51;
            this.dgvCategory.Size = new System.Drawing.Size(1067, 652);
            this.dgvCategory.TabIndex = 3;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(604, 25);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(200, 43);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategoryName.Location = new System.Drawing.Point(213, 31);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(352, 30);
            this.txtCategoryName.TabIndex = 1;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategoryName.Location = new System.Drawing.Point(27, 34);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(134, 23);
            this.lblCategoryName.TabIndex = 4;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Controls.Add(this.dgvSupplier);
            this.pnlSupplier.Controls.Add(this.btnAddSupplier);
            this.pnlSupplier.Controls.Add(this.txtSupplierContact);
            this.pnlSupplier.Controls.Add(this.lblSupplierContact);
            this.pnlSupplier.Controls.Add(this.txtSupplierAddress);
            this.pnlSupplier.Controls.Add(this.lblSupplierAddress);
            this.pnlSupplier.Controls.Add(this.txtSupplierName);
            this.pnlSupplier.Controls.Add(this.lblSupplierName);
            this.pnlSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSupplier.Location = new System.Drawing.Point(0, 0);
            this.pnlSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(1120, 777);
            this.pnlSupplier.TabIndex = 2;
            this.pnlSupplier.Visible = false;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.White;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Location = new System.Drawing.Point(27, 172);
            this.dgvSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.Size = new System.Drawing.Size(1067, 578);
            this.dgvSupplier.TabIndex = 7;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Location = new System.Drawing.Point(604, 74);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(200, 43);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSupplierContact
            // 
            this.txtSupplierContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSupplierContact.Location = new System.Drawing.Point(213, 123);
            this.txtSupplierContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.Size = new System.Drawing.Size(352, 30);
            this.txtSupplierContact.TabIndex = 5;
            // 
            // lblSupplierContact
            // 
            this.lblSupplierContact.AutoSize = true;
            this.lblSupplierContact.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierContact.Location = new System.Drawing.Point(27, 127);
            this.lblSupplierContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierContact.Name = "lblSupplierContact";
            this.lblSupplierContact.Size = new System.Drawing.Size(142, 23);
            this.lblSupplierContact.TabIndex = 8;
            this.lblSupplierContact.Text = "Contact Number:";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSupplierAddress.Location = new System.Drawing.Point(213, 76);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(352, 30);
            this.txtSupplierAddress.TabIndex = 3;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierAddress.Location = new System.Drawing.Point(27, 80);
            this.lblSupplierAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(74, 23);
            this.lblSupplierAddress.TabIndex = 9;
            this.lblSupplierAddress.Text = "Address:";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSupplierName.Location = new System.Drawing.Point(213, 31);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(352, 30);
            this.txtSupplierName.TabIndex = 1;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSupplierName.Location = new System.Drawing.Point(27, 34);
            this.lblSupplierName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(127, 23);
            this.lblSupplierName.TabIndex = 10;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.nudInitialStock);
            this.pnlItems.Controls.Add(this.lblInitialStock);
            this.pnlItems.Controls.Add(this.dgvItems);
            this.pnlItems.Controls.Add(this.btnAddItem);
            this.pnlItems.Controls.Add(this.txtItemPrice);
            this.pnlItems.Controls.Add(this.lblItemPrice);
            this.pnlItems.Controls.Add(this.cmbItemCategory);
            this.pnlItems.Controls.Add(this.lblItemCategory);
            this.pnlItems.Controls.Add(this.txtItemName);
            this.pnlItems.Controls.Add(this.lblItemName);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(0, 0);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1120, 777);
            this.pnlItems.TabIndex = 3;
            this.pnlItems.Visible = false;
            // 
            // nudInitialStock
            // 
            this.nudInitialStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudInitialStock.Location = new System.Drawing.Point(213, 170);
            this.nudInitialStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudInitialStock.Name = "nudInitialStock";
            this.nudInitialStock.Size = new System.Drawing.Size(177, 30);
            this.nudInitialStock.TabIndex = 11;
            // 
            // lblInitialStock
            // 
            this.lblInitialStock.AutoSize = true;
            this.lblInitialStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInitialStock.Location = new System.Drawing.Point(27, 172);
            this.lblInitialStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitialStock.Name = "lblInitialStock";
            this.lblInitialStock.Size = new System.Drawing.Size(104, 23);
            this.lblInitialStock.TabIndex = 10;
            this.lblInitialStock.Text = "Initial Stock:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(27, 268);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(1067, 483);
            this.dgvItems.TabIndex = 7;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(213, 212);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(177, 43);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemPrice.Location = new System.Drawing.Point(213, 123);
            this.txtItemPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(352, 30);
            this.txtItemPrice.TabIndex = 5;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblItemPrice.Location = new System.Drawing.Point(27, 127);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(91, 23);
            this.lblItemPrice.TabIndex = 8;
            this.lblItemPrice.Text = "Base Price:";
            // 
            // cmbItemCategory
            // 
            this.cmbItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbItemCategory.FormattingEnabled = true;
            this.cmbItemCategory.Location = new System.Drawing.Point(213, 76);
            this.cmbItemCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItemCategory.Name = "cmbItemCategory";
            this.cmbItemCategory.Size = new System.Drawing.Size(352, 31);
            this.cmbItemCategory.TabIndex = 3;
            // 
            // lblItemCategory
            // 
            this.lblItemCategory.AutoSize = true;
            this.lblItemCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblItemCategory.Location = new System.Drawing.Point(27, 80);
            this.lblItemCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCategory.Name = "lblItemCategory";
            this.lblItemCategory.Size = new System.Drawing.Size(83, 23);
            this.lblItemCategory.TabIndex = 9;
            this.lblItemCategory.Text = "Category:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtItemName.Location = new System.Drawing.Point(213, 31);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(352, 30);
            this.txtItemName.TabIndex = 1;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblItemName.Location = new System.Drawing.Point(27, 34);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(100, 23);
            this.lblItemName.TabIndex = 10;
            this.lblItemName.Text = "Item Name:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 777);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcoUser)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox IcoUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
