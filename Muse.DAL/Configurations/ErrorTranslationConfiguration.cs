using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class ErrorTranslationConfiguration : BaseConfiguration<ErrorTranslation>
{
    public override void Configure(EntityTypeBuilder<ErrorTranslation> builder)
    {
        base.Configure(builder);
    }
}