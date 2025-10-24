-- ============================================
-- Password Security Migration Script
-- ============================================
-- This script helps migrate existing plain text passwords
-- to hashed passwords in the POS system
--
-- IMPORTANT: Passwords will be auto-migrated when users log in,
-- but you can use this script if you want to hash passwords manually.
-- ============================================

USE pos_db;

-- Check current password status
-- This query shows which passwords are plain text vs hashed
SELECT 
    username,
    CASE 
        WHEN LENGTH(password) > 30 THEN 'Hashed'
        ELSE 'Plain Text'
    END AS password_status,
    LENGTH(password) AS password_length
FROM Users;

-- ============================================
-- OPTION 1: Let Auto-Migration Handle It (RECOMMENDED)
-- ============================================
-- No SQL needed! Just inform users to login normally.
-- The system will automatically hash passwords on first login.

-- ============================================
-- OPTION 2: Force Password Reset (If Needed)
-- ============================================
-- Uncomment the following line to force all users to reset passwords:
-- UPDATE Users SET password = '[RESET_REQUIRED]' WHERE LENGTH(password) < 30;

-- Then inform users to:
-- 1. Contact admin for password reset
-- 2. Admin creates new user with new password (will be hashed automatically)

-- ============================================
-- OPTION 3: Update Specific User (Manual)
-- ============================================
-- If you know a user's current password and want to hash it immediately,
-- use the application's "Maintenance -> Users -> Add User" feature
-- to create a new user with a hashed password.

-- ============================================
-- Verify Migration Status
-- ============================================
-- Run this after migration to check status:
SELECT 
    COUNT(*) AS total_users,
    SUM(CASE WHEN LENGTH(password) > 30 THEN 1 ELSE 0 END) AS hashed_passwords,
    SUM(CASE WHEN LENGTH(password) <= 30 THEN 1 ELSE 0 END) AS plain_text_passwords,
    ROUND(SUM(CASE WHEN LENGTH(password) > 30 THEN 1 ELSE 0 END) * 100.0 / COUNT(*), 2) AS migration_percentage
FROM Users;

-- ============================================
-- Create Backup Before Migration (RECOMMENDED)
-- ============================================
-- Use the POS application's Backup feature:
-- 1. Go to Backup & Restore module
-- 2. Click "Backup" button
-- 3. Save backup file with date: pos_backup_YYYYMMDD_pre_migration.sql
-- 4. Then proceed with migration

-- ============================================
-- Rollback (If Needed)
-- ============================================
-- If something goes wrong, restore from backup:
-- 1. Go to Backup & Restore module
-- 2. Click "Restore" button
-- 3. Select your backup file
-- 4. Confirm restoration

-- ============================================
-- Expected Results After Full Migration
-- ============================================
-- All passwords should:
-- - Be longer than 30 characters
-- - Start with "10000." (iteration count)
-- - Be in format: iterations.base64hash
-- - NOT be readable as plain text

-- Example hashed password format:
-- 10000.Zd7x8pN4mK9qL2fJ8hG5vD3cX1wY6tR7eS9aQ4bP0oI5uY8tR3eW2qZ1x

-- ============================================
-- Security Notes
-- ============================================
-- 1. ? Hashed passwords cannot be reversed to plain text
-- 2. ? Each password has a unique salt (even if same password)
-- 3. ? 10,000 iterations make brute force attacks very slow
-- 4. ? PBKDF2 is NIST-approved standard
-- 5. ? System maintains backward compatibility during transition

-- ============================================
-- Troubleshooting
-- ============================================

-- Problem: User can't login after migration
-- Solution: Password is already hashed, they should use their original password

-- Problem: "Invalid username or password" for all users
-- Solution: Check if passwords were accidentally corrupted. Restore from backup.

-- Problem: Some users hashed, some not
-- Solution: This is normal! Let auto-migration handle remaining users naturally.

-- Problem: Need to reset all passwords immediately
-- Solution: Use OPTION 2 above, then manually recreate users with new passwords.

-- ============================================
-- Migration Checklist
-- ============================================
-- [ ] 1. Create backup using POS Backup feature
-- [ ] 2. Run verification query to see current status
-- [ ] 3. Choose migration approach:
--         [ ] Auto-migration (recommended - no SQL needed)
--         [ ] Force reset (use OPTION 2 SQL)
--         [ ] Manual update (use application)
-- [ ] 4. Test login with admin account
-- [ ] 5. Verify password is hashed in database
-- [ ] 6. Inform users (if using auto-migration, no action needed from them)
-- [ ] 7. Monitor migration percentage over time
-- [ ] 8. Once 100% migrated, celebrate! ??

-- ============================================
-- End of Migration Script
-- ============================================
