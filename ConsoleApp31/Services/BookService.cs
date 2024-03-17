using ConsoleApp31.Enums;
using ConsoleApp31.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31.Services
{
    public class BookService
    {
       public void ShowAuthorAndBook(List<Book> books)
        {
            foreach (var book in books)
            {

                Console.WriteLine(book.Name + book.Author.Name + book.Author.Surname);

            }

        }
    }
}
