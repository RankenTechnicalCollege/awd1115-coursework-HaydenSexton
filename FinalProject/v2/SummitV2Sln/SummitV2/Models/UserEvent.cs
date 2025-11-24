namespace SummitV2.Models
{
    public class UserEvent
    {
        public string UserId { get; set; }
        public int EventId { get; set; }

        public string Role { get; set; }

        // NAV
        public ApplicationUser ApplicationUser { get; set; }
        public Event Event { get; set; }
    }
}
