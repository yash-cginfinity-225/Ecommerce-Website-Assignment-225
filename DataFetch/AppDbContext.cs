using Microsoft.EntityFrameworkCore;
using DataFetch.Models;

namespace DataFetch.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<ItemData> ItemData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreDemoDB;Trusted_Connection=True;");
        }
    }
}