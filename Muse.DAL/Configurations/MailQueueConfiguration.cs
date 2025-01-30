using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Muse.DAL.Models;

namespace Muse.DAL.Configurations;

public class MailQueueConfiguration : BaseConfiguration<MailQueue>
{
    public override void Configure(EntityTypeBuilder<MailQueue> builder)
    {
        base.Configure(builder);
    }
}