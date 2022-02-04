using GymManager.Core.Members;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Core.MembershipTypes
{
    public class MembershipType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "You must enter the member's name")]
        public string Name { get; set; }
        
        [Required]
        public double Cost { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Only whole numbers are allowed")]
        [Required]
        public int Duration { get; set; }

        public EquipmentType EquipmentType { get; set; }

        public List<Member> Members { get; set; }

        public MembershipType()
        {
            Members = new List<Member>();
        }

    }
}
