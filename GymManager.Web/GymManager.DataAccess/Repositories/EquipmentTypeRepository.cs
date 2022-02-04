using GymManager.Core.MembershipTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess.Repositories
{
    public class EquipmentTypeRepository : Repository<int, EquipmentType>
    {
        public EquipmentTypeRepository(GymManagerContext context) : base(context)
        {

        }
        public override async Task<EquipmentType> AddAsync(EquipmentType entity)
        {
            var equipmentType = await Context.EquipmentType.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<EquipmentType> UpdateAsync(EquipmentType entity)
        {
            var equipmentType = await Context.EquipmentType.FindAsync(entity.Id);
            equipmentType.Name = entity.Name;
            equipmentType.WorkArea = entity.WorkArea;
            await Context.SaveChangesAsync();

            return entity;
        }

        public override async Task<EquipmentType> GetAsync(int id)
        {
            var equipmentType = await Context.EquipmentType.FirstOrDefaultAsync(x => x.Id == id);
            return equipmentType;
        }
    }
}