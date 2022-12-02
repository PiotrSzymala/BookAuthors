namespace Wsparcie;

public class RemoveAuthor
{
    private List<Author> _list;

    public RemoveAuthor(List<Author> list)
    {
        _list = list;
    }

    internal void Remove(string value)
    {
        var check = new CheckIsAuthorOnList(_list);
        if (check.Check(value))
        {
            var author = _list.First(x => x.NameAndSurname.ToLower().Contains(value.ToLower()));
            _list.Remove(author);
            Console.WriteLine($"{author.NameAndSurname} removed successfully");
        }
        else
        {
            Console.WriteLine("There's no such an author.");
        }
    }
}