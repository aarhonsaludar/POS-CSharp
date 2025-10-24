-- POS Database Setup Script
-- Run this script in MySQL Workbench or MySQL Command Line to create the database

-- Drop existing database if you want to start fresh (CAREFUL: This deletes all data!)
-- DROP DATABASE IF EXISTS pos_db;

-- Create database
CREATE DATABASE IF NOT EXISTS pos_db;
USE pos_db;

-- Users Table (username is the primary key)
CREATE TABLE IF NOT EXISTS Users (
    username VARCHAR(50) PRIMARY KEY,
    password VARCHAR(100) NOT NULL
);

-- Item Category Table
CREATE TABLE IF NOT EXISTS ItemCategory (
    CategoryId INT AUTO_INCREMENT PRIMARY KEY,
    CategoryName VARCHAR(100) NOT NULL UNIQUE
);

-- Supplier Table
CREATE TABLE IF NOT EXISTS Supplier (
    SupplierId INT AUTO_INCREMENT PRIMARY KEY,
    SupplierName VARCHAR(100) NOT NULL,
    Address VARCHAR(255),
    ContactNumber VARCHAR(20)
);

-- Items Table
CREATE TABLE IF NOT EXISTS Items (
    ItemId INT AUTO_INCREMENT PRIMARY KEY,
    ItemName VARCHAR(100) NOT NULL,
    CategoryId INT,
    BasePrice DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES ItemCategory(CategoryId) ON DELETE SET NULL
);

-- Inventory Table
CREATE TABLE IF NOT EXISTS Inventory (
    ItemId INT PRIMARY KEY,
    Quantity INT DEFAULT 0,
    FOREIGN KEY (ItemId) REFERENCES Items(ItemId) ON DELETE CASCADE
);

-- Delivery Table
CREATE TABLE IF NOT EXISTS Delivery (
    DeliveryId INT AUTO_INCREMENT PRIMARY KEY,
    DeliveryDate DATE NOT NULL,
    ItemId INT NOT NULL,
    Quantity INT NOT NULL,
    FOREIGN KEY (ItemId) REFERENCES Items(ItemId) ON DELETE CASCADE
);

-- Sales Table
CREATE TABLE IF NOT EXISTS Sales (
    SaleId INT AUTO_INCREMENT PRIMARY KEY,
    ReceiptId VARCHAR(50) NOT NULL,
    ReceiptDate DATETIME NOT NULL,
    ItemId INT NOT NULL,
    Quantity INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (ItemId) REFERENCES Items(ItemId) ON DELETE CASCADE,
    INDEX idx_receipt (ReceiptId),
    INDEX idx_date (ReceiptDate)
);

-- Insert default admin user (if not exists)
INSERT IGNORE INTO Users (username, password) VALUES ('admin', 'admin123');

-- Insert sample categories
INSERT IGNORE INTO ItemCategory (CategoryName) VALUES 
    ('Beverages'),
    ('Snacks'),
    ('Groceries'),
    ('Personal Care'),
    ('Household');

-- Display all tables
SHOW TABLES;

-- Display table structures
DESCRIBE Users;
DESCRIBE ItemCategory;
DESCRIBE Supplier;
DESCRIBE Items;
DESCRIBE Inventory;
DESCRIBE Delivery;
DESCRIBE Sales;

-- Check initial data
SELECT 'Users:' AS TableName;
SELECT * FROM Users;

SELECT 'Categories:' AS TableName;
SELECT * FROM ItemCategory;

SELECT 'Database setup completed successfully!' AS Status;
