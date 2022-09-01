using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparisonSite
{
    interface IFetchCarFromDb
    {
        public List<Car> GetCars(string variant, string model, DateTime releaseYear, Brand? brand);

        public FilterOptions GetOnLoad();
    }
}
