public class Report
{
  public int Id { get; set; }
  public int ProductId { get; set; } // Foreign key to link with Product
  public int SoldQuantity { get; set; }
  public decimal TotalSalesAmount { get; set; }
  // Other properties as needed
}
