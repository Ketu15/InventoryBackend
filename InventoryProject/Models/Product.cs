namespace InventoryProject.Models
{
  public class Product
  {
    public int Id { get; set; }
    public int ProductNumber { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
    public int Discount { get; set; }
    // Other properties as needed
  }
}
