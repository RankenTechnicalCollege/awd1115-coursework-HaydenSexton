using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCShop.Models;
using System.ComponentModel.DataAnnotations.Schema;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }


    public ICollection<Product>? Products {  get; set; }
    public ICollection<Category>? Categories { get; set; }
    public ICollection<Purchase>? Purchases { get; set; }
    public ICollection<PurchaseItem>? PurchaseItems { get; set; }

    [NotMapped]
    public IList<string> RoleNames { get; set; } = null!;
}