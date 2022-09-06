using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarComparisonSite
{
    public interface IFetchCarFromDb
    {
        public List<Car> GetAllCars();
    }
}
