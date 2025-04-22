using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> DeleteUser(DeleteUserRequest request)
    {
        var returnedUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == request.UserId);
        if (returnedUser == null)
            return 0;

        _context.Users.Remove(returnedUser);
        return await _context.SaveChangesAsync();
    }

    public async Task<User?> GetUser(User user)
    {
        var returnedUser = await _context.Users.FirstOrDefaultAsync(u =>
            u.Username == user.Username
        );

        if (returnedUser == null)
            return null;

        if (returnedUser.Password == user.Password)
            return returnedUser;

        return null;
    }

    public async Task<User?> SaveUser(User user)
    {
        var returnedUser = await _context.Users.AddAsync(user);
        Console.WriteLine(returnedUser.Entity.Id);
        await _context.SaveChangesAsync();
        return returnedUser.Entity;
    }

    public Task<User?> UpdateUser()
    {
        throw new NotImplementedException();
    }
}
