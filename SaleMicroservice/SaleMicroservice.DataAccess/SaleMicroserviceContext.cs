using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaleMicroservice.Core.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleMicroservice.DataAccess
{
    public class SaleMicroserviceContext : IdentityDbContext
    {
        public virtual DbSet<Sale> Sales { get; set; }

        public SaleMicroserviceContext(DbContextOptions<SaleMicroserviceContext> options) : base(options)
        {

        }
    }
}
