namespace SummitV2.Models.ViewModels
{
    public class ClanDashboardVM
    {
        public Clan Clan { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<UserClan> Members { get; set; }
    }
}
