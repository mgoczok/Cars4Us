-- ========================================================
-- Database Schema: Sales Transactions
-- Safe for multiple executions (IF NOT EXISTS)
-- ========================================================

-- Transactions table for recording car sales
CREATE TABLE IF NOT EXISTS transactions (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    CarId INT NOT NULL,
    CustomerId INT NOT NULL,
    EmployeeId INT NOT NULL,
    FinalPrice DECIMAL(10,2) NOT NULL,
    FinancingType VARCHAR(50) NOT NULL,
    Status VARCHAR(50) NOT NULL DEFAULT 'Created',
    TransactionDate DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT fk_transactions_car FOREIGN KEY (CarId) REFERENCES cars(Id),
    CONSTRAINT fk_transactions_customer FOREIGN KEY (CustomerId) REFERENCES customers(Id),
    CONSTRAINT fk_transactions_employee FOREIGN KEY (EmployeeId) REFERENCES employees(Id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ========================================================
-- End of Schema
-- ========================================================
