using Muse.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Muse.DAL.Seeders;

public class UserSeeder
{
    private const string _superUserPasswordHash =
        "AQAAAAEAACcQAAAAED6+5BoYHtAaOo7S+WlTRk5WxUHXKwgearLUEo1nHhe5MXozVtqD/M0/KcdENNJzZQ==";

    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Phone = "",
            Name = "Admin",
            Email = "admin@gmail.com",
            PasswordHash = _superUserPasswordHash, //Crypto.HashPassword("********"),
            ResetPasswordToken = null,
            ResetPasswordRequestDate = null,
            RoleId = 1,
            DefaultLanguageId = 1,
        });
    }
}