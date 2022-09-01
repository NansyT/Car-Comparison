using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparisonSite
{
    public class FilterOptions
    {
        private string variant;

        public string Variant
        {
            get { return variant; }
            private set { variant = value; }
        }

        private DateTime dateTime;

        public DateTime ReleaseYear
        {
            get { return dateTime; }
            private set { dateTime = value; }
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

        public FilterOptions(string variant, DateTime releaseYear, string model, Brand brand)
        {
            Variant = variant;
            ReleaseYear = releaseYear;
            Model = model;
            Brand = brand;
        }

    }
}
