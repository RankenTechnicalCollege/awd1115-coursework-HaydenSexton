namespace SummitV2.Models.ViewModels
{
    public class PaginatedUserViewModel
    {
        public PaginatedList<UserViewModel> Users { get; set; } = null!;
        public string? SearchString { get; set; }
    }
}