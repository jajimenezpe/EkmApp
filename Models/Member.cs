using System;
using System.ComponentModel.DataAnnotations;

namespace EkmApp.Models
{

    public class Member
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public int Age { get; set; }
        
        public string Membership { get; set; }

        [Display(Name = "Registration Date")]
        public DateTime RegistrationDate { get; set; }
    }
}
