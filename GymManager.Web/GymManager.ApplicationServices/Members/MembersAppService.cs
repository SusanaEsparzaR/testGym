using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {
        private static List<Member> Members = new List<Member>();

        public int AddMember(Member member)
        {
            member.Id = new Random().Next();
            Members.Add(member);

            return member.Id;
        }

        public void DeleteMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            Members.Remove(m);
        }

        public void EditMember(Member member)
        {
            var m = Members.Where(x => x.Id == member.Id).FirstOrDefault();
            m.AllowNewsletter = member.AllowNewsletter;
            m.BirthDay = member.BirthDay;
            m.CityId = member.CityId;
            m.Email = member.Email;
            m.LastName = member.LastName;
            m.Name = member.Name;
        }

        public Member GetMember(int memberId)
        {
            var m = Members.Where(x => x.Id == memberId).FirstOrDefault();
            return m;
        }

        public List<Member> GetMembers()
        {
            return Members;
            /*List<Member> members = new List<Member>();
            members.Add(new Member
            {
                Name = "Israel",
                LastName = "Pérez",
                BirthDay = new DateTime(1986, 9, 24),
                AllowNewsletter = true,
                CityId = 1,
                Email = "israel@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Susana",
                LastName = "Esparza",
                BirthDay = new DateTime(2000, 9, 19),
                AllowNewsletter = true,
                CityId = 1,
                Email = "susana.esparza12@gmail.com",

            });
            members.Add(new Member
            {
                Name = "Juan",
                LastName = "López",
                BirthDay = new DateTime(1966, 9, 19),
                AllowNewsletter = true,
                CityId = 1,
                Email = "juan@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Edgar",
                LastName = "Gárcia",
                BirthDay = new DateTime(2000, 10, 11),
                AllowNewsletter = false,
                CityId = 2,
                Email = "edgar@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Camila",
                LastName = "Cabello",
                BirthDay = new DateTime(1997, 3, 03),
                AllowNewsletter = true,
                CityId = 1,
                Email = "camila@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Myriam",
                LastName = "Esparza",
                BirthDay = new DateTime(1990, 4, 18),
                AllowNewsletter = true,
                CityId = 2,
                Email = "myriam@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Bart",
                LastName = "Simpson",
                BirthDay = new DateTime(1982, 4, 20),
                AllowNewsletter = true,
                CityId = 3,
                Email = "bart@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Homero",
                LastName = "Simpson",
                BirthDay = new DateTime(1956, 2, 22),
                AllowNewsletter = true,
                CityId = 3,
                Email = "homero@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Rick",
                LastName = "Sanchez",
                BirthDay = new DateTime(1947, 3, 03),
                AllowNewsletter = true,
                CityId = 6,
                Email = "rick@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Summer",
                LastName = "Smith",
                BirthDay = new DateTime(2003, 3, 13),
                AllowNewsletter = true,
                CityId = 6,
                Email = "summer@prueba.com",

            });
            members.Add(new Member
            {
                Name = "Morty",
                LastName = "Smith",
                BirthDay = new DateTime(2008, 5, 24),
                AllowNewsletter = true,
                CityId = 6,
                Email = "morty@prueba.com",

            });*/
        }
    }
}
