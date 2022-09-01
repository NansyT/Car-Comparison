﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
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

        public List<Car> GetCars(string variant, string model, DateTime releaseYear, Brand? brand)
        {
            throw new NotImplementedException();
        }

        public FilterOptions GetOnLoad()
        {
            throw new NotImplementedException();
        }
    }
}