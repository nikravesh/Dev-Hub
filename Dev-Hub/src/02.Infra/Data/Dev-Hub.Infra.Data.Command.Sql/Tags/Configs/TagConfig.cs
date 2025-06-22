using Dev_Hub.Core.Domain.Tags.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dev_Hub.Infra.Data.Command.Sql.Tags.Configs;
public class TagConfig : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable(nameof(Tag));
        builder.Property(t => t.Title).IsRequired().IsUnicode(false).HasMaxLength(20);
    }
}
