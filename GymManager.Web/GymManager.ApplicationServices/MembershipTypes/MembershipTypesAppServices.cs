using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;

namespace GymManager.ApplicationServices.MembershipTypes
{
    public class MembershipTypesAppServices : IMembershipTypesAppServices
    {
        private static List<MembershipType> MembershipTypes = new List<MembershipType>();

        public List<MembershipType> GetMembershipTypes()
        {
            List<MembershipType> list = new List<MembershipType>();
            list.Add(new MembershipType
            {
                Name = "Elite",
                Cost = 500,
                CreatedOn = DateTime.Now,
                Duration = 12
            });
            list.Add(new MembershipType
            {
                Name = "Yearly",
                Cost = 400,
                CreatedOn = DateTime.Now,
                Duration = 12
            });
            list.Add(new MembershipType
            {
                Name = "Six",
                Cost = 270,
                CreatedOn = DateTime.Now,
                Duration = 6
            });
            list.Add(new MembershipType
            {
                Name = "Three",
                Cost = 160,
                CreatedOn = DateTime.Now,
                Duration = 3
            });
            list.Add(new MembershipType
            {
                Name = "Monthly",
                Cost = 60,
                CreatedOn = DateTime.Now,
                Duration = 1
            });
            return list;
        }
    }
}
