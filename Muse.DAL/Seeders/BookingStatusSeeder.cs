using Microsoft.EntityFrameworkCore;
using Muse.DAL.Models;

namespace Muse.DAL.Seeders;

public class BookingStatusSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingStatus>().HasData(new BookingStatus
        {
            Id = 1, // Confirmed
        });

        modelBuilder.Entity<BookingStatus>().HasData(new BookingStatus
        {
            Id = 2, // Completed
        });

        modelBuilder.Entity<BookingStatus>().HasData(new BookingStatus
        {
            Id = 3, // Cancelled
        });
    }
}