using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SummitWeb.Areas.Clan.Models
{
    public class Clan
    {
        public int? ClanId { get; set; }

        [Required(ErrorMessage = "Clan name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Clan description is required.")]
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }


/*        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }          */






        // slug
        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}
