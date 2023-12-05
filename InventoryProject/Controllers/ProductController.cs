using InventoryProject.Models;
using InventoryProject.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryProject.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductController : ControllerBase
  {
    private readonly IProduct _productRepository;

    public ProductController(IProduct productRepository)
    {
      _productRepository = productRepository;
    }


    [HttpPost("add")]
    public async Task<IActionResult> AddProduct(Product product)
    {
      var newProduct = await _productRepository.AddProductAsync(product);
      return Ok(newProduct);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
      var product = await _productRepository.GetProductByIdAsync(id);
      if (product == null)
        return NotFound();

      return Ok(product);
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAllProducts()
    {
      var products = await _productRepository.GetAllProductsAsync();
      return Ok(products);
    }

    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateProduct(int id, Product product)
    {
      if (id != product.Id)
        return BadRequest();

      await _productRepository.UpdateProductAsync(product);
      return Ok(product);
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
      var product = await _productRepository.GetProductByIdAsync(id);
      if (product == null)
        return NotFound();

      await _productRepository.DeleteProductAsync(id);
      return Ok(product);
    }
  }
}
