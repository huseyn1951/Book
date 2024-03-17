using ConsoleApp31.Models;
using ConsoleApp31.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            BookService bookservice = new BookService();
            AuthorService authorService = new AuthorService();

            Book book1 = new Book("book1",20,200,Enums.Genres.Drama);
            Book book2 = new Book("book2", 10, 130, Enums.Genres.Romantic);
            Book book3 = new Book("book2", 30, 300, Enums.Genres.Science);

            Author author1 = new Author("name1","surname1");
            Author author2 = new Author("name2", "surname2");
            Author author3 = new Author("name3", "surname3");

            book1.Author = author1;
            book2.Author = author2;
            book3.Author = author3;

            author1.Books = new List<Book>() {book1};
            author2.Books = new List<Book>() {book2};
            author3.Books = new List<Book>() {book3};

            List<Book> books = new List<Book>() { book1, book2, book3 };

            bookservice.ShowAuthorAndBook(books);
        }

    }
}
