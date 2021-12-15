using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public class MembershipTypesAppServices : IMembershipTypesAppServices
    {
        private static List<MembershipType> MembershipTypes = new List<MembershipType>();

        public int AddMembershipType(MembershipType membershipType)
        {
            membershipType.Id = new Random().Next();
            MembershipTypes.Add(membershipType);
            return membershipType.Id;
        }

        public void DeleteMembershipType(int membershipTypeId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypeId).FirstOrDefault();
            MembershipTypes.Remove(m);
        }

        public void EditMembershipType(MembershipType membershipType)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipType.Id).FirstOrDefault();
            m.Name = membershipType.Name;
            m.Cost = membershipType.Cost;
            m.CreatedOn = membershipType.CreatedOn;
            m.Duration = membershipType.Duration;
        }

        public MembershipType GetMembershipType(int membershipTypeId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypeId).FirstOrDefault();
            return m;
        }

        public List<MembershipType> GetMembershipTypes()
        {
            return MembershipTypes;
        }
    }
}
