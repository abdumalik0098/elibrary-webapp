namespace eLibrary.BlazorApp.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }

        public Author(int id, string fullName, int age)
        {
            Id = id;
            FullName = fullName;
            Age = age;
        }
    }
}
