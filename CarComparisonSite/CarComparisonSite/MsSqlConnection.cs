using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CarComparisonSite
{
    public class MsSqlConnection : IFetchCarFromDb
    {
        private SqlConnection connection;
        private SqlCommand command;
        private IConfiguration config;

        public MsSqlConnection(IConfiguration configuration)
        {
            this.config = configuration;
        }

        public List<Car> GetAllCars()
        {
            using (connection = GetConnection())
            {
                List<Car> cars = new List<Car>();
                connection.Open();
                using (command = new SqlCommand("GetCars", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
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
                                Enum.Parse<Brand>(reader.GetString(6)),
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
            #region TestData
            //Car car = new Car(1, "WhiteGuy", DateTime.Now, 34, 284800, "SCOTT Burnham", Brand.Tesla, new Fuel(FuelType.El, 13.5f));
            //Car car1 = new Car(2, "Welcome", DateTime.Now, 34, 284800, "SCOTT Burnham", Brand.Tesla, new Fuel(FuelType.El, 13.5f));
            //Car car2 = new Car(3, "To", DateTime.Now, 34, 284800, "SCOTT Burnham", Brand.Tesla, new Fuel(FuelType.El, 13.5f));
            //Car car3 = new Car(4, "the", DateTime.Now, 34, 284800, "SCOTT Burnham", Brand.Tesla, new Fuel(FuelType.Benzin, 13.5f));
            //Car car4 = new Car(5, new Fuel(FuelType.Benzin, 13.5f), "Internet", 34, 284800, DateTime.Now, "SCOTT Burnham", Brand.Tesla);
            //Car car5 = new Car(6, new Fuel(FuelType.El, 13.5f), "Baddest", 34, 284800, DateTime.Now, "KDA", Brand.Mitsubishi);
            //Car car6 = new Car(7, new Fuel(FuelType.Benzin, 13.5f), "COMINGATYOULIVE", 34, 284800, DateTime.Now.AddYears(-1), "KDA", Brand.BMW);
            //Car car7 = new Car(8, new Fuel(FuelType.Benzin, 13.5f), "BALLER", 34, 284800, DateTime.Now.AddYears(-12), "KDA", Brand.BMW);
            //Car car8 = new Car(9, new Fuel(FuelType.Benzin, 13.5f), "GIANTS", 34, 284800, DateTime.Now.AddYears(-12), "TrueDamage", Brand.Chevrolet);



            //return new List<Car>()
            //{
            //    car,car1,car2,car3,car4,car5,car6,car7,car8
            //};
            #endregion
        }

        public List<Brand> GetAllBrands()
        {
            using (connection = GetConnection())
            {
                List<Brand> brands = new List<Brand>();
                connection.Open();
                using (command = new SqlCommand("GetBrands", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            brands.Add(Enum.Parse<Brand>(reader.GetString(0)));
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
                using (command = new SqlCommand("GetModelsByBrand", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Brand", brand.ToString());
                    using (SqlDataReader reader = command.ExecuteReader())
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
                using (command = new SqlCommand("GetVariantByModel", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("model", model);
                    using (SqlDataReader reader = command.ExecuteReader())
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
                using (command = new SqlCommand("GetYears", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("brand", brand);
                    command.Parameters.AddWithValue("variant", variant);
                    command.Parameters.AddWithValue("model", model);
                    using (SqlDataReader reader = command.ExecuteReader())
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

        private SqlConnection GetConnection(string connName = "connString")
        {
            return new SqlConnection(config.GetConnectionString(connName));
        }
    }
}
