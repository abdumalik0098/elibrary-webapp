namespace eLibrary.BlazorApp.Data
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public Book(int id, string title, int year, Author author, Publisher publisher)
        {
            Id = id;
            Title = title;
            Year = year;
            Author = author;
            Publisher = publisher;
        }
        public Book()
        {

        }
    }
}
