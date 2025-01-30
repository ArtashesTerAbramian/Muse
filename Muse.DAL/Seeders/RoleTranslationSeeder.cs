using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class RoleTranslationSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        #region Admin

        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 1,
            RoleId = 1,
            LanguageId = 1,
            Name = "Admin",
            IsDeleted = false
        });
        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 2,
            RoleId = 1,
            LanguageId = 2,
            Name = "Админ",
            IsDeleted = false
        });
        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 3,
            RoleId = 1,
            LanguageId = 3,
            Name = "Ադմին",
            IsDeleted = false
        });

        #endregion

        #region Client

        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 4,
            RoleId = 2,
            LanguageId = 1,
            Name = "Client",
            IsDeleted = false
        });
        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 5,
            RoleId = 2,
            LanguageId = 2,
            Name = "Клиент",
            IsDeleted = false
        });
        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 6,
            RoleId = 2,
            LanguageId = 3,
            Name = "Հաճախորդ",
            IsDeleted = false
        });

        #endregion

        #region Salon

        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 7,
            RoleId = 3,
            LanguageId = 1,
            Name = "Salon",
            IsDeleted = false
        });
        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 8,
            RoleId = 3,
            LanguageId = 2,
            Name = "Салон",
            IsDeleted = false
        });
        modelBuilder.Entity<RoleTranslation>().HasData(new RoleTranslation
        {
            Id = 9,
            RoleId = 3,
            LanguageId = 3,
            Name = "Սալոն",
            IsDeleted = false
        });

        #endregion
    }
}