namespace SummitV2.Models
{
    public class UserEvent
    {
        public string UserId { get; set; }
        public string EventId { get; set; }

        public string Role { get; set; }

        // NAV
        public ApplicationUser ApplicationUser { get; set; }
        public Event Event { get; set; }
    }
}
