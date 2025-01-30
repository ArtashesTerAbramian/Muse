using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class ErrorConfiguration : BaseConfiguration<Error>
{
    public override void Configure(EntityTypeBuilder<Error> builder)
    {
        base.Configure(builder);
    }
}