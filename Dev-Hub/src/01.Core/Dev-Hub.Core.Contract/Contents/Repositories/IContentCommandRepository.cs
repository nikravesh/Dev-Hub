using Dev_Hub.Core.Contract.Common.Repositories;
using Dev_Hub.Core.Domain.Contents.Entities;

namespace Dev_Hub.Core.Contract.Contents.Repositories;
public interface IContentCommandRepository: IBaseRepository<Content,long>;
