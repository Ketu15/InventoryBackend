namespace InventoryProject.Models
{
  public class User
  {
    public int Id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public int mobile_no { get; set; }
    public DateTime dob { get; set; }
  }
}
