

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

    public Dev_HubDbContext(DbContextOptions<Dev_HubDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}
