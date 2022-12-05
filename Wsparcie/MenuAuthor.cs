namespace Wsparcie;

public class MenuAuthor
{
    private List<Author> _author;

    public MenuAuthor(List<Author> author)
    {
        _author = author;
    }

    private void ShowOptions()
    {
        Console.WriteLine("1 - Show authors.");
        Console.WriteLine("2 - Check is particular author appears on the list.");
        Console.WriteLine("3 - Add new author.");
        Console.WriteLine("4 - Remove author.");
        Console.WriteLine("5 - Clean list.");
        Console.WriteLine("Escape - Exit.");
    }

    public void Chose()
    {
        var displayAuthors = new DisplayAuthors(_author);
        var checkAuthor = new CheckIsAuthorOnList(_author);
        var addNewAuthor = new AddNewAuthor(_author);
        var removeAuthor = new RemoveAuthor(_author);
        var clearList = new ClearAuthors(_author);
        bool flag;

        do
        {
            ShowOptions();
            flag = true;
            var toPress = Console.ReadKey(true);
            Console.Clear();
            string input;
            switch (toPress.Key)
            {
                case ConsoleKey.D1:

                    displayAuthors.Display();

                    break;

                case ConsoleKey.D2:

                    Console.WriteLine("Insert author's name: ");
                    input = Console.ReadLine();

                    if (checkAuthor.Check(input))
                        Console.WriteLine("Author is on the list");
                    else
                        Console.WriteLine("Couldn't find that author");

                    break;

                case ConsoleKey.D3:

                    Console.WriteLine("Insert new author's name: ");
                    input = Console.ReadLine();

                    Console.WriteLine("Give index: ");
                    var index = int.Parse(Console.ReadLine());

                    addNewAuthor.AddAuthor(input, index);

                    break;

                case ConsoleKey.D4:

                    Console.WriteLine("Insert name to remove: ");
                    input = Console.ReadLine();

                    removeAuthor.Remove(input);

                    break;

                case ConsoleKey.D5:

                    clearList.Clear();

                    break;

                case ConsoleKey.E:

                    flag = false;

                    break;
            }

            Console.ReadKey(true);
            Console.Clear();
        } while (flag);
    }
}