using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Must be a valid email.")]
        [EmailAddress]
        [Display(Name = "Email: ")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Password must have at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string LoginPassword { get; set; }
    }
}