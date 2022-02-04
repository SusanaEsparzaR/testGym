using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace GymManager.Web.Controllers
{
    public class InvoicingController : Controller
    {

        private readonly IGeneratePdf _generatePdf;

        public InvoicingController(IGeneratePdf generatePdf)
        {
            _generatePdf = generatePdf;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenereteInvoice()
        {
            return View();
        }

        public async Task<IActionResult> Print()
        {
            return await _generatePdf.GetPdf("~/Views/Invoicing/Print.cshtml");
        }
    }
}
