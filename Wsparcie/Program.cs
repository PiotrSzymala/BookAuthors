using Wsparcie;

List<Author> authors = new List<Author>()
{
    new Author("Joseph Conrad"),
    new Author("Carlos Zafon"),
    new Author("Leopold Tyrmand"),
    new Author("Franz Kafka"),
};

 var menu = new  MenuAuthor(authors);
 menu.Chose();