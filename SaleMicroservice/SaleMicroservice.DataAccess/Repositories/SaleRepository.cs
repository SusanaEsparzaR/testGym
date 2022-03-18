using Microsoft.EntityFrameworkCore;
using SaleMicroservice.Core.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleMicroservice.DataAccess.Repositories
{
    public class SaleRepository : Repository<int, Sale>
    {
        public SaleRepository(SaleMicroserviceContext context) : base(context)
        {

        }

        public override async Task<Sale> AddAsync(Sale entity)
        {
            entity.Date = DateTime.Now;
            await Context.Sales.AddAsync(entity);

            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<Sale> UpdateAsync(Sale entity)
        {
            var sale = await Context.Sales.FindAsync(entity.Id);
            sale.Date = entity.Date;
            sale.Amount = entity.Amount;
            sale.ProductId = entity.ProductId;
            await Context.SaveChangesAsync();
            return entity;
        }

        public override async Task<Sale> GetAsync(int id)
        {
            var sale = await Context.Sales.FirstOrDefaultAsync(x => x.Id == id);
            return sale;
        }
    }
}
