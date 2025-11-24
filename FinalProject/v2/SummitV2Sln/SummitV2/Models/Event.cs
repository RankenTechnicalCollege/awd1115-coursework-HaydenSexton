using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace SummitV2.Models
{
    public class Event
    {
        public int EventId { get; set; }

        public int ClanId { get; set; }
        public string OrganizerId { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime EventDate { get; set; }

        // NAV
        [ValidateNever]
        public Clan Clan { get; set; }
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
        [ValidateNever]
        public ICollection<UserEvent>? UserEvents { get; set; }
    }
}
