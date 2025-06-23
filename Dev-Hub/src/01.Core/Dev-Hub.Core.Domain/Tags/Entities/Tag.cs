using Dev_Hub.Core.Domain.Contents.Entities;
using Dev_Hub.Core.Domain.Framework.Entities;

namespace Dev_Hub.Core.Domain.Tags.Entities;
public class Tag : BaseEntity
{
    public string Title { get; private set; }

    public ICollection<Content> Contents { get; private set; }

    private Tag()
    {
    }

    private Tag(string title)
    {
        Title = title;
    }

    public static Tag Create(string title) => new(title);

    public void Update(string title) => Title = title;
}
