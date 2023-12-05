using InventoryProject.Data;
using InventoryProject.Models;
using InventoryProject.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryProject.Repository.Implementation
{
  public class SaleRepository : ISale
  {
    private readonly ApplicationDbContext _context;

    public SaleRepository(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<Sale> AddSaleAsync(Sale sale)
    {
      _context.Sales.Add(sale);
      await _context.SaveChangesAsync();
      return sale;
    }

    public async Task<IEnumerable<Sale>> GetSalesByDateRangeAsync(DateTime startDate, DateTime endDate)
    {
      return await _context.Sales
          .Where(s => s.DateTime >= startDate && s.DateTime <= endDate)
          .ToListAsync();
    }

    // Additional methods as needed for sales operations
  }
}
