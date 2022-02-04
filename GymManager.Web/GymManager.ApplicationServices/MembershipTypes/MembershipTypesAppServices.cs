using GymManager.Core.MembershipTypes;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public class MembershipTypesAppServices : IMembershipTypesAppServices
    {
        private readonly IRepository<int, MembershipType> _repository;

        public MembershipTypesAppServices(IRepository<int, MembershipType> repository)
        {
            _repository = repository;
        }

        public async Task<int> AddMembershipTypeAsync(MembershipType membershipType)
        {
            await _repository.AddAsync(membershipType);
            return membershipType.Id;
        }

        public async Task DeleteMembershipTypeAsync(int membershipTypeId)
        {
            await _repository.DeleteAsync(membershipTypeId);
        }

        public async Task EditMembershipTypeAsync(MembershipType membershipType)
        {
            await _repository.UpdateAsync(membershipType);
        }

        public async Task<MembershipType> GetMembershipTypeAsync(int membershipTypeId)
        {
            return await _repository.GetAsync(membershipTypeId);
        }

        public async Task<List<MembershipType>> GetMembershipTypesAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
    }
}
