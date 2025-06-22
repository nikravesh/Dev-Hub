using Dev_Hub.Core.Domain.Authors.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dev_Hub.Infra.Data.Command.Sql.Authors.Configs;
public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable(nameof(Author));
        builder.Property(a => a.FirstName).HasMaxLength(50).IsRequired().IsUnicode(false);
        builder.Property(a=>a.LastName).HasMaxLength(50).IsRequired().IsUnicode(false);
    }
}
