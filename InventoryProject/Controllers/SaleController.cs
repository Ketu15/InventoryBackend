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
  public class SaleController : ControllerBase
  {
    private readonly ISale _saleRepository;

    public SaleController(ISale saleRepository)
    {
      _saleRepository = saleRepository;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddSale(Sale sale)
    {
      var newSale = await _saleRepository.AddSaleAsync(sale);
      return Ok(newSale);
    }

    [HttpGet("bydaterange")]
    public async Task<IActionResult> GetSalesByDateRange(DateTime startDate, DateTime endDate)
    {
      var sales = await _saleRepository.GetSalesByDateRangeAsync(startDate, endDate);
      return Ok(sales);
    }

    // Additional endpoints for sales operations as needed
  }
}
