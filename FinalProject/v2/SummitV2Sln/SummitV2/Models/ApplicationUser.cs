using Microsoft.AspNetCore.Identity;

namespace SummitV2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Clan>? Clans { get; set; }
        public ICollection<UserClan>? UserClans { get; set; }
        public ICollection<Event>? Events { get; set; }
        public ICollection<UserEvent>? UserEvents { get; set; }
    }
}
