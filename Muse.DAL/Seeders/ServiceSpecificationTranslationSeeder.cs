using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class ServiceSpecificationTranslationSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        #region ServiceSpecificationTranslation for Makeup

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 1,
            ServiceId = 1,
            LanguageId = 1,
            Name = "Everyday Makeup Duration",
            Description = "(without eye makeup) 40 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 2,
            ServiceId = 1,
            LanguageId = 2,
            Name = "Каждодневный макияж длительность",
            Description = "(без макияжа глаз) 40 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 3,
            ServiceId = 1,
            LanguageId = 1,
            Name = "Evening Makeup Duration",
            Description = "(without lashes) 1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 4,
            ServiceId = 1,
            LanguageId = 2,
            Name = "Вечерний макияж длительность",
            Description = "(без ресниц) 1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 5,
            ServiceId = 1,
            LanguageId = 1,
            Name = "Evening Makeup Duration",
            Description = "(with lashes) 1 hour 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 6,
            ServiceId = 1,
            LanguageId = 2,
            Name = "Вечерний макияж длительность",
            Description = "(с ресницами) 1 час 30 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 7,
            ServiceId = 1,
            LanguageId = 1,
            Name = "Bridal Makeup Duration",
            Description = "(without false lashes) 1 hour 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 8,
            ServiceId = 1,
            LanguageId = 2,
            Name = "Макияж невесты длительность",
            Description = "(без ресниц) 1 час 30 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 9,
            ServiceId = 1,
            LanguageId = 1,
            Name = "Bridal Makeup Duration",
            Description = "(with false lashes) 1 hour 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 10,
            ServiceId = 1,
            LanguageId = 2,
            Name = "Макияж невесты длительность",
            Description = "(с ресницами) 1 час 30 минут",
            IsDeleted = false
        });

        #endregion

        #region ServiceSpecificationTranslation for Manicure

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 11,
            ServiceId = 2,
            LanguageId = 1,
            Name = "Manicure Duration",
            Description = "(without nail polish) 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 12,
            ServiceId = 2,
            LanguageId = 2,
            Name = "Маникюр длительность",
            Description = "(без покрытия) 30 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 13,
            ServiceId = 2,
            LanguageId = 1,
            Name = "Manicure Duration",
            Description = "(with nail polish) 1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 14,
            ServiceId = 2,
            LanguageId = 2,
            Name = "Маникюр длительность",
            Description = "(с покрытием) 1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 15,
            ServiceId = 2,
            LanguageId = 1,
            Name = "Gel Manicure Duration",
            Description = "1 hour 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 16,
            ServiceId = 2,
            LanguageId = 2,
            Name = "Гель маникюр длительность",
            Description = "1 час 30 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 17,
            ServiceId = 2,
            LanguageId = 1,
            Name = "Japanese Manicure Duration",
            Description = "1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 18,
            ServiceId = 2,
            LanguageId = 2,
            Name = "Японский маникюр длительность",
            Description = "1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 19,
            ServiceId = 2,
            LanguageId = 1,
            Name = "Simple Design Duration",
            Description = "2 hours",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 20,
            ServiceId = 2,
            LanguageId = 2,
            Name = "Простой дизайн длительность",
            Description = "2 часа",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 21,
            ServiceId = 2,
            LanguageId = 1,
            Name = "Art Design Duration",
            Description = "2 hours 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 22,
            ServiceId = 2,
            LanguageId = 2,
            Name = "Арт дизайн длительность",
            Description = "2 часа 30 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 23,
            ServiceId = 2,
            LanguageId = 1,
            Name = "Extensions Duration",
            Description = "(with gel coating) 2 hours 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 24,
            ServiceId = 2,
            LanguageId = 2,
            Name = "Наращивание длительность",
            Description = "(с гель покрытием) 2 часа 30 минут",
            IsDeleted = false
        });

        #endregion

        #region ServiceSpecificationTranslation for Pedicure

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 25,
            ServiceId = 3,
            LanguageId = 1,
            Name = "Pedicure Toes Duration",
            Description = "(without nail polish) 1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 26,
            ServiceId = 3,
            LanguageId = 2,
            Name = "Педикюр пальцы длительность",
            Description = "(без покрытия) 1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 27,
            ServiceId = 3,
            LanguageId = 1,
            Name = "Pedicure Toes + Feet Duration",
            Description = "(without nail polish) 1 hour 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 28,
            ServiceId = 3,
            LanguageId = 2,
            Name = "Педикюр пальцы + ступни длительность",
            Description = "(без покрытия) 1 час 30 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 29,
            ServiceId = 3,
            LanguageId = 1,
            Name = "Pedicure Toes Duration",
            Description = "(with nail polish) 1 hour 30 minutes",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 30,
            ServiceId = 3,
            LanguageId = 2,
            Name = "Педикюр пальцы длительность",
            Description = "(с покрытием) 1 час 30 минут",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 31,
            ServiceId = 3,
            LanguageId = 1,
            Name = "Pedicure Toes + Feet Duration",
            Description = "(with nail polish) 2 hours",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 32,
            ServiceId = 3,
            LanguageId = 2,
            Name = "Педикюр пальцы + ступни длительность",
            Description = "(с покрытием) 2 часа",
            IsDeleted = false
        });

        #endregion

        #region ServiceSpecificationTranslation for Brows/Lashes

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 33,
            ServiceId = 4,
            LanguageId = 1,
            Name = "Brows Correction Duration",
            Description = "1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 34,
            ServiceId = 4,
            LanguageId = 2,
            Name = "Коррекция бровей длительность",
            Description = "1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 35,
            ServiceId = 4,
            LanguageId = 1,
            Name = "Brows Colouring Duration",
            Description = "1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 36,
            ServiceId = 4,
            LanguageId = 2,
            Name = "Окрашивание бровей длительность",
            Description = "1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 37,
            ServiceId = 4,
            LanguageId = 1,
            Name = "Brows Bleaching Duration",
            Description = "1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 38,
            ServiceId = 4,
            LanguageId = 2,
            Name = "Обесцвечивание бровей длительность",
            Description = "1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 39,
            ServiceId = 4,
            LanguageId = 1,
            Name = "Brows Lamination Duration",
            Description = "1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 40,
            ServiceId = 4,
            LanguageId = 2,
            Name = "Ламинация бровей длительность",
            Description = "1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 41,
            ServiceId = 4,
            LanguageId = 1,
            Name = "Lashes Lamination Duration",
            Description = "1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 42,
            ServiceId = 4,
            LanguageId = 2,
            Name = "Ламинация ресниц длительность",
            Description = "1 час",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 43,
            ServiceId = 4,
            LanguageId = 1,
            Name = "Brows + Lashes Lamination Duration",
            Description = "1 hour",
            IsDeleted = false
        });

        modelBuilder.Entity<ServiceSpecificationTranslation>().HasData(new ServiceSpecificationTranslation
        {
            Id = 44,
            ServiceId = 4,
            LanguageId = 2,
            Name = "Ламинация бровей + ресниц длительность",
            Description = "1 час",
            IsDeleted = false
        });

        #endregion
    }
}