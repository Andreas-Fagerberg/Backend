using Backend.Models;

namespace Backend.Services;

public interface IUserService
{
    Task<User?> LoginUser();
    Task<RegisterResponse?> Registeruser(RegisterRequest request);
    Task<bool> VerifyUser();
    Task<int> DeleteUser(DeleteUserRequest request);
}
