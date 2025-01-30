using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class ServiceSpecificationSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        #region Makeup

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 1, // Everyday makeup (without eye makeup)
            ServiceId = 1,
            Duration = TimeSpan.FromMinutes(40),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 2, // Evening makeup (without lashes)
            ServiceId = 1,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 3, // Evening makeup (with lashes)
            ServiceId = 1,
            Duration = TimeSpan.FromMinutes(90), // 1.5 hour
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 4, // Bridal makeup (without false lashes)
            ServiceId = 1,
            Duration = TimeSpan.FromMinutes(90), // 1.5 hour
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 5, // Bridal makeup (with false lashes)
            ServiceId = 1,
            Duration = TimeSpan.FromMinutes(90), // 1.5 hour
            IsDeleted = false
        });

        #endregion

        #region Manicure

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 6, // Manicure (without nail polish)
            ServiceId = 2,
            Duration = TimeSpan.FromMinutes(30),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 7, // Manicure (with nail polish)
            ServiceId = 2,
            Duration = TimeSpan.FromMinutes(60), // 1 hour
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 8, // Gel manicure
            ServiceId = 2,
            Duration = TimeSpan.FromMinutes(90), // 1.5 hours
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 9, // Japanese manicure
            ServiceId = 2,
            Duration = TimeSpan.FromMinutes(60), // 1 hour
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 10, // Simple design
            ServiceId = 2,
            Duration = TimeSpan.FromMinutes(120), // 2 hours
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 11, // Art design
            ServiceId = 2,
            Duration = TimeSpan.FromMinutes(150), // 2.5 hours
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 12, // Extensions (with gel coating)
            ServiceId = 2,
            Duration = TimeSpan.FromMinutes(150), // 2.5 hours
            IsDeleted = false
        });

        #endregion

        #region Pedicure

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 13, // Pedicure toes (without nail polish)
            ServiceId = 3,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 14, // Pedicure toes + feet (without nail polish)
            ServiceId = 3,
            Duration = TimeSpan.FromMinutes(90), // 1 hour 30 mins
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 15, // Pedicure toes (with nail polish)
            ServiceId = 3,
            Duration = TimeSpan.FromMinutes(90), // 1 hour 30 mins
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 16, // Pedicure toes + feet (with nail polish)
            ServiceId = 3,
            Duration = TimeSpan.FromHours(2),
            IsDeleted = false
        });

        #endregion

        #region Brows/Lashes

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 17, // Brows correction
            ServiceId = 4,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 18, // Brows colouring
            ServiceId = 4,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 19, // Brows bleaching
            ServiceId = 4,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 20, // Brows lamination
            ServiceId = 4,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 21, // Lashes lamination
            ServiceId = 4,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecification>().HasData(new ServiceSpecification
        {
            Id = 22, // Brows + lashes lamination
            ServiceId = 4,
            Duration = TimeSpan.FromHours(1),
            IsDeleted = false
        });

        #endregion
    }
}