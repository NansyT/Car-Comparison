using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace CarComparisonSite
{
    public class Ms_SqlConnector : IFetchCarFromDb
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private IConfiguration config;

        public Ms_SqlConnector(IConfiguration configuration)
        {
            this.config = configuration;
        }

        public List<Car> GetAllCars()
        {
            using (connection = GetConnection())
            {
                List<Car> cars = new List<Car>();
                connection.Open();
                using (command = new MySqlCommand("GetCars", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car c = new Car(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetDateTime(2),
                                reader.GetDouble(3),
                                reader.GetDouble(4),
                                reader.GetString(5),
                                Enum.Parse<Brand>(reader.GetString(6).Replace("-", "")),
                                new Fuel(
                                    Enum.Parse<FuelType>(reader.GetString(7)),
                                    reader.GetDouble(8))
                                );
                            cars.Add(c);
                        }
                        return cars;
                    }
                }
            }
        }

        public List<Brand> GetAllBrands()
        {
            using (connection = GetConnection())
            {
                List<Brand> brands = new List<Brand>();
                connection.Open();
                using (command = new MySqlCommand("GetBrands", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            brands.Add(Enum.Parse<Brand>(reader.GetString(0).Replace("-", "")));
                        }
                        return brands;
                    }
                }
            }
        }

        public List<string> GetModelsByBrand(Brand brand)
        {
            using (connection = GetConnection())
            {
                List<string> models = new List<string>();
                connection.Open();
                using (command = new MySqlCommand("GetModelsByBrand", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Brand", brand.ToString());
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            models.Add(reader.GetString(0));
                        }
                    }
                    return models;
                }
            }
        }
        public List<string> GetVariantsByModel(string model)
        {
            using (connection = GetConnection())
            {
                List<string> variants = new List<string>();
                connection.Open();
                using (command = new MySqlCommand("GetVariantByModel", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("model", model);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            variants.Add(reader.GetString(0));
                        }
                    }
                    return variants;
                }
            }
        }

        public List<int> GetYears(Brand? brand, string variant = "", string model = "")
        {
            using (connection = GetConnection())
            {
                List<int> years = new List<int>();
                connection.Open();
                using (command = new MySqlCommand("GetYears", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("brand", brand);
                    command.Parameters.AddWithValue("variant", variant);
                    command.Parameters.AddWithValue("model", model);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            years.Add(reader.GetInt32(0));
                        }
                    }
                    return years;
                }
            }
        }

        private MySqlConnection GetConnection(string connName = "mysqlConn")
        {
            return new MySqlConnection(config.GetConnectionString(connName));
        }
    }
}
