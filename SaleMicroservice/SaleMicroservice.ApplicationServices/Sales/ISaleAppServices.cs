using SaleMicroservice.Core.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleMicroservice.ApplicationServices.Sales
{
    public interface ISaleAppServices
    {
        Task<List<Sale>> GetSalesAsync();

        Task<int> AddSaleAsync(Sale sale);

        Task DeleteSaleAsync(int saleId);

        Task<Sale> GetSaleAsync(int saleId);

        Task EditSaleAsync(Sale sale);
    }
}
