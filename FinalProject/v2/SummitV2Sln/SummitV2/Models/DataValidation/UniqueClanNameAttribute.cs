using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using SummitV2.Data;

namespace SummitV2.Models.DataValidation
{
    public class UniqueClanNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var db = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext));
            var clanName = value as string;

            if (string.IsNullOrWhiteSpace(clanName))
                return ValidationResult.Success;

            var clan = (Clan)validationContext.ObjectInstance;

            var exists = db.Clans
                           .AsNoTracking()
                           .Any(c => c.Name == clanName && c.ClanId != clan.ClanId);

            if (exists)
            {
                return new ValidationResult($"A clan with the name '{clanName}' already exists.");
            }

            return ValidationResult.Success;
        }
    }
}