using Dev_Hub.Core.Domain.Contents.Entities;
using Dev_Hub.Core.Domain.Framework.Entities;

namespace Dev_Hub.Core.Domain.Comments.Entities;
public class Comment : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string CommentContent { get; private set; }
    public DateOnly CommentDate { get; private set; }
    public TimeOnly CommentTime { get; private set; }
    public bool IsPublish { get; private set; }

    private Comment() { }

    private Comment(
        string firstName,
        string lastName,
        string comment,
        DateOnly commentDate,
        TimeOnly commentTime)
    {
        FirstName = firstName;
        LastName = lastName;
        CommentContent = comment;
        CommentDate = commentDate;
        CommentTime = commentTime;
        IsPublish = false;
    }

    public static Comment Create(
        string firstName,
        string lastName,
        string comment,
        DateOnly commentDate,
        TimeOnly commentTime)
        => new(firstName, lastName, comment, commentDate, commentTime);

    public void Update(string comment) => CommentContent = comment;
}
