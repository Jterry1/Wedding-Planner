using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId { get; set; }

        [Required]
        public string WedderOne { get; set; }

        [Required]
        public string WedderTwo { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Address { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int PlannerId { get; set; }
        public Planner Creater { get; set; }
        public List<Guest> MyGuests { get; set; }

        public class FutureDateAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value == null)
                {
                    return new ValidationResult("Date is required.");
                }
                DateTime compare;
                if (value is DateTime)
                {
                    compare = (DateTime)value;
                    if (compare < DateTime.Now)
                    {
                        return new ValidationResult("Date must be in the future.");
                    }
                    else
                    {
                        return ValidationResult.Success;
                    }
                }
                else
                {
                    return new ValidationResult("Not a valid Date.");
                }
            }
        }
    }
}