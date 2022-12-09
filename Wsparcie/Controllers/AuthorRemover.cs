using Wsparcie.Models;

namespace Wsparcie.Controllers;

public class AuthorRemover
{
    private readonly AuthorsGroup _authorsGroup;

    public AuthorRemover(AuthorsGroup authorsGroup)
    {
        _authorsGroup = authorsGroup;
    }

    internal void Remove(string value)
    {
        var check = new AuthorPresenceChecker(_authorsGroup);
        if (check.Check(value))
        {
            var author = _authorsGroup.List.First(x => x.NameAndSurname.ToLower().Contains(value.ToLower()));
            _authorsGroup.List.Remove(author);
            Console.WriteLine($"{author.NameAndSurname} removed successfully");
        }
        else
        {
            Console.WriteLine("There's no such an author.");
        }
    }
}