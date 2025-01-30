using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class ServiceSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 1, // Makeup
            IsDeleted = false
        });

        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 2, // Manicure
            IsDeleted = false
        });
        
        
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 3, // Pedicure
            IsDeleted = false
        });
        
        modelBuilder.Entity<Service>().HasData(new Service
        {
            Id = 4, // Brows/Lashes
            IsDeleted = false
        });
    }
}