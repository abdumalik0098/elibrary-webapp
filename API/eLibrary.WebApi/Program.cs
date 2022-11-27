using Microsoft.EntityFrameworkCore;
using Service.Lib;
using Microsoft.AspNetCore.Routing;
using Domain.Lib;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

IPAddress ip = IPAddress.Parse("127.0.0.1");
IPEndPoint endpoint = new IPEndPoint(ip, 7125);

BookService bookService = new BookService();

app.MapGet("/api/books", bookService.GetAll);
app.MapGet("/api/books/{id}", (int id) => bookService.GetById(id));
app.MapPost("/api/books", (Book book) => bookService.AddBook(book));
app.MapPut("/api/books", (Book book) => bookService.Update(book));
app.MapDelete("/api/books/{id}", (int id) => bookService.Delete(id));


app.Run();
