-- ========================================================
-- Database Schema: Options and Employees
-- Safe for multiple executions (IF NOT EXISTS)
-- ========================================================

-- Options table for catalog of car options/accessories
CREATE TABLE IF NOT EXISTS options (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Category VARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    IsActive TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Employees table for showroom/dealership staff management
CREATE TABLE IF NOT EXISTS employees (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Email VARCHAR(100) NULL,
    Phone VARCHAR(20) NULL,
    IsActive TINYINT(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ========================================================
-- Example data (commented out - not auto-seeded)
-- ========================================================

/*
-- Example Options
INSERT INTO options (Name, Category, Price, IsActive) VALUES
('Leather Seats', 'Comfort', 1500.00, 1),
('Sunroof', 'ExteriorProtection', 2500.00, 1),
('Panoramic Windshield', 'ExteriorProtection', 1200.00, 1),
('Advanced Safety Package', 'SafetyPackage', 3000.00, 1),
('Premium Sound System', 'Multimedia', 1800.00, 1),
('Navigation System', 'Multimedia', 1000.00, 1),
('Summer Tire Set', 'Wheels', 800.00, 1),
('Extended Warranty', 'Warranty', 500.00, 1);

-- Example Employees
INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive) VALUES
('Jan', 'Kowalski', 'Manager', 'jan.kowalski@cars4us.com', '+48123456789', 1),
('Maria', 'Nowak', 'Salesperson', 'maria.nowak@cars4us.com', '+48987654321', 1),
('Piotr', 'Lewandowski', 'ServiceTechnician', 'piotr.lewandowski@cars4us.com', '+48555666777', 1);
*/

-- ========================================================
-- End of Schema
-- ========================================================
