using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.Core.MembershipTypes
{
    public class EquipmentType
    {
        [Key]
        public int Id { get; set; }

        [Required ,StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(100)]
        public string WorkArea { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime AcquisitionDate { get; set; }

        public List<MembershipType> MembershipTypes { get; set; }

        public EquipmentType()
        {
            MembershipTypes = new List<MembershipType>();
        }
    }
}
