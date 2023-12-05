using InventoryProject.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryProject.Repository.Interface
{
  public interface ISale
  {
    Task<Sale> AddSaleAsync(Sale sale);
    Task<IEnumerable<Sale>> GetSalesByDateRangeAsync(DateTime startDate, DateTime endDate);
    // Additional methods as needed
  }
}
