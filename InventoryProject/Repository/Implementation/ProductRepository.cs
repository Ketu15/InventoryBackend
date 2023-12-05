using InventoryProject.Data;
using InventoryProject.Models;
using InventoryProject.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryProject.Repository.Implementation
{
  public class ProductRepository : IProduct
  {
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<Product> AddProductAsync(Product product)
    {
      _context.Products.Add(product);
      await _context.SaveChangesAsync();
      return product;
    }

    public async Task DeleteProductAsync(int productId)
    {
      var product = await _context.Products.FindAsync(productId);
      if (product != null)
      {
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
      }
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
      return await _context.Products.ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(int productId)
    {
      return await _context.Products.FindAsync(productId);
    }

    public async Task UpdateProductAsync(Product product)
    {
      _context.Products.Update(product);
      await _context.SaveChangesAsync();
    }
  }
}
