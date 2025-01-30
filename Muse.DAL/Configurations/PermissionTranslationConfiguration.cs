using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class PermissionTranslationConfiguration : BaseConfiguration<PermissionTranslation>
{
    public override void Configure(EntityTypeBuilder<PermissionTranslation> builder)
    {
        base.Configure(builder);
    }
}