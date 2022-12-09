using Wsparcie.Models;

namespace Wsparcie.Controllers;

public class AuthorPresenceChecker
{
    private readonly AuthorsGroup _authorsGroup;

    public AuthorPresenceChecker(AuthorsGroup authorsGroup)
    {
        _authorsGroup = authorsGroup;
    }

    internal bool Check(string value)
    {
        foreach (var author in _authorsGroup.List)
        {
            if (author.NameAndSurname.ToLower().Contains(value.ToLower()))
            {
                return true;
            }
        }

        return false;
    }
}