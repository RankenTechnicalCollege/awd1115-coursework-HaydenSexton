using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SummitV2.Models
{
    public class ApplicationUser : IdentityUser
    {
        // external api id
        public string? BungieId { get; set; }

        // Collections
        public ICollection<Clan>? Clans { get; set; }
        public ICollection<UserClan>? UserClans { get; set; }
        public ICollection<Event>? Events { get; set; }
        public ICollection<UserEvent>? UserEvents { get; set; }


        // roles
        [NotMapped]
        public IList<string> RoleNames { get; set; } = null!;
    }
}
