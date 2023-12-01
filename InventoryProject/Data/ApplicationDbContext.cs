using InventoryProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryProject.Data
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<User> Users { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Other DbSet properties and configuration...
  }
}
