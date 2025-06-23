using Dev_Hub.Core.Domain.Tags.Entities;
using Dev_Hub.Infra.Data.Command.Sql.Common.Repositories;
using Dev_Hub.Infra.Data.Command.Sql.Data;

namespace Dev_Hub.Infra.Data.Command.Sql.Tags.Repositories;
public class TagRepository : BaseRepository<Dev_HubDbContext, Tag, long>
{
    public TagRepository(Dev_HubDbContext dbContext) : base(dbContext)
    {
    }
}
