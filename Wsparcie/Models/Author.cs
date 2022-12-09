namespace Wsparcie.Models;

public class Author
{
    public string NameAndSurname { get; set; }

    public Author(string name)
    {
        NameAndSurname = name;
    }
}