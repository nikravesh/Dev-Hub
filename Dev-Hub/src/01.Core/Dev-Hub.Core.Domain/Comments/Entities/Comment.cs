using Dev_Hub.Core.Domain.Framework.Entities;

namespace Dev_Hub.Core.Domain.Comments.Entities;
public class Comment : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Comments { get; private set; }
    public DateOnly CommentDate { get; private set; }
    public TimeOnly CommentTime { get; private set; }

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
        Comments = comment;
        CommentDate = commentDate;
        CommentTime = commentTime;
    }

    public static Comment Create(
        string firstName,
        string lastName,
        string comment,
        DateOnly commentDate,
        TimeOnly commentTime)
        => new(firstName, lastName, comment, commentDate, commentTime);

    public void Update(string comment) => Comments = comment;
}
