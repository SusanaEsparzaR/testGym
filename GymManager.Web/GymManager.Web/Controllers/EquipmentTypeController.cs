using GymManager.ApplicationServices.EquipmentTypes;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class EquipmentTypeController : Controller
    {
        private readonly IEquipmentTypeAppServices _equipmentTypeAppServices;

        public EquipmentTypeController(IEquipmentTypeAppServices equipmentTypeAppServices)
        {
            _equipmentTypeAppServices = equipmentTypeAppServices;
        }

        public async Task<IActionResult> Index()
        {
            List<EquipmentType> list = await _equipmentTypeAppServices.GetEquipmentTypesAsync();
            EquipmentTypeListViewModel equipmentTypeListViewModel = new EquipmentTypeListViewModel();

            equipmentTypeListViewModel.EquipmentTypes = list;

            return View(equipmentTypeListViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EquipmentType membershipType)
        {
            await _equipmentTypeAppServices.AddEquipmentTypeAsync(membershipType);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int memberId)
        {
            await _equipmentTypeAppServices.DeleteEquipmentTypeAsync(memberId);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int memberId)
        {

            EquipmentType viewModelMembershipType = await _equipmentTypeAppServices.GetEquipmentTypeAsync(memberId);

            return View(viewModelMembershipType);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EquipmentType membershipType)
        {
            await _equipmentTypeAppServices.EditEquipmentTypeAsync(membershipType);
            return RedirectToAction("Index");
        }
    }
}
