using System;
using System.Windows.Forms;
using Cars4Us.Models;
using Cars4Us.Repositories;

namespace Cars4Us
{
    public partial class EmployeesForm : Form
    {
        private readonly EmployeeRepository _repository;
        private Employee? _selectedEmployee;

        public EmployeesForm()
        {
            InitializeComponent();
            _repository = new EmployeeRepository();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                var employees = _repository.GetAllActive();
                dgvEmployees.DataSource = employees;

                if (dgvEmployees.Columns["Id"] != null) dgvEmployees.Columns["Id"].HeaderText = "ID";
                if (dgvEmployees.Columns["FirstName"] != null) dgvEmployees.Columns["FirstName"].HeaderText = "Imię";
                if (dgvEmployees.Columns["LastName"] != null) dgvEmployees.Columns["LastName"].HeaderText = "Nazwisko";
                if (dgvEmployees.Columns["Role"] != null) dgvEmployees.Columns["Role"].HeaderText = "Rola";
                if (dgvEmployees.Columns["Email"] != null) 
                {
                    dgvEmployees.Columns["Email"].HeaderText = "Email";
                }
                if (dgvEmployees.Columns["Phone"] != null) dgvEmployees.Columns["Phone"].HeaderText = "Telefon";
                if (dgvEmployees.Columns["IsActive"] != null) dgvEmployees.Columns["IsActive"].HeaderText = "Aktywny";

                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania pracowników: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSelection()
        {
            _selectedEmployee = null;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cbRole.SelectedIndex = -1;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            dgvEmployees.ClearSelection();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmployees.Rows.Count)
            {
                var row = dgvEmployees.Rows[e.RowIndex];
                if (row.DataBoundItem is Employee employee)
                {
                    _selectedEmployee = employee;
                    txtFirstName.Text = employee.FirstName;
                    txtLastName.Text = employee.LastName;
                    cbRole.Text = employee.Role;
                    txtEmail.Text = employee.Email;
                    txtPhone.Text = employee.Phone;
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Imię pracownika nie może być puste.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Nazwisko pracownika nie może być puste.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbRole.Text))
            {
                MessageBox.Show("Należy wybrać rolę.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var role = cbRole.Text.Trim();
            if (role != "Salesperson" && role != "Manager" && role != "ServiceTechnician")
            {
                MessageBox.Show("Rola musi być jedną z dozwolonych wartości: Salesperson, Manager, ServiceTechnician.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var employee = new Employee
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Role = cbRole.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    IsActive = true
                };

                _repository.Add(employee);
                LoadEmployees();
                MessageBox.Show("Pracownik został pomyślnie dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null)
            {
                MessageBox.Show("Wybierz pracownika do edycji z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                _selectedEmployee.FirstName = txtFirstName.Text.Trim();
                _selectedEmployee.LastName = txtLastName.Text.Trim();
                _selectedEmployee.Role = cbRole.Text.Trim();
                _selectedEmployee.Email = txtEmail.Text.Trim();
                _selectedEmployee.Phone = txtPhone.Text.Trim();

                _repository.Update(_selectedEmployee);
                LoadEmployees();
                MessageBox.Show("Dane pracownika zostały zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (_selectedEmployee == null)
            {
                MessageBox.Show("Wybierz pracownika do dezaktywacji z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Czy na pewno chcesz dezaktywować pracownika '{_selectedEmployee.FirstName} {_selectedEmployee.LastName}'?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _repository.Deactivate(_selectedEmployee.Id);
                    LoadEmployees();
                    MessageBox.Show("Pracownik został zdezaktywowany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas dezaktywacji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }
    }
}
