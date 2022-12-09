using Wsparcie;
using Wsparcie.Controllers;
using Wsparcie.Models;

List<Author> authorsList = new List<Author>()
{
    new Author("Joseph Conrad"),
    new Author("Carlos Zafon"),
    new Author("Leopold Tyrmand"),
    new Author("Franz Kafka"),
};
var authorsGroup = new AuthorsGroup(authorsList);
var menu = new AuthorMenuInitializer(authorsGroup);
menu.Chose();