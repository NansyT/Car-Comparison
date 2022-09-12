using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparisonSite
{
    public class Fuel
    {
        private FuelType fuelType;

        public FuelType FuelType
        {
            get { return fuelType; }
            private set { fuelType = value; }
        }


        private double pricePerUnit;

        public double PricePerUnit
        {
            get { return pricePerUnit; }
            private set { pricePerUnit = value; }
        }

        public Fuel(FuelType fuelType, double pricePerUnit)
        {
            FuelType = fuelType;
            PricePerUnit = pricePerUnit;
        }
    }
}
