using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class UserSessionConfiguration : BaseConfiguration<UserSession>
{
    public override void Configure(EntityTypeBuilder<UserSession> builder)
    {
        base.Configure(builder);
    }
}