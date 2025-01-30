using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class ServiceSpecificationTranslationConfiguration : BaseConfiguration<ServiceSpecificationTranslation>
{
    public override void Configure(EntityTypeBuilder<ServiceSpecificationTranslation> builder)
    {
        base.Configure(builder);

        builder.ToTable("service_specification_translation");
    }
}