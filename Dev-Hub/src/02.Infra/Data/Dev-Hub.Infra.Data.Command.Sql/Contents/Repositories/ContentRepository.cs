using Dev_Hub.Core.Domain.Contents.Entities;
using Dev_Hub.Infra.Data.Command.Sql.Common.Repositories;
using Dev_Hub.Infra.Data.Command.Sql.Data;

namespace Dev_Hub.Infra.Data.Command.Sql.Contents.Repositories;
public class ContentRepository : BaseRepository<Dev_HubDbContext, Content, long>
{
    public ContentRepository(Dev_HubDbContext dbContext) : base(dbContext)
    {
    }
}
