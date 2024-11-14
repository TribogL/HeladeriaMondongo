

using HeladeriaMondongo.Models;
using Microsoft.EntityFrameworkCore;

namespace HeladeriaMondongo.Data;
public class ApplicationDbContext : DbContext
{
    public DbSet<User> users { get; set; }
    public DbSet<Icecream> icecreams { get; set; }

     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
