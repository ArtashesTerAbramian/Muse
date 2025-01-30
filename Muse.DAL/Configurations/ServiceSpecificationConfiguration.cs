using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class ServiceSpecificationConfiguration : BaseConfiguration<ServiceSpecification>
{
    public override void Configure(EntityTypeBuilder<ServiceSpecification> builder)
    {
        base.Configure(builder);

        builder.ToTable("service_specification");
    }
}