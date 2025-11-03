using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HOT4.Models
{
    public class Appointment
    {
    public int AppointmentId { get; set; }

    [Required(ErrorMessage = "Please select a start date and time.")]
    [DataType(DataType.DateTime)]
    [Display(Name = "Start Date/Time")]
    [ValidAppointmentTime] // custom
    public DateTime StartDateTime { get; set; }

    [Required(ErrorMessage = "Please select a customer.")]
    public int? CustomerId { get; set; }

    [ValidateNever]
    public Customer? Customer { get; set; }

    [Display(Name = "End Date/Time")]
    public DateTime EndDateTime => StartDateTime.AddHours(1);
    }
}
