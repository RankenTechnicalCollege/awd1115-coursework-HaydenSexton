using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace QuarterlySales.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        [Required, Range(1, 4)]
        public int Quarter { get; set; }

        [Required, Range(2001, 2100, ErrorMessage = "Year must be after 2000.")]
        public int Year { get; set; }

        [Required, Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Please select an employee.")]
        public int? EmployeeId { get; set; }

        [ValidateNever]
        public Employee? Employee { get; set; }
    }
}