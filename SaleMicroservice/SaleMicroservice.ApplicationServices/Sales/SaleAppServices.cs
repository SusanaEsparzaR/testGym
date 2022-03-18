using Microsoft.EntityFrameworkCore;
using SaleMicroservice.Core.Sales;
using SaleMicroservice.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleMicroservice.ApplicationServices.Sales
{
    public class SaleAppServices : ISaleAppServices
    {
        private readonly IRepository<int, Sale> _repository;

        public SaleAppServices(IRepository<int, Sale> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddSaleAsync(Sale sale)
        {
            await _repository.AddAsync(sale);
            return sale.Id;
        }

        public async Task DeleteSaleAsync(int saleId)
        {
            await _repository.DeleteAsync(saleId);
        }

        public async Task EditSaleAsync(Sale sale)
        {
            await _repository.UpdateAsync(sale);
        }

        public async Task<Sale> GetSaleAsync(int saleId)
        {
            return await _repository.GetAsync(saleId);
        }

        public async Task<List<Sale>> GetSalesAsync()
        {
            var list = await _repository.GetAll().ToListAsync();
            return list;
        }
    }
}
