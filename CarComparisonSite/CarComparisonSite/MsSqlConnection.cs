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
                            //int s = reader.GetInt32(0);
                            //string s2 = reader.GetString(1);
                            //DateTime dateTime = reader.GetDateTime(2);
                            //double t = reader.GetDouble(3);
                            //double t2 = reader.GetDouble(4);
                            //string s3 = reader.GetString(5);
                            //string s4 = reader.GetString(6);
                            //string s5 = reader.GetString(7);
                            //double t3 = reader.GetDouble(8);


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
            //Car car = new Car(1, new Fuel(FuelType.El, 13.5f), "WhiteGuy", 34, 284800, DateTime.Now, "SCOTT Burnham", Brand.Tesla);
            //Car car1 = new Car(2, new Fuel(FuelType.El, 13.5f), "Welcome", 34, 284800, DateTime.Now, "SCOTT Burnham", Brand.Tesla);
            //Car car2 = new Car(3, new Fuel(FuelType.El, 13.5f), "To", 34, 284800, DateTime.Now, "SCOTT Burnham", Brand.Tesla);
            //Car car3 = new Car(4, new Fuel(FuelType.El, 13.5f), "the", 34, 284800, DateTime.Now, "SCOTT Burnham", Brand.Tesla);
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

        private SqlConnection GetConnection(string connName = "connString")
        {
            return new SqlConnection(config.GetConnectionString(connName));
        }
    }
}
