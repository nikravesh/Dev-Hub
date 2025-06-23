using Dev_Hub.Core.Contract.Common.Repositories;
using Dev_Hub.Core.Domain.Tags.Entities;

namespace Dev_Hub.Core.Contract.Tags.Repositories;
public interface ITagCommandRepository : IBaseRepository<Tag, long>;
