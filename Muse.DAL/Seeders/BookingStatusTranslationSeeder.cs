using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class BookingStatusTranslationSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        #region Confirmed

        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 1,
            LanguageId = 1,
            Name = "Confirmed",
            StatusId = 1,
        });
        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 2,
            LanguageId = 2,
            Name = "Подтверждено",
            StatusId = 1,
        });
        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 3,
            LanguageId = 3,
            Name = "Հաստատված",
            StatusId = 1,
        });

        #endregion

        #region Completed

        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 4,
            LanguageId = 1,
            Name = "Completed",
            StatusId = 2,
        });

        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 5,
            LanguageId = 2,
            Name = "Завершено",
            StatusId = 2,
        });

        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 6,
            LanguageId = 3,
            Name = "Կատարված",
            StatusId = 2,
        });

        #endregion

        #region Cancelled

        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 7,
            LanguageId = 1,
            Name = "Cancelled",
            StatusId = 3,
        });

        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 8,
            LanguageId = 2,
            Name = "Отменено",
            StatusId = 3,
        });

        modelBuilder.Entity<BookingStatusTranslation>().HasData(new BookingStatusTranslation
        {
            Id = 9,
            LanguageId = 3,
            Name = "Չեղարկված",
            StatusId = 3,
        });

        #endregion
    }
}