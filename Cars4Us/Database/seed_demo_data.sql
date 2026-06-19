-- ========================================================
-- Database Schema: Demo Data Seeder
-- Safe for multiple executions (INSERT ... SELECT ... WHERE NOT EXISTS)
-- ========================================================

-- 1. Seed Cars (8)
INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT 'WAUZZZ8T09A111222', 'Audi', 'A4', 'Benzyna', 15000, 150000.00, 'Available'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = 'WAUZZZ8T09A111222');

INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT 'WBA3C11050F333444', 'BMW', 'Seria 3', 'Diesel', 45000, 120000.00, 'Available'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = 'WBA3C11050F333444');

INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT 'JTDKB20U503555666', 'Toyota', 'Corolla', 'Hybryda', 10000, 110000.00, 'Available'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = 'JTDKB20U503555666');

INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT 'SALWA2BV4FH777888', 'Land Rover', 'Discovery', 'Diesel', 85000, 195000.00, 'OnOrder'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = 'SALWA2BV4FH777888');

INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT '1G1RC6E45BU999000', 'Chevrolet', 'Camaro', 'Benzyna', 5000, 250000.00, 'Available'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = '1G1RC6E45BU999000');

INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT 'KNDJD8122D7111333', 'Kia', 'Sportage', 'Benzyna', 0, 135000.00, 'Available'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = 'KNDJD8122D7111333');

INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT 'VF1R2020202444555', 'Renault', 'Clio', 'Benzyna', 120000, 45000.00, 'Available'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = 'VF1R2020202444555');

INSERT INTO cars (VIN, Brand, Model, EngineType, Mileage, BasePrice, Status)
SELECT '5YJ3E1EA5KF666777', 'Tesla', 'Model 3', 'Elektryczny', 25000, 210000.00, 'OnOrder'
WHERE NOT EXISTS (SELECT 1 FROM cars WHERE VIN = '5YJ3E1EA5KF666777');

-- 2. Seed Customers (8)
INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Jan', 'Kowalski', '+48111222333', 'jan.kowalski@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'jan.kowalski@example.com');

INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Anna', 'Nowak', '+48222333444', 'anna.nowak@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'anna.nowak@example.com');

INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Piotr', 'Zieliński', '+48333444555', 'piotr.zielinski@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'piotr.zielinski@example.com');

INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Katarzyna', 'Wójcik', '+48444555666', 'katarzyna.wojcik@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'katarzyna.wojcik@example.com');

INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Michał', 'Kamiński', '+48555666777', 'michal.kaminski@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'michal.kaminski@example.com');

INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Agnieszka', 'Lewandowska', '+48666777888', 'agnieszka.lewandowska@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'agnieszka.lewandowska@example.com');

INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Tomasz', 'Dąbrowski', '+48777888999', 'tomasz.dabrowski@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'tomasz.dabrowski@example.com');

INSERT INTO customers (FirstName, LastName, Phone, Email)
SELECT 'Magdalena', 'Szymańska', '+48888999000', 'magdalena.szymanska@example.com'
WHERE NOT EXISTS (SELECT 1 FROM customers WHERE Email = 'magdalena.szymanska@example.com');

-- 3. Seed Options (12)
INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Pakiet Bezpieczeństwa Pro', 'SafetyPackage', 4500.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Pakiet Bezpieczeństwa Pro');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Kamera cofania 360', 'SafetyPackage', 2500.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Kamera cofania 360');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'System audio Harman Kardon', 'Multimedia', 3800.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'System audio Harman Kardon');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Nawigacja satelitarna Premium', 'Multimedia', 2100.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Nawigacja satelitarna Premium');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Alufelgi 19 cali Sport', 'Wheels', 5000.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Alufelgi 19 cali Sport');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Opony zimowe Premium', 'Wheels', 2800.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Opony zimowe Premium');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Podgrzewane fotele przednie', 'Comfort', 1800.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Podgrzewane fotele przednie');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Klimatyzacja 4-strefowa', 'Comfort', 3200.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Klimatyzacja 4-strefowa');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Gwarancja Plus 5 lat', 'Warranty', 4000.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Gwarancja Plus 5 lat');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Rozszerzony pakiet serwisowy', 'Warranty', 3500.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Rozszerzony pakiet serwisowy');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Powłoka ceramiczna', 'ExteriorProtection', 3000.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Powłoka ceramiczna');

INSERT INTO options (Name, Category, Price, IsActive)
SELECT 'Folia ochronna PPF (przód)', 'ExteriorProtection', 4200.00, 1
WHERE NOT EXISTS (SELECT 1 FROM options WHERE Name = 'Folia ochronna PPF (przód)');

-- 4. Seed Employees (6)
INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive)
SELECT 'Marek', 'Handlowy', 'Salesperson', 'marek.handlowy@cars4us.com', '+48500100200', 1
WHERE NOT EXISTS (SELECT 1 FROM employees WHERE Email = 'marek.handlowy@cars4us.com');

INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive)
SELECT 'Krzysztof', 'Sprzedawca', 'Salesperson', 'krzysztof.sprzedawca@cars4us.com', '+48500200300', 1
WHERE NOT EXISTS (SELECT 1 FROM employees WHERE Email = 'krzysztof.sprzedawca@cars4us.com');

INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive)
SELECT 'Ewa', 'Kierownik', 'Manager', 'ewa.kierownik@cars4us.com', '+48500300400', 1
WHERE NOT EXISTS (SELECT 1 FROM employees WHERE Email = 'ewa.kierownik@cars4us.com');

INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive)
SELECT 'Adam', 'Szef', 'Manager', 'adam.szef@cars4us.com', '+48500400500', 1
WHERE NOT EXISTS (SELECT 1 FROM employees WHERE Email = 'adam.szef@cars4us.com');

INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive)
SELECT 'Tomasz', 'Mechanik', 'ServiceTechnician', 'tomasz.mechanik@cars4us.com', '+48500500600', 1
WHERE NOT EXISTS (SELECT 1 FROM employees WHERE Email = 'tomasz.mechanik@cars4us.com');

INSERT INTO employees (FirstName, LastName, Role, Email, Phone, IsActive)
SELECT 'Paweł', 'Serwis', 'ServiceTechnician', 'pawel.serwis@cars4us.com', '+48500600700', 1
WHERE NOT EXISTS (SELECT 1 FROM employees WHERE Email = 'pawel.serwis@cars4us.com');

-- 5. Seed Transactions (5)
INSERT INTO transactions (CarId, CustomerId, EmployeeId, FinalPrice, FinancingType, Status)
SELECT c.Id, cust.Id, emp.Id, 154500.00, 'Cash', 'Completed'
FROM cars c
JOIN customers cust ON cust.Email = 'jan.kowalski@example.com'
JOIN employees emp ON emp.Email = 'marek.handlowy@cars4us.com'
WHERE c.VIN = 'WAUZZZ8T09A111222'
AND NOT EXISTS (
    SELECT 1 FROM transactions t
    WHERE t.CarId = c.Id AND t.CustomerId = cust.Id AND t.EmployeeId = emp.Id
    AND t.FinalPrice = 154500.00 AND t.FinancingType = 'Cash' AND t.Status = 'Completed'
);

INSERT INTO transactions (CarId, CustomerId, EmployeeId, FinalPrice, FinancingType, Status)
SELECT c.Id, cust.Id, emp.Id, 125000.00, 'Leasing', 'ReadyForRelease'
FROM cars c
JOIN customers cust ON cust.Email = 'anna.nowak@example.com'
JOIN employees emp ON emp.Email = 'krzysztof.sprzedawca@cars4us.com'
WHERE c.VIN = 'WBA3C11050F333444'
AND NOT EXISTS (
    SELECT 1 FROM transactions t
    WHERE t.CarId = c.Id AND t.CustomerId = cust.Id AND t.EmployeeId = emp.Id
    AND t.FinalPrice = 125000.00 AND t.FinancingType = 'Leasing' AND t.Status = 'ReadyForRelease'
);

INSERT INTO transactions (CarId, CustomerId, EmployeeId, FinalPrice, FinancingType, Status)
SELECT c.Id, cust.Id, emp.Id, 114000.00, 'Credit', 'CreditVerification'
FROM cars c
JOIN customers cust ON cust.Email = 'piotr.zielinski@example.com'
JOIN employees emp ON emp.Email = 'marek.handlowy@cars4us.com'
WHERE c.VIN = 'JTDKB20U503555666'
AND NOT EXISTS (
    SELECT 1 FROM transactions t
    WHERE t.CarId = c.Id AND t.CustomerId = cust.Id AND t.EmployeeId = emp.Id
    AND t.FinalPrice = 114000.00 AND t.FinancingType = 'Credit' AND t.Status = 'CreditVerification'
);

INSERT INTO transactions (CarId, CustomerId, EmployeeId, FinalPrice, FinancingType, Status)
SELECT c.Id, cust.Id, emp.Id, 195000.00, 'Leasing', 'Reserved'
FROM cars c
JOIN customers cust ON cust.Email = 'katarzyna.wojcik@example.com'
JOIN employees emp ON emp.Email = 'krzysztof.sprzedawca@cars4us.com'
WHERE c.VIN = 'SALWA2BV4FH777888'
AND NOT EXISTS (
    SELECT 1 FROM transactions t
    WHERE t.CarId = c.Id AND t.CustomerId = cust.Id AND t.EmployeeId = emp.Id
    AND t.FinalPrice = 195000.00 AND t.FinancingType = 'Leasing' AND t.Status = 'Reserved'
);

INSERT INTO transactions (CarId, CustomerId, EmployeeId, FinalPrice, FinancingType, Status)
SELECT c.Id, cust.Id, emp.Id, 250000.00, 'Cash', 'Cancelled'
FROM cars c
JOIN customers cust ON cust.Email = 'michal.kaminski@example.com'
JOIN employees emp ON emp.Email = 'marek.handlowy@cars4us.com'
WHERE c.VIN = '1G1RC6E45BU999000'
AND NOT EXISTS (
    SELECT 1 FROM transactions t
    WHERE t.CarId = c.Id AND t.CustomerId = cust.Id AND t.EmployeeId = emp.Id
    AND t.FinalPrice = 250000.00 AND t.FinancingType = 'Cash' AND t.Status = 'Cancelled'
);

-- 6. Verification SELECTs
SELECT '--- TABLE COUNTS ---' AS Info;
SELECT COUNT(*) AS CarsCount FROM cars;
SELECT COUNT(*) AS CustomersCount FROM customers;
SELECT COUNT(*) AS OptionsCount FROM options;
SELECT COUNT(*) AS EmployeesCount FROM employees;
SELECT COUNT(*) AS TransactionsCount FROM transactions;
