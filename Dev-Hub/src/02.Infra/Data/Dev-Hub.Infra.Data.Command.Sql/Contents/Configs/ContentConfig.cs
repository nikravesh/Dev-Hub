using Dev_Hub.Core.Domain.Contents.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dev_Hub.Infra.Data.Command.Sql.Contents.Configs;
internal class ContentConfig : IEntityTypeConfiguration<Content>
{
    public void Configure(EntityTypeBuilder<Content> builder)
    {
        builder.ToTable(nameof(Content));
        builder.Property(c => c.Title).HasMaxLength(500).IsRequired().IsUnicode(false);
        builder.Property(c => c.Description).IsRequired().IsUnicode(false);
    }
}
