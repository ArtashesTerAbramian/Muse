using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class StaticTextConfiguration : BaseConfiguration<StaticText>
{
    public override void Configure(EntityTypeBuilder<StaticText> builder)
    {
        base.Configure(builder);
    }
}