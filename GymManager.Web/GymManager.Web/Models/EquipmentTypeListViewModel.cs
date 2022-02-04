using GymManager.Core.MembershipTypes;
using System.Collections.Generic;

namespace GymManager.Web.Models
{
    public class EquipmentTypeListViewModel
    {
        public int NewMembershipCount { get; set; }
        public List<EquipmentType> EquipmentTypes { get; set; }
    }
}
