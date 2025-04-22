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
        var response = await userService.Registeruser(request);
        return Ok(response);
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

    [HttpDelete("delete")]
    public async Task<IActionResult> DeleteUser(DeleteUserRequest request)
    {
        await userService.DeleteUser(request);
        return Ok();
    }
}
