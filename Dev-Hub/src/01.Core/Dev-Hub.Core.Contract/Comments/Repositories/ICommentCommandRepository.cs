using Dev_Hub.Core.Contract.Common.Repositories;
using Dev_Hub.Core.Domain.Comments.Entities;

namespace Dev_Hub.Core.Contract.Comments.Repositories;
public interface ICommentCommandRepository : IBaseRepository<Comment,long>;

