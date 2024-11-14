

using HeladeriaMondongo.Models;
using HeladeriaMondongo.Seeders;
using Microsoft.EntityFrameworkCore;

namespace HeladeriaMondongo.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        UserSeeder.Seed(modelBuilder);
    }
}
