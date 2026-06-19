-- ========================================================
-- Database Schema: Base Tables (Cars, Customers, TestDrives)
-- Safe for multiple executions (IF NOT EXISTS)
-- ========================================================

-- Cars table
CREATE TABLE IF NOT EXISTS cars (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    VIN VARCHAR(50) NOT NULL,
    Brand VARCHAR(50) NOT NULL,
    Model VARCHAR(50) NOT NULL,
    EngineType VARCHAR(50) NOT NULL,
    Mileage INT NOT NULL,
    BasePrice DECIMAL(10,2) NOT NULL,
    Status VARCHAR(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- Customers table
CREATE TABLE IF NOT EXISTS customers (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Phone VARCHAR(20) NULL,
    Email VARCHAR(100) NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- TestDrives table
CREATE TABLE IF NOT EXISTS testdrives (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    CustomerId INT NOT NULL,
    CarId INT NOT NULL,
    DriveDate DATETIME NOT NULL,
    CONSTRAINT fk_testdrives_customer FOREIGN KEY (CustomerId) REFERENCES customers(Id),
    CONSTRAINT fk_testdrives_car FOREIGN KEY (CarId) REFERENCES cars(Id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ========================================================
-- End of Schema
-- ========================================================
