using Data.Lib;
using Domain.Lib;

namespace Service.Lib
{
    public class BookService
    {
        //int nextId = 1002;
        public BookRepository bookRepos = new BookRepository();
        public List<Book> Books { get { return bookRepos.books; } set { } }

        // Get All
        public List<Book> GetAll() => Books;

        // Get by Id
        public Book? GetById(int id) => Books.FirstOrDefault(p => p.Id == id);

        // Add
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // Update
        public void Update(Book book)
        {
            var index = Books.FindIndex(p => p.Id == book.Id);
            if (index == -1)
                return;

            Books[index] = book;
        }
        // Delete
        public void Delete(int id)
        {
            var book = GetById(id);
            if (book is null)
                return;

            Books.Remove(book);
        }
    }
}