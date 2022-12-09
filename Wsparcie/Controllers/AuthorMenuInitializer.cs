using Wsparcie.Models;

namespace Wsparcie.Controllers;

public class AuthorMenuInitializer
{
    private readonly AuthorsGroup _authorsGroup;

    public AuthorMenuInitializer(AuthorsGroup authorsGroup)
    {
        _authorsGroup = authorsGroup;
    }

    private void ShowOptions()
    {
        Console.WriteLine("1 - Show authors.");
        Console.WriteLine("2 - Check is particular author appears on the list.");
        Console.WriteLine("3 - Add new author.");
        Console.WriteLine("4 - Remove author.");
        Console.WriteLine("5 - Clean list.");
        Console.WriteLine("E - Exit.");
    }

    public void Chose()
    {
        var displayAuthors = new AuthorDisplayer(_authorsGroup);

        var checkAuthor = new AuthorPresenceChecker(_authorsGroup);
        var addNewAuthor = new AuthorAdder(_authorsGroup);
        var removeAuthor = new AuthorRemover(_authorsGroup);
        var clearList = new AuthorClearer(_authorsGroup);
        bool flag;

        do
        {
            ShowOptions();

            var toPress = Console.ReadKey(true);
            flag = true;

            Console.Clear();

            switch (toPress.Key)
            {
                case ConsoleKey.D1:

                    displayAuthors.Display();

                    break;

                case ConsoleKey.D2:

                    CheckIsAuthorOnTheList(checkAuthor);

                    break;

                case ConsoleKey.D3:

                    AddNewAuthorToTheList(addNewAuthor);

                    break;

                case ConsoleKey.D4:

                    RemoveAuthorFromTheList(removeAuthor);

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

    private static void RemoveAuthorFromTheList(AuthorRemover removeAuthor)
    {
        Console.WriteLine("Insert name to remove: ");
        var input = Console.ReadLine();

        removeAuthor.Remove(input);
    }

    private static void AddNewAuthorToTheList(AuthorAdder addNewAuthor)
    {
        Console.WriteLine("Insert new author's name: ");
        var input = Console.ReadLine();

        Console.WriteLine("Give index: ");
        var index = int.Parse(Console.ReadLine());

        addNewAuthor.AddAuthor(input, index);
    }

    private static void CheckIsAuthorOnTheList(AuthorPresenceChecker checkAuthor)
    {
        Console.WriteLine("Insert author's name: ");
        var input = Console.ReadLine();

        Console.WriteLine(checkAuthor.Check(input) ? "Author is on the list" : "Couldn't find that author");
    }
}