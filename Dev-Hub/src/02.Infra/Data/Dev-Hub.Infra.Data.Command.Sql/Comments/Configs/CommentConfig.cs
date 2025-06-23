using Dev_Hub.Core.Domain.Comments.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dev_Hub.Infra.Data.Command.Sql.Comments.Configs;
internal class CommentConfig : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable(nameof(Comment));
        builder.Property(c => c.FirstName).IsRequired().HasMaxLength(50).IsUnicode(false);
        builder.Property(c => c.LastName).IsRequired().HasMaxLength(50).IsUnicode(false);
        builder.Property(c => c.CommentContent).IsRequired().HasMaxLength(1000).IsUnicode(false);
    }
}
