using Backend.Repositories;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

namespace Backend;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(
                "Host=localhost;Database=lektion7;Username=postgres;Password=password"
            )
        );

        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddControllers();

        var app = builder.Build();

        app.MapControllers();

        app.Run();
    }
}
