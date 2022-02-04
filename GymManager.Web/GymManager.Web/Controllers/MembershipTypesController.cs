using GymManager.ApplicationServices.MembershipTypes;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypesAppServices _membershipTypesAppServices;

        public MembershipTypesController(IMembershipTypesAppServices membershipTypesAppServices)
        {
            _membershipTypesAppServices = membershipTypesAppServices;
        }

        public async Task<IActionResult> Index()
        {
            List<MembershipType> list = await _membershipTypesAppServices.GetMembershipTypesAsync();
            MembershipListViewModel viewModelMembershipType = new MembershipListViewModel();

            viewModelMembershipType.MembershipTypes = list;

            return View(viewModelMembershipType);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(MembershipType membershipType)
        {
            await _membershipTypesAppServices.AddMembershipTypeAsync(membershipType);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int memberId)
        {
            await _membershipTypesAppServices.DeleteMembershipTypeAsync(memberId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int memberId)
        {

            MembershipType viewModelMembershipType = await _membershipTypesAppServices.GetMembershipTypeAsync(memberId);

            return View(viewModelMembershipType);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MembershipType membershipType)
        {
            await _membershipTypesAppServices.EditMembershipTypeAsync(membershipType);
            return RedirectToAction("Index");
        }
    }
}
