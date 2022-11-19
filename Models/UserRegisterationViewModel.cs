using System.ComponentModel.DataAnnotations;

namespace UserRegisteration.Models
{
    public class UserRegisterationViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string? UserName { get; set; }



        [Required]
        [Display(Name = "Email Id")]
        [EmailAddress]
        public string? EmailId { get; set; }


        [Required]
        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^(\+\d{1,2}\s?)?1?\-?\.?\s?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$", ErrorMessage = "Please enter valid mobile Number")]
        public string? MobileNumber { get; set; }


        public string? Address { get; set; }

        [Required]
        [Range(18, 60)]
        public int? Age { get; set; }

        public string? Gender { get; set; }


        [Required]
        public string? Password { get; set; }


        public string? ConfirmPassword { get; set; }
    }
}
