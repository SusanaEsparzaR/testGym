using GymManager.Core.MembershipTypes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public interface IMembershipTypesAppServices
    {
        Task<List<MembershipType>> GetMembershipTypesAsync();

        Task<int> AddMembershipTypeAsync(MembershipType membershipType);

        Task EditMembershipTypeAsync(MembershipType membershipType);

        Task DeleteMembershipTypeAsync(int membershipTypeId);

        Task<MembershipType> GetMembershipTypeAsync(int membershipTypeId);
    }
}
