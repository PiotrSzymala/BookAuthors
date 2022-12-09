using Wsparcie.Models;

namespace Wsparcie.Controllers;

public class AuthorDisplayer
{
    private readonly AuthorsGroup _authorsGroup;

    public AuthorDisplayer(AuthorsGroup authorsGroup)
    {
        _authorsGroup = authorsGroup;
    }

    internal void Display()
    {
        if (_authorsGroup.List.Count == 0)
            Console.WriteLine("List is empty");

        foreach (var author in _authorsGroup.List)
        {
            Console.Write(author.NameAndSurname + ", ");
        }

        Console.WriteLine();
    }
}