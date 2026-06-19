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
                    @price,'Available')";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@vin", txtVin.Text.Trim());
                    cmd.Parameters.AddWithValue("@brand", txtBrand.Text.Trim());
                    cmd.Parameters.AddWithValue("@model", txtModel.Text.Trim());
                    cmd.Parameters.AddWithValue("@engine", cbEngine.Text.Trim());
                    cmd.Parameters.AddWithValue("@mileage", mileage);
                    cmd.Parameters.AddWithValue("@price", price);

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
                    if (dgvCars.Columns["Mileage"] != null) dgvCars.Columns["Mileage"].HeaderText = "Przebieg";
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
    }
}