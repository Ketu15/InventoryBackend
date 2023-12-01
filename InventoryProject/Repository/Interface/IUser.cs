using InventoryProject.Models;

namespace InventoryProject.Repository.Interface
{
  public interface IUser
  {
    Task<User> CreateUserAsync(User user);
    Task<User> AuthenticateUserAsync(string username, string password);
  }
}
//public interface IUser
//{
  
//  Task<User> GetUserByIdAsync(int userId);
//  Task UpdateUserAsync(User user);
//  Task DeleteUserAsync(int userId);
//}
