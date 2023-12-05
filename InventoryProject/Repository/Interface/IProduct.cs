using InventoryProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryProject.Repository.Interface
{
  public interface IProduct
  {
    Task<Product> AddProductAsync(Product product);
    Task<Product> GetProductByIdAsync(int productId);
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int productId);
  }
}
