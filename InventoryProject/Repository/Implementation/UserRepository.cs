using InventoryProject.Data;
using InventoryProject.Models;
using InventoryProject.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryProject.Repository.Implementation
{
  public class UserRepository : IUser
  {
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<User> CreateUserAsync(User user)
    {
      _context.Users.Add(user);
      await _context.SaveChangesAsync();
      return user;
    }
    //
    public async Task<User> AuthenticateUserAsync(string username, string password)
    {
      var user = await _context.Users.FirstOrDefaultAsync(u => u.username == username && u.password == password);
      return user;
    }
  }
}
