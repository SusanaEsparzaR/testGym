using System.Collections.Generic;
using GymManager.Core.MembershipTypes;

namespace GymManager.Web.Models
{
    public class MembershipListViewModel
    {
        public int NewMembershipCount { get; set; }
        public List<MembershipType> MembershipTypes { get; set; }
    }
}