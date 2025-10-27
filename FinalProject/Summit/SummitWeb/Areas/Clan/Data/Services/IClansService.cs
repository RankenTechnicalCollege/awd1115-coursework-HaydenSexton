namespace SummitWeb.Areas.Clan.Models;
using Microsoft.EntityFrameworkCore;

public interface IClansService
{
    IQueryable<Clan> GetAll();
    Task Add(Clan clan);
    Task<Clan> GetById(int? id);
    Task SaveChanges();
}
