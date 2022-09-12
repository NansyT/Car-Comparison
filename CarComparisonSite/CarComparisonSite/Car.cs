using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparisonSite
{
    public class Car
    {
        private int carId;

        public int CarId
        {
            get { return carId; }
            set { carId = value; }
        }


        private Fuel fuel;

        public Fuel Fuel
        {
            get { return fuel; }
            private set { fuel = value; }
        }

        private string variant;

        public string Variant
        {
            get { return variant; }
            private set { variant = value; }
        }

        private float fuelUsagePerKM;

        public float FuelUsagePerKM
        {
            get { return fuelUsagePerKM; }
            private set { fuelUsagePerKM = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            private set { price = value; }
        }

        private DateTime releaseYear;

        public DateTime ReleaseYear
        {
            get { return releaseYear; }
            private set { releaseYear = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        private Brand brand;

        public Brand Brand
        {
            get { return brand; }
            private set { brand = value; }
        }

        public Car(int carId, string variant, DateTime releaseYear, float fuelUsagePerKM, float price, string model, Brand brand, Fuel fuel)
        {
            CarId = carId;
            Variant = variant;
            ReleaseYear = releaseYear;
            FuelUsagePerKM = fuelUsagePerKM;
            Price = price;
            Model = model;
            Brand = brand;
            Fuel = fuel;
        }
    }
}
