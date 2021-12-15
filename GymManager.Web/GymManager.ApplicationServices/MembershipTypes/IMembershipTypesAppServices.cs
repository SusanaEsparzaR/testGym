using GymManager.Core.MembershipTypes;
using System.Collections.Generic;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public interface IMembershipTypesAppServices
    {
        List<MembershipType> GetMembershipTypes();
    }
}
