namespace InventoryProject.Models
{
  public class Sale
  {
    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Quantity { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime DateTime { get; set; }
    // Additional properties as needed
  }
}
