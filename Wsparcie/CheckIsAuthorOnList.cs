namespace Wsparcie;

public class CheckIsAuthorOnList
{
    private List<Author> _list;

    public CheckIsAuthorOnList(List<Author> list)
    {
        _list = list;
    }

    internal bool Check(string value)
    {
        foreach (var author in _list)
        {
            if (author.NameAndSurname.ToLower().Contains(value.ToLower()))
            {
                return true;
            }
        }
        return false;
    }
}