using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace OneToManyEF.Models.DomainModels
{
    public class Class
    {
        public int ClassId { get; set; }
        [StringLength(200, ErrorMessage = "Title may not exceed 200 chars.")]
        [Required(ErrorMessage = "Please enter a class title.")]
        public string Title { get; set; } = string.Empty;

        [Range(100, 500, ErrorMessage = "Class number must be between 100 and 500.")]
        [Required(ErrorMessage = "Please enter a class number.")]

        public int? Number {  get; set; }

        [Display(Name = "Time")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Please enter numbers only for class time.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Clas time must be 4 chars long.")]
        public string MilitaryTime { get; set; } = string.Empty;

        // properties

        public int TeacherId { get; set; }
        [ValidateNever]
        public Teacher Teacher { get; set; } = null!;

        public int DayId { get; set; }
        [ValidateNever]
        public Day Day { get; set; } = null!;
    }
}
