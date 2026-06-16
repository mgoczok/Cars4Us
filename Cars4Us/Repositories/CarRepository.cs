using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Cars4Us.Models;

namespace Cars4Us.Repositories
{
    public class CarRepository
    {
        public List<Car> GetAllAvailable()
        {
            var cars = new List<Car>();
            DbConnection db = new DbConnection();

            using (var conn = db.GetConnection())
            {
                conn.Open();
                string query = @"SELECT Id, VIN, Brand, Model, EngineType, Mileage, BasePrice, Status 
                                 FROM cars 
                                 WHERE Status = 'Available' 
                                 ORDER BY Brand ASC, Model ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cars.Add(new Car
                        {
                            Id = reader.GetInt32("Id"),
                            VIN = reader.GetString("VIN"),
                            Brand = reader.GetString("Brand"),
                            Model = reader.GetString("Model"),
                            EngineType = reader.GetString("EngineType"),
                            Mileage = reader.GetInt32("Mileage"),
                            BasePrice = reader.GetDecimal("BasePrice"),
                            Status = reader.GetString("Status")
                        });
                    }
                }
            }

            return cars;
        }
    }
}
