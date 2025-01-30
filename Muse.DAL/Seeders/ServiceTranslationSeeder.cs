using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class ServiceTranslationSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 1,
            ServiceId = 1, // Makeup
            LanguageId = 1,
            Name = "Makeup",
            Description = "Makeup"
        });

        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 2,
            ServiceId = 1, // Макияж
            LanguageId = 2,
            Name = "Макияж",
            Description = "Макияж"
        });


        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 3,
            ServiceId = 2, // Manicure
            LanguageId = 1,
            Name = "Manicure",
            Description = "Manicure"
        });

        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 4,
            ServiceId = 2, // Маникюр
            LanguageId = 2,
            Name = "Маникюр",
            Description = "Маникюр"
        });


        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 5,
            ServiceId = 3, // Pedicure
            LanguageId = 1,
            Name = "Pedicure",
            Description = "Pedicure"
        });


        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 6,
            ServiceId = 3, // Педикюр
            LanguageId = 2,
            Name = "Педикюр",
            Description = "Педикюр"
        });


        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 7,
            ServiceId = 4, // Brows/Lashes
            LanguageId = 1,
            Name = "Brows/Lashes",
            Description = "Brows/Lashes"
        });


        modelBuilder.Entity<ServiceTranslation>().HasData(new ServiceTranslation()
        {
            Id = 8,
            ServiceId = 4, // Брови/ресницы
            LanguageId = 2,
            Name = "Брови/ресницы",
            Description = "Брови/ресницы"
        });
    }
}