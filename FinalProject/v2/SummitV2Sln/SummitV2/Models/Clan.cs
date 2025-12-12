using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using SummitV2.Models;
using System.ComponentModel.DataAnnotations;

public class Clan
{
    [ValidateNever]
    public string ClanId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }

    // FK
    [ValidateNever]
    public string CreatedByUserId { get; set; }

    // NAV
    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; }
    [ValidateNever]
    public ICollection<UserClan>? UserClans { get; set; }
    [ValidateNever]
    public ICollection<Event>? Events { get; set; }


    // slug
    public string Slug => Name?.Replace(' ', '-').ToLower();
}
