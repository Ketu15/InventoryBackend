using InventoryProject.Models;
using InventoryProject.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace InventoryProject.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UserController : ControllerBase
  {
    private readonly IUser _userRepository;

    public UserController(IUser userRepository)
    {
      _userRepository = userRepository;
    }

    [HttpPost("signup")]
    public async Task<IActionResult> SignUp(User user)
    {
      var newUser = await _userRepository.CreateUserAsync(user);

      return Ok(newUser);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
      var user = await _userRepository.AuthenticateUserAsync(loginModel.username, loginModel.password);
      if (user == null)
        return Unauthorized();

      return Ok(user);
    }


  }
}
