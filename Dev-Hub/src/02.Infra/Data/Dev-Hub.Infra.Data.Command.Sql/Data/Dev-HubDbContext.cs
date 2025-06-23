

using System.Reflection.Emit;

using Dev_Hub.Core.Domain.Authors.Entities;
using Dev_Hub.Core.Domain.Comments.Entities;
using Dev_Hub.Core.Domain.Contents.Entities;
using Dev_Hub.Core.Domain.Tags.Entities;

using Microsoft.EntityFrameworkCore;

namespace Dev_Hub.Infra.Data.Command.Sql.Data;
public class Dev_HubDbContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Tag> Tags { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=Dev-HubDb; User Id=*****************;Password=*******************; Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True ");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
