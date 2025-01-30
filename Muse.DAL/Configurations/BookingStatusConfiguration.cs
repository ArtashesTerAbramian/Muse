using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class BookingStatusConfiguration : BaseConfiguration<BookingStatus>
{
    public override void Configure(EntityTypeBuilder<BookingStatus> builder)
    {
        base.Configure(builder);

        builder.ToTable("booking_status");
    }
}