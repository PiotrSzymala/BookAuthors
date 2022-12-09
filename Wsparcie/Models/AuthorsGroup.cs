namespace Wsparcie.Models;

public class AuthorsGroup
{
    public List<Author> List { get; set; }

    public AuthorsGroup(List<Author> authors)
    {
        List = authors;
    }
}