﻿using DataAccessExample.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Example.EntityFramework
{
    public class QueriesExample : IQueriesExample
    {
        private readonly VehiclesDataContext _dataContext;

        public QueriesExample(VehiclesDataContext dataContex)
        {
            _dataContext = dataContex;
        }

        public List<Make> GetMakes()
        {
            //List<Make> makes = _dataContext.Makes.ToList();
            List<Make> makes = _dataContext.Makes.Include(x=>x.Vehicles).OrderBy(x=>x.Country).ToList();

            return makes;
        }

        public List<Vehicle> GetVehiclesByPrice(decimal from_, decimal to)
        {
            //List<Vehicle> vehicles = _dataContext.Inventories.Where(x => x.Price >= from && x.Price <= to).Select(x => x.Vehicle).ToList();

            var vehicles = (from i in _dataContext.Inventories 
                            join v in _dataContext.Vehicles on i.Vehicle.Id equals v.Id
                            where i.Price >= from_ && i.Price <= to
                            select v).ToList();

            return vehicles;
        }
    }
}