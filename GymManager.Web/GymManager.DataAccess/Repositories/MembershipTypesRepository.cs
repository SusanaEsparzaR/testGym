using GymManager.Core.MembershipTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess.Repositories
{
    public class MembershipTypesRepository : Repository<int, MembershipType>
    {
        public MembershipTypesRepository(GymManagerContext context) : base(context)
        {

        }
        public override async Task<MembershipType> AddAsync(MembershipType entity)
        {
            var membership = await Context.MembershipType.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<MembershipType> UpdateAsync(MembershipType entity)
        {
            var membership = await Context.MembershipType.FindAsync(entity.Id);
            membership.Name = entity.Name;
            membership.Cost = entity.Cost;
            membership.Duration = entity.Duration;
            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<MembershipType> GetAsync(int id)
        {
            var membershiptype = await Context.MembershipType.FirstOrDefaultAsync(x => x.Id == id);
            return membershiptype;
        }
    }
}