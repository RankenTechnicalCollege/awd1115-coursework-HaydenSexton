using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using HOT4.Data;

namespace HOT4.Models
{
    public class ValidAppointmentTimeAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // (prevent migration build fail)
            if (AppContext.GetData("EFCoreDesignTime") is bool isDesignTime && isDesignTime)
                return ValidationResult.Success;

            if (value == null)
                return new ValidationResult("Please select a valid start date and time.");

            if (value is not DateTime startDateTime)
                return new ValidationResult("Invalid date/time format.");

            if (startDateTime.Minute != 0 || startDateTime.Second != 0)
                return new ValidationResult("Appointments must start exactly on the hour (e.g., 3/15/2025 08:00 AM).");

            if (startDateTime <= DateTime.Now)
                return new ValidationResult("The appointment time must be in the future.");

            var dbContext = validationContext.GetService(typeof(ApptContext)) as ApptContext;
            if (dbContext != null)
            {
                var instance = validationContext.ObjectInstance as Appointment;
                int currentId = instance?.AppointmentId ?? 0;

                bool conflict = dbContext.Appointments
                    .Any(a => a.StartDateTime == startDateTime && a.AppointmentId != currentId);

                if (conflict)
                    return new ValidationResult(
                        $"An appointment already exists at {startDateTime:MM/dd/yyyy hh:mm tt}. Please choose a different time.");
            }

            return ValidationResult.Success;
        }
    }
}
