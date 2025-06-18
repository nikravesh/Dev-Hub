using Dev_Hub.Core.Domain.Framework.Entities;

namespace Dev_Hub.Core.Domain.Contents.Entities;
public class Content : BaseEntity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateOnly PublishDate { get; private set; }
    public TimeOnly PublishTime { get; private set; }
    public int AuthorName { get; private set; }

    public Content()
    {
    }

    private Content(string title, string description, DateOnly publishDate, TimeOnly publishTime, int authorName)
    {
        Title = title;
        Description = description;
        PublishDate = publishDate;
        PublishTime = publishTime;
        AuthorName = authorName;
    }

    public static Content Create(string title, string description, DateOnly publishDate, TimeOnly publishTime, int authorName)
    => new(title, description, publishDate, publishTime, authorName);

    public void Update(string title,string description)
    {
        Title = title;
        Description = description;
    }
}
