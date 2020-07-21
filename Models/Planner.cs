using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace WeddingPlanner.Models
{
    public class Planner
    {
        [Key]
        public int PlannerId { get; set; }

        [Required(ErrorMessage = "First name must be at least 2 characters.")]
        [MinLength(2)]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "First name must be at least 2 characters.")]
        [MinLength(2)]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Must be a valid email.")]
        [EmailAddress]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password must have at least 8 characters.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Passwords must match.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password: ")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Wedding> Weddings { get; set; }
        public List<Guest> MyGuest { get; set; }

    }
}