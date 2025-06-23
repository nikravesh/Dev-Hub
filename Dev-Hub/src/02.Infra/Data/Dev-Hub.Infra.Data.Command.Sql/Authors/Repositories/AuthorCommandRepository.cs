using Dev_Hub.Core.Domain.Authors.Entities;
using Dev_Hub.Infra.Data.Command.Sql.Common.Repositories;
using Dev_Hub.Infra.Data.Command.Sql.Data;

namespace Dev_Hub.Infra.Data.Command.Sql.Authors.Repositories;
public class AuthorCommandRepository : BaseRepository<Dev_HubDbContext, Author, long>
{
    public AuthorCommandRepository(Dev_HubDbContext dbContext) : base(dbContext)
    {
    }
}
