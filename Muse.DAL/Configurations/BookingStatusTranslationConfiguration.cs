using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class BookingStatusTranslationConfiguration : BaseConfiguration<BookingStatusTranslation>
{
    public override void Configure(EntityTypeBuilder<BookingStatusTranslation> builder)
    {
        base.Configure(builder);

        builder.ToTable("booking_status_translation");
    }
}