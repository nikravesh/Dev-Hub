using System.Runtime.InteropServices;

using Dev_Hub.Core.Domain.Framework.Entities;

namespace Dev_Hub.Core.Domain.Authors.Entities;
public class Author : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private Author() { }

    private Author(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public static Author Create(string firstName, string lastName)
    => new(firstName, lastName);
}
