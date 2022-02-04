using System.ComponentModel.DataAnnotations;

namespace GymManager.Web.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Please enter a valid email address."), StringLength(256), EmailAddress]
        public string UserName { get; set;}

        [Required, StringLength(32)]
        public string PhoneNumber { get; set;}

        [Required, StringLength(100, MinimumLength =5)]
        public string Password { get; set;}

        public string Id { get; set; }
    }
}
