using System.Net;
using System.Net.Http.Json;

namespace eLibrary.BlazorApp.Data
{
    public class BookService
    {
        HttpClient httpClient = new HttpClient();
        public async Task<List<Book>> GetMethod()
        {
            var req = "https://localhost:7125/api/books";
            List<Book>? books = await httpClient.GetFromJsonAsync<List<Book>>(req);
            return books!;
        }
        
        public async Task<Book> GetByIdMethod(int id)
        {
            var req = $"https://localhost:7125/api/books/{id}";
            Book? book = await httpClient.GetFromJsonAsync<Book>(req);
            return book!;
        }

        
        public async Task AddMethod(Book nbook)
        {
            using var response = await httpClient.PostAsJsonAsync("https://localhost:7125/api/books", nbook);
            
        }
        public async Task UpdateMethod(Book nbook)
        {
            using var response = await httpClient.PutAsJsonAsync("https://localhost:7125/api/books", nbook);
            
        }
        /*
        async Task UpdateMethod()
        {
            // id изменяемого объекта
            int id = 1;
            // отправляемый объект
            var tom = new Person { Id = id, Name = "Tomas", Age = 38 };
            using var response = await httpClient.PutAsJsonAsync("https://localhost:7269/api/users/", tom);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // если возникла ошибка, считываем сообщение об ошибке
                Error? error = await response.Content.ReadFromJsonAsync<Error>();
                Console.WriteLine(error?.Message);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // десериализуем ответ в объект Person
                Person? person = await response.Content.ReadFromJsonAsync<Person>();
                Console.WriteLine($"{person?.Id} - {person?.Name} ({person?.Age})");
            }
        }
        */
        public async Task DeleteMethod(int id)
        {
            using var response = await httpClient.DeleteAsync($"https://localhost:7125/api/books/{id}");
           
        }
        
    }
}
