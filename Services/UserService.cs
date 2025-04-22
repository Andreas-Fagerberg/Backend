using Backend.Models;
using Backend.Repositories;

namespace Backend.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public Task<int> DeleteUser()
    {
        throw new NotImplementedException();
    }

    public Task<User?> LoginUser()
    {
        throw new NotImplementedException();
    }

    public async Task<User?> Registeruser(RegisterRequest request)
    {
        var user = new User
        {
            Username = request.Username,
            Password = request.Password,
            Email = request.Email,
        };
        Console.WriteLine(user.Password);
        return await userRepository.SaveUser(user);
    }

    public Task<bool> VerifyUser()
    {
        throw new NotImplementedException();
    }
}
