namespace Wsparcie;

public class DisplayAuthors
{
    private List<Author> _list;

    public DisplayAuthors(List<Author> authors)
    {
        _list = authors;
    }

    internal void Display()
    {
        if (_list.Count == 0)
            Console.WriteLine("List is empty");

        foreach (var author in _list)
        {
            Console.Write(author.NameAndSurname + ", ");
        }

        Console.WriteLine();
    }
}