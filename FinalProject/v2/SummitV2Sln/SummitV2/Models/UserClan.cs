namespace SummitV2.Models
{
    public class UserClan
    {
        // PK
        public string UserId { get; set; }
        public int ClanId { get; set; }

        public string Role { get; set; }
        public DateTime JoinDate { get; set; }

        // NAV
        public ApplicationUser ApplicationUser { get; set; }
        public Clan Clan { get; set; }
    }
}
