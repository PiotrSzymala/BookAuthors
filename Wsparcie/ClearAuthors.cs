namespace Wsparcie;

public class ClearAuthors
{
    private List<Author> _list;

    public ClearAuthors(List<Author> list)
    {
        _list = list;
    }

    internal void Clear()
    {
        _list.Clear();
        Console.WriteLine($"List cleared.\nNumber of elements on the list: {_list.Count}");
    }
}