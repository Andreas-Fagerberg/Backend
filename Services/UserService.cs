using Backend.Models;
using Backend.Repositories;

namespace Backend.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<int> DeleteUser(DeleteUserRequest request)
    {
        return await userRepository.DeleteUser(request);
    }

    public Task<User?> LoginUser()
    {
        throw new NotImplementedException();
    }

    public async Task<RegisterResponse?> Registeruser(RegisterRequest request)
    {
        var user = new User
        {
            Username = request.Username,
            Password = request.Password,
            Email = request.Email,
        };

        var returnedUser = await userRepository.SaveUser(user);

        if (returnedUser == null)
            return null;

        return new RegisterResponse { VerificationCode = returnedUser.Id };
    }

    public Task<bool> VerifyUser()
    {
        throw new NotImplementedException();
    }
}
