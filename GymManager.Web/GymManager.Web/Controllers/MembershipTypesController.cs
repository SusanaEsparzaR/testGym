using GymManager.ApplicationServices.MembershipTypes;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GymManager.Web.Controllers
{
    public class MembershipTypesController : Controller
    {
        private readonly IMembershipTypesAppServices _membershipTypesAppServices;

        public MembershipTypesController(IMembershipTypesAppServices membershipTypesAppServices)
        {
            _membershipTypesAppServices = membershipTypesAppServices;
        }

        public IActionResult Index()
        {
            List<MembershipType> list = _membershipTypesAppServices.GetMembershipTypes();

            MembershipListViewModel viewModelMembershipType = new MembershipListViewModel();

            viewModelMembershipType.MembershipTypes = list;

            return View(viewModelMembershipType);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MembershipType membershipType)
        {
            _membershipTypesAppServices.AddMembershipType(membershipType);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int memberId)
        {
            _membershipTypesAppServices.DeleteMembershipType(memberId);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int memberId)
        {

            MembershipType membershipType = _membershipTypesAppServices.GetMembershipType(memberId);

            return View(membershipType);
        }

        [HttpPost]
        public IActionResult Edit(MembershipType membershipType)
        {
            _membershipTypesAppServices.EditMembershipType(membershipType);
            return RedirectToAction("Index");
        }
    }
}
