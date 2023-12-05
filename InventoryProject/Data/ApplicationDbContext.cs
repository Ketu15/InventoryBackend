using InventoryProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryProject.Data
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Report> Reports { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Other DbSet properties and configuration...
  }
}
