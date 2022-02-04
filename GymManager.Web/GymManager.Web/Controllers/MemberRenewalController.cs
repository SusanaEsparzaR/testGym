using GymManager.ApplicationServices.Members;
using GymManager.Core.Members;
using GymManager.Core.MembershipTypes;
using GymManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.Web.Controllers
{
    public class MemberRenewalController : Controller
    {
        private readonly IMembersAppService _membersAppService;

        public MemberRenewalController(IMembersAppService membersAppService)
        {
            _membersAppService = membersAppService;
        }

        public async Task<IActionResult> Index()
        {

            List<Member> members = await _membersAppService.GetMembersAsync();

            MemberListViewModel viewModel = new MemberListViewModel();

            viewModel.NewMembersCount = 2;
            viewModel.Members = members;

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int memberId)
        {

            Member member = await _membersAppService.GetMemberAsync(memberId);
            MemberViewModel viewModel = new MemberViewModel { };
            if (member.MembershipType != null)
            {
                viewModel.AllowNewsletter = member.AllowNewsletter;
                viewModel.BirthDay = member.BirthDay;
                viewModel.City = member.City.Id;
                viewModel.Email = member.Email;
                viewModel.Id = member.Id;
                viewModel.LastName = member.LastName;
                viewModel.Name = member.Name;
                viewModel.MembershipType = member.MembershipType.Id;
            }
            else
            {
                viewModel.AllowNewsletter = member.AllowNewsletter;
                viewModel.BirthDay = member.BirthDay;
                viewModel.City = member.City.Id;
                viewModel.Email = member.Email;
                viewModel.Id = member.Id;
                viewModel.LastName = member.LastName;
                viewModel.Name = member.Name;
            }
            

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(MemberViewModel viewModel)
        {
            Member member = new Member
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                LastName = viewModel.LastName,
                Email = viewModel.Email,
                City = new City
                {
                    Id = viewModel.City
                },
                BirthDay = viewModel.BirthDay,
                AllowNewsletter = viewModel.AllowNewsletter,
                MembershipType = new MembershipType
                {
                    Id = viewModel.MembershipType
                },
            };

            await _membersAppService.EditMemberAsync(member);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Search(MemberListViewModel name)
        {

            List<Member> members = await _membersAppService.GetMembersAsync();

            MemberListViewModel viewModel = new MemberListViewModel();

            return View(viewModel);
        }

    }
}
