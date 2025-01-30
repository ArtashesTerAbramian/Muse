using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class StaticTextTranslationConfiguration : BaseConfiguration<StaticTextTranslation>
{
    public override void Configure(EntityTypeBuilder<StaticTextTranslation> builder)
    {
        base.Configure(builder);
    }
}