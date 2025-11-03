using Microsoft.EntityFrameworkCore;

class AppDbContext : DbContext
{
    public DbSet<ItemData> ItemData { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCoreDemoDB;Trusted_Connection=True;");
        }
    }
}