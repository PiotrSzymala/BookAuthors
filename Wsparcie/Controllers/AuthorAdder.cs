using Wsparcie.Models;

namespace Wsparcie.Controllers;

public class AuthorAdder
{
    private readonly AuthorsGroup _authorsGroup;

    public AuthorAdder(AuthorsGroup authorsGroup)
    {
        _authorsGroup = authorsGroup;
    }

    internal void AddAuthor(string name, int index)
    {
        AuthorPresenceChecker check = new AuthorPresenceChecker(_authorsGroup);
        if (!check.Check(name))
        {
            _authorsGroup.List.Insert(index - 1, new Author(name));
            Console.WriteLine("New author added.");
        }
        else
        {
            Console.WriteLine("Author is already on the list");
        }
    }
}