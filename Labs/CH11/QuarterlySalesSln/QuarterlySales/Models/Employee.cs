using Microsoft.EntityFrameworkCore;
using QuarterlySales.Models.ValidationAttributes; // imports custom validation attributes (pastdate/companyfounded)
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuarterlySales.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; } = "";

        [Required, StringLength(50)]
        public string LastName { get; set; } = "";

        [Required, DataType(DataType.Date)]
        [PastDate(ErrorMessage = "Date of birth must be in the past.")]
        public DateTime DOB { get; set; }

        [Required, DataType(DataType.Date)]
        [PastDate(ErrorMessage = "Hire date must be in the past.")]
        [CompanyFounded(1995, 1, 1, ErrorMessage = "Hire date must be on or after 1/1/1995.")]
        public DateTime DateOfHire { get; set; }

        [Required(ErrorMessage = "Manager is required (choose someone other than the employee).")]
        public int? ManagerId { get; set; }
        public Employee? Manager { get; set; }

        public ICollection<Sale>? Sales { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}