using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace weddingPlanner.Models
{
    public class Wedding
    {
        [Required]
        public int WeddingId {get; set;}

        [Required]
        [MinLength(2)]
        public string WedderOne {get; set;}

        [Required]
        [MinLength(2)]
        public string WedderTwo {get; set;}

        [Required]
        [ValidDate]
        public DateTime WeddingDate {get; set;}

        [Required]
        public string Location {get; set;}

        public User Host {get; set;}


        public List<UserWedding> WeddingsUsers {get; set;}


        public DateTime CreatedAt {get; set;} = DateTime.Now;


        public DateTime UpdatedAt {get; set;} = DateTime.Now;


        public class ValidDateAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if ((DateTime)value < DateTime.Today)
                    return new ValidationResult("Please Enter a Future Date.");
                return ValidationResult.Success;
            }
        }
    }
}