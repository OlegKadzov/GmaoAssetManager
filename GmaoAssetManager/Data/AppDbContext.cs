using GmaoAssetManager.Models;
using Microsoft.EntityFrameworkCore;

namespace GmaoAssetManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Equipment> Equipments => Set<Equipment>();
    }
}