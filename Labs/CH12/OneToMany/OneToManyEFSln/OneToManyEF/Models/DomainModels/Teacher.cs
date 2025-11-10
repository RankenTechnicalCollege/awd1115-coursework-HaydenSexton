using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace OneToManyEF.Models.DomainModels
{
    public class Teacher
    {
        public Teacher() => Classes = new HashSet<Class>();
        public int TeacherId { get; set; }
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "First name may not exceed 100 chars.")]
        [Required(ErrorMessage = "Please enter a first name")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last name")]
        [StringLength(100, ErrorMessage = "First name may not exceed 100 chars.")]
        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";
        public ICollection<Class> Classes { get; set; }
    }
}
