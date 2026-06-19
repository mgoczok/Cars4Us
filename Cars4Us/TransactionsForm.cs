using Cars4Us.Models;
using Cars4Us.Repositories;

namespace Cars4Us
{
    public partial class TransactionsForm : Form
    {
        private readonly TransactionRepository _transactionRepo = new TransactionRepository();
        private readonly CarRepository _carRepo = new CarRepository();
        private readonly CustomerRepository _customerRepo = new CustomerRepository();
        private readonly EmployeeRepository _employeeRepo = new EmployeeRepository();

        private List<Car> _cars = new List<Car>();
        private List<Customer> _customers = new List<Customer>();
        private List<Employee> _employees = new List<Employee>();

        private int? _selectedTransactionId = null;

        public TransactionsForm()
        {
            InitializeComponent();
            dgvTransactions.CellFormatting += dgvTransactions_CellFormatting;
            LoadComboBoxData();
            LoadTransactions();
        }

        // ---- Data loading ----

        private void LoadComboBoxData()
        {
            try
            {
                // Cars
                _cars = _carRepo.GetAllAvailable();
                cbCar.DataSource = null;
                cbCar.Items.Clear();
                foreach (var car in _cars)
                {
                    cbCar.Items.Add($"{car.Brand} {car.Model} ({car.VIN})");
                }

                if (_cars.Count == 0)
                    MessageBox.Show("Brak dostępnych samochodów w bazie.", "Informacja",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Customers
                _customers = _customerRepo.GetAll();
                cbCustomer.DataSource = null;
                cbCustomer.Items.Clear();
                foreach (var c in _customers)
                {
                    cbCustomer.Items.Add($"{c.LastName} {c.FirstName} ({c.Email})");
                }

                if (_customers.Count == 0)
                    MessageBox.Show("Brak klientów w bazie.", "Informacja",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Employees (only Salesperson)
                _employees = _employeeRepo.GetActiveSalespeople();
                cbEmployee.DataSource = null;
                cbEmployee.Items.Clear();
                foreach (var emp in _employees)
                {
                    cbEmployee.Items.Add($"{emp.LastName} {emp.FirstName} ({emp.Role})");
                }

                if (_employees.Count == 0)
                    MessageBox.Show("Brak aktywnych handlowców w bazie.", "Informacja",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania danych: {ex.Message}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTransactions()
        {
            try
            {
                var transactions = _transactionRepo.GetAll();
                dgvTransactions.DataSource = null;
                dgvTransactions.DataSource = transactions;

                if (dgvTransactions.Columns["Id"] != null) dgvTransactions.Columns["Id"].HeaderText = "ID";
                if (dgvTransactions.Columns["CarId"] != null) dgvTransactions.Columns["CarId"].HeaderText = "Samochód";
                if (dgvTransactions.Columns["CustomerId"] != null) dgvTransactions.Columns["CustomerId"].HeaderText = "Klient";
                if (dgvTransactions.Columns["EmployeeId"] != null) dgvTransactions.Columns["EmployeeId"].HeaderText = "Handlowiec";
                if (dgvTransactions.Columns["FinalPrice"] != null) 
                {
                    dgvTransactions.Columns["FinalPrice"].HeaderText = "Cena końcowa";
                    dgvTransactions.Columns["FinalPrice"].DefaultCellStyle.Format = "C2";
                    dgvTransactions.Columns["FinalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
                if (dgvTransactions.Columns["FinancingType"] != null) dgvTransactions.Columns["FinancingType"].HeaderText = "Finansowanie";
                if (dgvTransactions.Columns["Status"] != null) dgvTransactions.Columns["Status"].HeaderText = "Status";
                if (dgvTransactions.Columns["TransactionDate"] != null) 
                {
                    dgvTransactions.Columns["TransactionDate"].HeaderText = "Data transakcji";
                    dgvTransactions.Columns["TransactionDate"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania transakcji: {ex.Message}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---- Event handlers ----

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                var transaction = new SalesTransaction
                {
                    CarId = _cars[cbCar.SelectedIndex].Id,
                    CustomerId = _customers[cbCustomer.SelectedIndex].Id,
                    EmployeeId = _employees[cbEmployee.SelectedIndex].Id,
                    FinalPrice = numFinalPrice.Value,
                    FinancingType = cbFinancingType.SelectedItem?.ToString() ?? string.Empty,
                    Status = cbStatus.SelectedItem?.ToString() ?? string.Empty
                };

                int newId = _transactionRepo.Add(transaction);
                MessageBox.Show($"Transakcja dodana pomyślnie (Id: {newId}).", "Sukces",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd dodawania transakcji: {ex.Message}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedTransactionId == null)
                {
                    MessageBox.Show("Wybierz transakcję do aktualizacji.", "Walidacja",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateForm()) return;

                var transaction = new SalesTransaction
                {
                    Id = _selectedTransactionId.Value,
                    CarId = _cars[cbCar.SelectedIndex].Id,
                    CustomerId = _customers[cbCustomer.SelectedIndex].Id,
                    EmployeeId = _employees[cbEmployee.SelectedIndex].Id,
                    FinalPrice = numFinalPrice.Value,
                    FinancingType = cbFinancingType.SelectedItem?.ToString() ?? string.Empty,
                    Status = cbStatus.SelectedItem?.ToString() ?? string.Empty
                };

                _transactionRepo.Update(transaction);
                MessageBox.Show("Transakcja zaktualizowana.", "Sukces",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd aktualizacji transakcji: {ex.Message}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedTransactionId == null)
                {
                    MessageBox.Show("Wybierz transakcję do anulowania.", "Walidacja",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Czy na pewno chcesz anulować tę transakcję?",
                    "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _transactionRepo.Cancel(_selectedTransactionId.Value);
                    MessageBox.Show("Transakcja anulowana.", "Sukces",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    LoadTransactions();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd anulowania transakcji: {ex.Message}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadTransactions();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvTransactions.Rows[e.RowIndex];

                _selectedTransactionId = Convert.ToInt32(row.Cells["Id"].Value);
                int carId = Convert.ToInt32(row.Cells["CarId"].Value);
                int customerId = Convert.ToInt32(row.Cells["CustomerId"].Value);
                int employeeId = Convert.ToInt32(row.Cells["EmployeeId"].Value);

                // Select car in combo (may not be in list if no longer Available)
                int carIndex = _cars.FindIndex(c => c.Id == carId);
                if (carIndex == -1)
                {
                    _cars.Add(new Car { Id = carId, Brand = "Pojazd archiwalny", Model = "", VIN = "Niedostępny" });
                    cbCar.Items.Add($"Pojazd archiwalny (Id: {carId})");
                    carIndex = _cars.Count - 1;
                }
                cbCar.SelectedIndex = carIndex;

                // Select customer
                int customerIndex = _customers.FindIndex(c => c.Id == customerId);
                cbCustomer.SelectedIndex = customerIndex >= 0 ? customerIndex : -1;

                // Select employee (may not be in Salesperson list)
                int employeeIndex = _employees.FindIndex(emp => emp.Id == employeeId);
                cbEmployee.SelectedIndex = employeeIndex >= 0 ? employeeIndex : -1;

                numFinalPrice.Value = Convert.ToDecimal(row.Cells["FinalPrice"].Value);

                string financingType = row.Cells["FinancingType"].Value?.ToString() ?? "";
                int ftIndex = cbFinancingType.Items.IndexOf(financingType);
                cbFinancingType.SelectedIndex = ftIndex >= 0 ? ftIndex : -1;

                string status = row.Cells["Status"].Value?.ToString() ?? "";
                int stIndex = cbStatus.Items.IndexOf(status);
                cbStatus.SelectedIndex = stIndex >= 0 ? stIndex : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd wczytywania danych transakcji: {ex.Message}", "Błąd",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---- Helpers ----

        private bool ValidateForm()
        {
            if (cbCar.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz samochód.", "Walidacja",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbCustomer.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz klienta.", "Walidacja",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbEmployee.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz handlowca.", "Walidacja",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numFinalPrice.Value <= 0)
            {
                MessageBox.Show("Cena końcowa musi być większa od 0.", "Walidacja",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbFinancingType.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz typ finansowania.", "Walidacja",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Wybierz status transakcji.", "Walidacja",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearForm()
        {
            _selectedTransactionId = null;
            cbCar.SelectedIndex = -1;
            cbCustomer.SelectedIndex = -1;
            cbEmployee.SelectedIndex = -1;
            numFinalPrice.Value = 0;
            cbFinancingType.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            dgvTransactions.ClearSelection();
        }

        private void dgvTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string colName = dgvTransactions.Columns[e.ColumnIndex].Name;

            if (colName == "FinancingType")
            {
                string fType = e.Value.ToString() ?? "";
                if (fType == "Cash") { e.Value = "Gotówka"; e.FormattingApplied = true; }
                else if (fType == "Leasing") { e.Value = "Leasing"; e.FormattingApplied = true; }
                else if (fType == "Credit") { e.Value = "Kredyt"; e.FormattingApplied = true; }
            }
            else if (colName == "Status")
            {
                string status = e.Value.ToString() ?? "";
                
                switch (status)
                {
                    case "Created": e.Value = "Utworzona"; break;
                    case "Reserved": 
                        e.Value = "Zarezerwowana"; 
                        e.CellStyle.ForeColor = Color.LightBlue;
                        break;
                    case "CreditVerification": 
                        e.Value = "Weryfikacja kredytowa"; 
                        e.CellStyle.ForeColor = Color.Orange;
                        break;
                    case "Insurance": e.Value = "Ubezpieczenie"; break;
                    case "ReadyForRelease": e.Value = "Gotowa do wydania"; break;
                    case "Completed": 
                        e.Value = "Zakończona"; 
                        e.CellStyle.ForeColor = Color.LightGreen;
                        break;
                    case "Cancelled": 
                        e.Value = "Anulowana"; 
                        e.CellStyle.ForeColor = Color.LightCoral;
                        break;
                }
                e.FormattingApplied = true;
            }
        }
    }
}
