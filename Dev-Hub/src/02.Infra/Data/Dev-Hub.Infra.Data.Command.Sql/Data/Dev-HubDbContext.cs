

using Microsoft.EntityFrameworkCore;

namespace Dev_Hub.Infra.Data.Command.Sql.Data;
public class Dev_HubDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=Dev-HubDb; User Id=sa;Password=241065MASNgod!; Trusted_Connection=False;MultipleActiveResultSets=true;TrustServerCertificate=True ");
        base.OnConfiguring(optionsBuilder);
    }
}
