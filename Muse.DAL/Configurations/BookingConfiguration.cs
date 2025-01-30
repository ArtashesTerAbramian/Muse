using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class BookingConfiguration : BaseConfiguration<Booking>
{
    public override void Configure(EntityTypeBuilder<Booking> builder)
    {
        base.Configure(builder);

        builder.ToTable("booking");
    }
}