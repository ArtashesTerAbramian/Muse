using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class RoleTranslationConfiguration : BaseConfiguration<RoleTranslation>
{
    public override void Configure(EntityTypeBuilder<RoleTranslation> builder)
    {
        base.Configure(builder);
    }
}