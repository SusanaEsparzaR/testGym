using Microsoft.AspNetCore.Mvc;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
