using Wsparcie.Models;

namespace Wsparcie.Controllers;

public class AuthorClearer
{
    private readonly AuthorsGroup _authorsGroup;

    public AuthorClearer(AuthorsGroup authorsGroup)
    {
        _authorsGroup = authorsGroup;
    }

    internal void Clear()
    {
        _authorsGroup.List.Clear();
        Console.WriteLine($"List cleared.\nNumber of elements on the list: {_authorsGroup.List.Count}");
    }
}