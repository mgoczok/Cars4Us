using System;
using System.Windows.Forms;
using Cars4Us.Models;
using Cars4Us.Repositories;

namespace Cars4Us
{
    public partial class OptionsForm : Form
    {
        private readonly OptionRepository _repository;
        private Option? _selectedOption;

        public OptionsForm()
        {
            InitializeComponent();
            _repository = new OptionRepository();
            LoadOptions();
        }

        private void LoadOptions()
        {
            try
            {
                var options = _repository.GetAllActive();
                dgvOptions.DataSource = options;
                ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania opcji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSelection()
        {
            _selectedOption = null;
            txtName.Text = string.Empty;
            cbCategory.SelectedIndex = -1;
            numPrice.Value = 0;
            dgvOptions.ClearSelection();
        }

        private void dgvOptions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvOptions.Rows.Count)
            {
                var row = dgvOptions.Rows[e.RowIndex];
                if (row.DataBoundItem is Option option)
                {
                    _selectedOption = option;
                    txtName.Text = option.Name;
                    cbCategory.Text = option.Category;
                    numPrice.Value = option.Price;
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Nazwa opcji nie może być pusta.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Należy wybrać kategorię.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (numPrice.Value < 0)
            {
                MessageBox.Show("Cena nie może być mniejsza niż 0.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var option = new Option
                {
                    Name = txtName.Text.Trim(),
                    Category = cbCategory.Text,
                    Price = numPrice.Value,
                    IsActive = true
                };

                _repository.Add(option);
                LoadOptions();
                MessageBox.Show("Opcja została pomyślnie dodana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedOption == null)
            {
                MessageBox.Show("Wybierz opcję do edycji z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                _selectedOption.Name = txtName.Text.Trim();
                _selectedOption.Category = cbCategory.Text;
                _selectedOption.Price = numPrice.Value;

                _repository.Update(_selectedOption);
                LoadOptions();
                MessageBox.Show("Opcja została zaktualizowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas aktualizacji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (_selectedOption == null)
            {
                MessageBox.Show("Wybierz opcję do dezaktywacji z listy.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Czy na pewno chcesz dezaktywować opcję '{_selectedOption.Name}'?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _repository.Deactivate(_selectedOption.Id);
                    LoadOptions();
                    MessageBox.Show("Opcja została zdezatywowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas dezaktywacji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOptions();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSelection();
        }
    }
}
