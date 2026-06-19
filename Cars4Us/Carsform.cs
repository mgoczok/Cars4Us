using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cars4Us
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            dgvCars.CellFormatting += dgvCars_CellFormatting;
            LoadCars();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVin.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(cbEngine.Text))
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola tekstowe (VIN, Marka, Model, Silnik).", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtMileage.Text, out int mileage) || mileage < 0)
            {
                MessageBox.Show("Przebieg musi być prawidłową liczbą całkowitą, nie mniejszą niż 0.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Cena musi być prawidłową liczbą większą od 0.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DbConnection db = new DbConnection();

                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query =
                    @"INSERT INTO Cars
                    (VIN, Brand, Model,
                    EngineType, Mileage,
                    BasePrice, Status)

                    VALUES
                    (@vin,@brand,@model,
                    @engine,@mileage,
                    @price,@status)";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@vin", txtVin.Text.Trim());
                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@model", txtModel.Text.Trim());
                    cmd.Parameters.AddWithValue("@engine", cbEngine.Text.Trim());
                    cmd.Parameters.AddWithValue("@mileage", mileage);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@status", string.IsNullOrWhiteSpace(cbStatus.Text) ? "Available" : cbStatus.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dodano auto", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas dodawania auta: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz samochód do usunięcia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedId = Convert.ToInt32(dgvCars.SelectedRows[0].Cells["Id"].Value);

            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć ten samochód?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    DbConnection db = new DbConnection();
                    using (var conn = db.GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM cars WHERE Id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show("Samochód usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadCars();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1451)
                    {
                        MessageBox.Show("Ten samochód nie może zostać usunięty, ponieważ jest powiązany z innymi rekordami (np. transakcjami).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Błąd bazy danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas usuwania auta: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadCars()
        {
            try
            {
                DbConnection db = new DbConnection();

                using (var conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM Cars";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable table =
                        new DataTable();

                    adapter.Fill(table);

                    dgvCars.DataSource = table;

                    if (dgvCars.Columns["Id"] != null) dgvCars.Columns["Id"].HeaderText = "ID";
                    if (dgvCars.Columns["VIN"] != null) dgvCars.Columns["VIN"].HeaderText = "VIN";
                    if (dgvCars.Columns["Brand"] != null) dgvCars.Columns["Brand"].HeaderText = "Marka";
                    if (dgvCars.Columns["Model"] != null) dgvCars.Columns["Model"].HeaderText = "Model";
                    if (dgvCars.Columns["EngineType"] != null) dgvCars.Columns["EngineType"].HeaderText = "Silnik";
                    if (dgvCars.Columns["Mileage"] != null) 
                    {
                        dgvCars.Columns["Mileage"].HeaderText = "Przebieg";
                        dgvCars.Columns["Mileage"].DefaultCellStyle.Format = "N0";
                    }
                    if (dgvCars.Columns["BasePrice"] != null) 
                    {
                        dgvCars.Columns["BasePrice"].HeaderText = "Cena bazowa";
                        dgvCars.Columns["BasePrice"].DefaultCellStyle.Format = "C2";
                    }
                    if (dgvCars.Columns["Status"] != null) dgvCars.Columns["Status"].HeaderText = "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd podczas ładowania aut z bazy: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVin.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtMileage.Clear();
            txtPrice.Clear();
            cbEngine.SelectedIndex = -1;
            if (cbStatus.Items.Count > 0) cbStatus.SelectedIndex = 0;
        }

        private void dgvCars_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCars.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Available")
                {
                    e.Value = "Dostępny";
                    e.FormattingApplied = true;
                }
                else if (status == "OnOrder")
                {
                    e.Value = "Na zamówienie";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}