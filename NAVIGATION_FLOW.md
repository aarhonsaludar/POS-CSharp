# POS System - Navigation Flow Documentation

## Application Flow

### 1. Application Start
- **Entry Point**: `Program.cs` ? `LoginForm`
- The application starts with the Login Form centered on screen

### 2. Login Form
- **File**: `LoginForm.cs`
- **Purpose**: User authentication
- **Navigation**:
  - ? Successful login ? Opens `MainForm` (Main Menu)
  - ? Failed login ? Displays error, stays on login
  - ?? Close login form ? Exits entire application

### 3. Main Form (Main Menu)
- **File**: `MainForm.cs`
- **Purpose**: Central navigation hub
- **Features**:
  - All child forms open as modal dialogs (ShowDialog)
  - Proper form disposal after closing
  - Logout returns to login screen
  - Close confirmation dialog

- **Available Modules**:
  1. **Maintenance** ? `MaintenanceForm`
  2. **Delivery** ? `DeliveryForm`
  3. **Inventory Monitoring** ? `InventoryMonitoringForm`
  4. **POS** ? `POSForm`
  5. **Sales Monitoring** ? `SalesMonitoringForm`
  6. **Backup & Restore** ? `BackupRestoreForm`
  7. **Logout** ? Returns to `LoginForm`

### 4. Child Forms

#### 4.1 Maintenance Form
- **File**: `MaintenanceForm.cs`
- **Purpose**: Manage system data
- **Sub-Modules**:
  - **Users**: Add/view system users
  - **Categories**: Manage item categories
  - **Suppliers**: Manage supplier information
  - **Items**: Add/view items with categories and prices
- **Navigation**: Sidebar with visual feedback
- **Close**: Returns to Main Menu

#### 4.2 Delivery Form
- **File**: `DeliveryForm.cs`
- **Purpose**: Record item deliveries and update inventory
- **Features**:
  - Auto-generate delivery ID
  - Select item from dropdown
  - Display current stock
  - Add quantity to inventory
- **Close**: Returns to Main Menu

#### 4.3 Inventory Monitoring Form
- **File**: `InventoryMonitoringForm.cs`
- **Purpose**: View and monitor stock levels
- **Features**:
  - View all items with current stock
  - Search functionality
  - Color-coded low stock warnings (< 10 items = light red, 0 = dark red)
  - Display total inventory value
  - Refresh button
- **Close**: Returns to Main Menu

#### 4.4 POS Form
- **File**: `POSForm.cs`
- **Purpose**: Process sales transactions
- **Features**:
  - Auto-generate receipt ID
  - Add items to cart
  - Stock validation
  - Remove items from cart
  - Checkout with inventory update
  - Transaction recording
- **Close**: Returns to Main Menu

#### 4.5 Sales Monitoring Form
- **File**: `SalesMonitoringForm.cs`
- **Purpose**: View and analyze sales data
- **Features**:
  - View all sales records
  - Filter by date range
  - Calculate total sales and transactions
  - Refresh data
- **Close**: Returns to Main Menu

#### 4.6 Backup & Restore Form
- **File**: `BackupRestoreForm.cs`
- **Purpose**: Database backup and restore
- **Features**:
  - Create database backups
  - Restore from backup files
  - Activity logging
  - Confirmation dialogs for destructive operations
- **Close**: Returns to Main Menu

## Form Positioning
All forms are centered on screen using:
```csharp
this.StartPosition = FormStartPosition.CenterScreen;
```

## Form Lifecycle Management

### Opening Forms
- Main Menu uses `ShowDialog()` for all child forms
- Ensures modal behavior (user must close child before returning to main)
- Proper disposal after closing

### Closing Forms
- **Login Form**: Closes entire application
- **Main Form**: Confirmation dialog, then exits or returns to login
- **Child Forms**: Simply close and return to Main Menu

## Database Schema

### Tables
1. **Users** (username PRIMARY KEY, password)
2. **ItemCategory** (CategoryId, CategoryName)
3. **Supplier** (SupplierId, SupplierName, Address, ContactNumber)
4. **Items** (ItemId, ItemName, CategoryId, BasePrice)
5. **Inventory** (ItemId, Quantity)
6. **Delivery** (DeliveryId, DeliveryDate, ItemId, Quantity)
7. **Sales** (SaleId, ReceiptId, ReceiptDate, ItemId, Quantity, TotalAmount)

### Key Points
- Users table uses `username` as PRIMARY KEY (not UserId)
- All forms updated to query correct column names
- Foreign key constraints ensure data integrity

## Error Handling
All forms include:
- ? Try-catch blocks for database operations
- ? User-friendly error messages
- ? Input validation
- ? Confirmation dialogs for critical operations

## Common Features Across Forms
1. **Validation**: All input fields validated before database operations
2. **Error Messages**: Consistent MessageBox dialogs
3. **Success Feedback**: Confirmation messages for completed operations
4. **Auto-focus**: Cursor returns to first input after operations
5. **Data Refresh**: Automatic reload after add/update operations

## Future Enhancements
- User roles and permissions
- Advanced reporting features
- Export to Excel functionality
- Barcode scanning support
- Receipt printing
