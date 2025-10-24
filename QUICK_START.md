# ?? Quick Start Guide - POS System

## Step 1: Database Setup

1. Open MySQL Workbench or MySQL Command Line
2. Run the `database_setup.sql` file
3. Verify tables are created:
   ```sql
   USE pos_db;
   SHOW TABLES;
   ```

## Step 2: Default Login

**Username**: `admin`  
**Password**: `admin123`

## Step 3: Main Menu Buttons

Once logged in, you'll see the main menu with these options:

| Button | Opens | Purpose |
|--------|-------|---------|
| ?? **Maintenance** | Maintenance Form | Manage Users, Categories, Suppliers, Items |
| ?? **Delivery** | Delivery Form | Record new deliveries and update stock |
| ?? **Inventory Monitoring** | Inventory Form | View stock levels and inventory value |
| ?? **POS** | POS Form | Process sales transactions |
| ?? **Sales Monitoring** | Sales Form | View and analyze sales data |
| ?? **Backup & Restore** | Backup Form | Backup/restore database |
| ?? **Logout** | Login Form | Return to login screen |

## Quick Tips

### ? Adding New Items (With Initial Stock) - NEW FEATURE! ??
1. **First**: Add Category (Maintenance ? Category)
2. **Then**: Add Item with Initial Stock (Maintenance ? Items)
   - Enter Item Name
   - Select Category
   - Enter Base Price
   - **Enter Initial Stock Quantity** (optional, defaults to 0)
   - Click "Add Item"
3. **Ready to Sell!**: Item is now available in POS with stock

**Note**: You can now add items with initial stock directly! No need to use the Delivery form for new items.

### ? Adding More Stock (After Item Created)
1. Open Delivery Form
2. Select Item from dropdown
3. Add Quantity
4. Stock is updated automatically

### ? Making a Sale
1. Open POS Form
2. Select Item from dropdown
3. Enter Quantity (check available stock)
4. Click "Add to Cart"
5. Repeat for more items
6. Click "Checkout"

### ? Viewing Reports
- **Inventory**: Real-time stock levels (red = low stock) - Now shows stock in Items tab too!
- **Sales**: Filter by date range to see sales history
- **Total Values**: Automatically calculated

### ? Data Backup
1. Open Backup & Restore Form
2. Click "Browse" for backup location
3. Click "Backup Database"
4. Save file in safe location

## ?? Troubleshooting

### "Unknown column 'UserId'" Error
**Fixed!** This error has been resolved. The Users table correctly uses `username` as PRIMARY KEY.

### Connection Error
Check `DatabaseHelper.cs` connection string:
- Server: localhost
- Database: pos_db
- User: root
- Password: admin

### Backup/Restore Not Working
Update MySQL paths in `BackupRestoreForm.cs` if installed in different location.

## ?? Important Notes

?? **Password Security**: Passwords are stored in plain text. Consider implementing hashing for production.

?? **Stock Validation**: POS automatically checks stock before allowing sales.

?? **Auto-Generated IDs**: Receipt IDs and Delivery IDs are auto-generated.

? **All Forms**: Centered on screen with proper validation and error handling.

? **NEW: Initial Stock**: Add items with stock in one step! Great for setup.

---

## Common Workflows

### Initial Setup (New Feature!)
1. Login ? Maintenance ? Add Categories
2. Maintenance ? Items ? Add Items with Initial Stock
3. Ready to sell! No need for separate delivery entry

### Daily Sales
1. Login ? POS ? Process Sales ? Logout

### Stock Replenishment (Existing Items)
1. Login ? Delivery ? Add Stock ? Check Inventory Monitoring ? Logout

### End of Day
1. Login ? Sales Monitoring ? Review Today's Sales ? Backup Database ? Logout

### System Maintenance
1. Login ? Maintenance ? Add/Update Data ? Logout

---

## ?? What's New?

### Initial Stock Feature
- **Where**: Maintenance Form ? Items Tab
- **What**: NumericUpDown control for "Initial Stock"
- **Why**: Add items with stock in one step instead of two
- **How**: 
  1. Fill in Item Name, Category, and Price
  2. Set Initial Stock quantity (0-100,000)
  3. Click "Add Item"
  4. Item is created AND inventory is set automatically!

### Enhanced Items Display
- Items grid now shows **Current Stock** column
- See stock levels directly when managing items
- No need to switch to Inventory Monitoring to check stock

---

**Everything is now working correctly with the new Initial Stock feature! ??**
