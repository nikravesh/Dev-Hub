using Dev_Hub.Core.Domain.Comments.Entities;
using Dev_Hub.Infra.Data.Command.Sql.Common.Repositories;
using Dev_Hub.Infra.Data.Command.Sql.Data;

namespace Dev_Hub.Infra.Data.Command.Sql.Comments.Repositories;
public class CommentRepository : BaseRepository<Dev_HubDbContext, Comment, long>
{
    public CommentRepository(Dev_HubDbContext dbContext) : base(dbContext)
    {
    }
}
