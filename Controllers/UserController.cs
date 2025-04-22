using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers;

[ApiController]
[Route("[Controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> CreateUser([FromBody] RegisterRequest request)
    {
        Console.WriteLine(request.Email);
        await userService.Registeruser(request);
        return Ok();
    }

    [HttpPost("login")]
    public IActionResult LoginUser()
    {
        return Ok();
    }

    [HttpPost("verify")]
    public IActionResult VerifyUser() 
    {
        return Ok();
    }
}
