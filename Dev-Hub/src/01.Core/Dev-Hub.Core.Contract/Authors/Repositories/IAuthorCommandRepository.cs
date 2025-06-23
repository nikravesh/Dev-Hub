using Dev_Hub.Core.Contract.Common.Repositories;
using Dev_Hub.Core.Domain.Authors.Entities;

namespace Dev_Hub.Core.Contract.Authors.Repositories;
public interface IAuthorCommandRepository : IBaseRepository<Author,long>
{
}
