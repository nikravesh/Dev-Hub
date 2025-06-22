using Dev_Hub.Core.Domain.Authors.Entities;
using Dev_Hub.Core.Domain.Framework.Entities;

namespace Dev_Hub.Core.Domain.Contents.Entities;
public class Content : BaseEntity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateOnly PublishDate { get; private set; }
    public TimeOnly PublishTime { get; private set; }
    public byte[] ContentImage { get; private set; }
    public ICollection<Author> Authors { get; private set; }

    private Content()
    {
    }

    private Content(string title, string description, DateOnly publishDate, TimeOnly publishTime)
    {
        Title = title;
        Description = description;
        PublishDate = publishDate;
        PublishTime = publishTime;
    }

    public static Content Create(string title, string description, DateOnly publishDate, TimeOnly publishTime)
    => new(title, description, publishDate, publishTime);

    public void Update(string title,string description)
    {
        Title = title;
        Description = description;
    }
}
