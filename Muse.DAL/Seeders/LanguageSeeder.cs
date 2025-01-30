using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class LanguageSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Language>().HasData(new Language
        {
            Id = 1,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "English",
            Code = "en",
            PhotoName = null,
            Link = null,
            IsDefault = true,
            IsActive = true
        });

        modelBuilder.Entity<Language>().HasData(new Language
        {
            Id = 2,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "Русский",
            Code = "ru",
            PhotoName = null,
            Link = null,
            IsDefault = false,
            IsActive = true
        });

        modelBuilder.Entity<Language>().HasData(new Language
        {
            Id = 3,
            CreatedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
            Name = "Հայերեն",
            Code = "am",
            PhotoName = null,
            Link = null,
            IsDefault = false,
            IsActive = true
        });
    }
}