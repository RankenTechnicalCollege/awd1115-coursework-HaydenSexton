using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter a email.")]
        public string? Email { get; set; }


        // slug 
        public string Slug => Firstname?.ToLower() + '-' + Lastname?.ToLower().ToString();


        // relation
        [Required(ErrorMessage = "Please enter a genre.")]
        public int CategoryId { get; set; } = 0;

        [ValidateNever]

        public Category Category { get; set; }
    }
}
