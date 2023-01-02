using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparisonSite
{
    public interface IFetchCarFromDb
    {
        public List<Car> GetAllCars();
        public List<Brand> GetAllBrands();
        public List<string> GetModelsByBrand(Brand brand);
        public List<string> GetVariantsByModel(string model);
        public List<int> GetYears(Brand? brand, string variant = "", string model = "");
    }
}
