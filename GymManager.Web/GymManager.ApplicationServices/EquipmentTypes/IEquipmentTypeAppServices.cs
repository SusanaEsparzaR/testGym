using GymManager.Core.MembershipTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.EquipmentTypes
{
    public interface IEquipmentTypeAppServices
    {
        Task<List<EquipmentType>> GetEquipmentTypesAsync();

        Task<int> AddEquipmentTypeAsync(EquipmentType equipmentType);

        Task EditEquipmentTypeAsync(EquipmentType equipmentType);

        Task DeleteEquipmentTypeAsync(int equipmentTypeId);

        Task<EquipmentType> GetEquipmentTypeAsync(int equipmentTypeId);
    }
}
