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

                cmd.Parameters.AddWithValue("@vin", txtVin.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@engine", cbEngine.Text);
                cmd.Parameters.AddWithValue("@mileage", txtMileage.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dodano auto");
            }

            LoadCars();
        }

        private void LoadCars()
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}