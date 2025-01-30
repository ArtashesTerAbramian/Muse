using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class ErrorSeeder
{
   public static void SeedData(ModelBuilder modelBuilder)
   {
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 1, // DuplicateItem
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 2, // CannotRemoveDataWithReference
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 3, // TheUsernameOrPasswordIsIncorrect
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 4, // GivenEmailAlreadyUsed
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 5, // EmailNotVerified
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 6, // CurrentPasswordIsIncorrect
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 7, // EmailVerificationLinkExpired
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });

        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 8, // PasswordVerificationLinkExpired
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 9, // TheOldPasswordCannotBeUsed
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 10, // Oops
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
        
        modelBuilder.Entity<Error>().HasData(new Error
        {
            Id = 11, // AccessDenied
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false
        });
   }
}