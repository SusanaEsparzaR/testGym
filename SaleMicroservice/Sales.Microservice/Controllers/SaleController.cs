using Microsoft.AspNetCore.Mvc;
using SaleMicroservice.ApplicationServices.Sales;
using SaleMicroservice.Core.Sales;
using SaleMicroservice.Core.Seller;
using SaleMicroservice.DataAccess;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sales.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : Controller
    {
        private readonly ISaleAppServices _saleAppServices;

        public SaleController(ISaleAppServices saleAppServices)
        {
            _saleAppServices = saleAppServices;
        }

        [HttpGet]
        public async Task<JsonResult> Get()
        {
            List<Sale> sales = await _saleAppServices.GetSalesAsync();
            return new JsonResult(sales);
        }

        [HttpGet("{id}")]
        public async Task<JsonResult> Get(int id)
        {
            var sale = await _saleAppServices.GetSaleAsync(id);
            return new JsonResult(sale);
        }

        [HttpPost]
        public async Task<JsonResult> Post([FromBody] Sale value)
        {
            HttpClient product = new HttpClient();
            HttpResponseMessage response = await product.GetAsync($"http://localhost:5000/api/products/{value.ProductId}");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            var productC = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

            if (productC != null)
            {
                var result = _saleAppServices.AddSaleAsync(value);

                return new JsonResult(result);
            }
            else
            {
                return new JsonResult("Doesn´t exist a register with PRODUCT id: " + value.ProductId);
            }

        }

        [HttpPut]
        public JsonResult Edit([FromBody] Sale value)
        {
            var result = _saleAppServices.EditSaleAsync(value);

            return new JsonResult(result);
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(int id)
        {
            var sale = await _saleAppServices.GetSaleAsync(id);
            if (sale == null)
            {
                return new JsonResult("Id: " + id + " not exist");
            }
            else
            {
                await _saleAppServices.DeleteSaleAsync(id);
                return new JsonResult("Id: " + id + " deleted");
            }
        }
    }
}
