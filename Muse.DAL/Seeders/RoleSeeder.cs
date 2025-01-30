using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class RoleSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = 1,
            IsDeleted = false
        });
        
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = 2,
            IsDeleted = false
        });
        
        modelBuilder.Entity<Role>().HasData(new Role
        {
            Id = 3,
            IsDeleted = false
        });
    }
}