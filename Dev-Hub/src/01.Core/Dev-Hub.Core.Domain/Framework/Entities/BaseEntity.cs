namespace Dev_Hub.Core.Domain.Framework.Entities;
public abstract class BaseEntity
{
    public Guid BusinessId { get; private set; }
    public long Id { get; private set; }

    protected BaseEntity()
    {
        BusinessId = Guid.NewGuid();
    }
}
