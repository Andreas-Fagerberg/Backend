using Backend.Models;

namespace Backend.Repositories;

public interface IUserRepository
{
    Task<User?> GetUser(User user);
    Task<User?> SaveUser(User user);
    Task<User?> UpdateUser();
    Task<int> DeleteUser(DeleteUserRequest request);
}
