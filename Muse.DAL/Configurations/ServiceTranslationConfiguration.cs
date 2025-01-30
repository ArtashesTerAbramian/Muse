using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class ServiceTranslationConfiguration : BaseConfiguration<ServiceTranslation>
{
    public override void Configure(EntityTypeBuilder<ServiceTranslation> builder)
    {
        base.Configure(builder);

        builder.ToTable("service_translation");
    }
}