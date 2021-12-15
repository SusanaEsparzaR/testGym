using GymManager.Core.MembershipTypes;
using System.Collections.Generic;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public interface IMembershipTypesAppServices
    {
        List<MembershipType> GetMembershipTypes();

        int AddMembershipType(MembershipType membershipType);

        void EditMembershipType(MembershipType membershipType);

        void DeleteMembershipType(int membershipTypeId);

        MembershipType GetMembershipType(int membershipTypeId);
    }
}
