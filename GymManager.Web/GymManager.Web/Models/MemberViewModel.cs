using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class MemberViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter the member's name"), StringLength(15)]
        public string Name { get; set; }

        [Required, StringLength(20)]
        public string LastName { get; set; }

        [BindProperty, DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required ,EmailAddress]
        public string Email { get; set; }

        public bool AllowNewsletter { get; set; }

        [Required]
        public int City { get; set; }

        public int MembershipType { get; set; }

    }
}
