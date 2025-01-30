using Microsoft.EntityFrameworkCore;

namespace Muse.DAL.Seeders;

internal static class MainSeeder
{
    //public static DateTime DefaulDbInittDate => new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    //DON'T use fields, properties or variables, we need to use raw values beside every time on creating migration it will
    //update statement for values.

    public static void SeedData(this ModelBuilder modelBuilder)
    {
        LanguageSeeder.SeedData(modelBuilder);
        ErrorSeeder.SeedData(modelBuilder);
        ErrorTranslationSeeder.SeedData(modelBuilder);
        RoleSeeder.SeedData(modelBuilder);
        RoleTranslationSeeder.SeedData(modelBuilder);
        // PermissionSeeder.SeedData(modelBuilder);
        // PermissionTranslationSeeder.SeedData(modelBuilder);
        // RolePermissionSeeder.SeedData(modelBuilder);
        UserSeeder.SeedData(modelBuilder);
        BookingStatusSeeder.SeedData(modelBuilder);
        BookingStatusTranslationSeeder.SeedData(modelBuilder);
        ServiceSeeder.SeedData(modelBuilder);
        ServiceTranslationSeeder.SeedData(modelBuilder);
        ServiceSpecificationSeeder.SeedData(modelBuilder);
        ServiceSpecificationTranslationSeeder.SeedData(modelBuilder);
    }
}