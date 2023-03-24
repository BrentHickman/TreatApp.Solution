using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TreatApp.Models
{
  public class TreatAppContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavors { get; set; }
    public TreatAppContext(DbContextOptions options) : base(options) { }
  }
}