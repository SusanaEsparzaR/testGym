using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleMicroservice.Core.Seller;
using SaleMicroservice.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Microservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SellerController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly SaleMicroserviceContext _context;

        public SellerController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, SaleMicroserviceContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var users = await _userManager.Users.ToListAsync();
            return new JsonResult(users);
        }

        [HttpGet("{id}")]
        public async Task<JsonResult> Get(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            return new JsonResult(user);
        }

        [HttpPost]
        public JsonResult Post([FromBody] Seller value)
        {
            var result = _userManager.CreateAsync(new IdentityUser
            {
                Email = value.Email,
                EmailConfirmed = true,
                UserName = value.UserName,
                PhoneNumber = value.PhoneNumber,
                PhoneNumberConfirmed = true
            }, value.Password).Result;

            if (result.Succeeded)
            {
                return new JsonResult("Success");
            }
            else
            {
                return new JsonResult("Failed");
            }
            
        }

        [HttpPut]
        public async Task<JsonResult> Edit([FromBody] Seller value)
        {
            var user = await _userManager.FindByIdAsync(value.Id);

            user.UserName = value.UserName;
            user.Email = value.Email;
            user.PhoneNumber = value.PhoneNumber;

            string hashedNewPassword = _userManager.PasswordHasher.HashPassword(user, value.Password);

            UserStore<IdentityUser> store = new UserStore<IdentityUser>(_context);

            await store.SetPasswordHashAsync(user, hashedNewPassword);
            await store.UpdateAsync(user);
            return new JsonResult(user);
        }

        [HttpDelete("{id}")]
        public async Task<JsonResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return new JsonResult("Success");
            }
            else
            {
                return new JsonResult("Failed");
            }
        }
    }
}
