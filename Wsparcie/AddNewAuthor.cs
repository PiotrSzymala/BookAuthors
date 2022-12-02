namespace Wsparcie;

public class AddNewAuthor
{
    private List<Author> _list;

    public AddNewAuthor(List<Author> list)
    {
        _list = list;
    }

    internal void AddAuthor(string name, int index)
    {
        CheckIsAuthorOnList check = new CheckIsAuthorOnList(_list);
        if (!check.Check(name))
        {
            Author newAuthor = new Author();
            newAuthor.NameAndSurname = name;
            _list.Insert(index-1, newAuthor);
            Console.WriteLine("New author added.");
        }
        else
        {
            Console.WriteLine("Author is already on the list");
        }
    }
}