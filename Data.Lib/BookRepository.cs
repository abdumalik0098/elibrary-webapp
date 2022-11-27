using Domain.Lib;

namespace Data.Lib
{
    public class BookRepository
    {
        public List<Book> books = new List<Book>
        {
            new Book(1001, "Clean Code", 2011, new Author(001,"Uncle Bob", 42),
                new Publisher(001, "ORELLY")),
            new Book(1002, "Clean Architecture", 2014, new Author(001,"Uncle Bob", 42),
                new Publisher(001, "ORELLY")),
        };
    }
}