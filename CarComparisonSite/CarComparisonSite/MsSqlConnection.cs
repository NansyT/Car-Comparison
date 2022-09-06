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
            return new List<Car>();
            throw new NotImplementedException();
        }
    }
}
