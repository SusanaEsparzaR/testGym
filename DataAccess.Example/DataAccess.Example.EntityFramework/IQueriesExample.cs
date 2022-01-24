using DataAccessExample.Core;
using System.Collections.Generic;

namespace DataAccess.Example.EntityFramework
{
    public interface IQueriesExample
    {
        List<Make> GetMakes();

        List<Vehicle> GetVehiclesByPrice(decimal from, decimal to);
    }
}
