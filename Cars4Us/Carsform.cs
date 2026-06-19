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