using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Lib
{
    public class Author
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        // public List<Book> Books { get; set; }

        public Author(int id, string fullName, int age)
        {
            Id = id;
            FullName = fullName;
            Age = age;
        }
    }
}
