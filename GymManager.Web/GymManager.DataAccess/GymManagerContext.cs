using GymManager.Core.Members;
using GymManager.Core.Sales;
using GymManager.Core.MembershipTypes;
using GymManager.Core.Products;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class GymManagerContext : IdentityDbContext
    {
        public virtual DbSet<Member> Members { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<EquipmentType> EquipmentType { get; set; }

        public virtual DbSet<MembershipType> MembershipType { get; set; }

        public virtual DbSet<Inventory> Inventory { get; set; }

        public virtual DbSet<MeasureType> MeasureType { get; set; }

        public virtual DbSet<ProductsType> ProductsType { get; set; }

        public virtual DbSet<Sale> Sales { get; set; }

        public GymManagerContext(DbContextOptions<GymManagerContext> options) : base(options)
        {

        }

    }
}
