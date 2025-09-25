using System.ComponentModel.DataAnnotations;

namespace SummitWeb.Models
{
    public class Clan
    {
        public int? ClanId { get; set; }

        [Required(ErrorMessage = "Clan name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Clan description is required.")]
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }


        // slug
        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}
