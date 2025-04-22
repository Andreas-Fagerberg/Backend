namespace Backend.Models;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public bool IsVerified { get; set; } = false;
    public DateTime Created { get; set; } = DateTime.UtcNow;

    public User() { }
}
