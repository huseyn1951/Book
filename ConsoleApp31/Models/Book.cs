using ConsoleApp31.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31.Models
{
    public class Book
    {
        public string Name { get; set; }
        public int Page { get; set; }
        public int Price { get; set; }
        public Genres Genre { get; set; }
        public Author Author { get; set; }

        public Book(string name, int price, int page, Genres genre)
        {
            Name = name;
            Page = page;
            Price = price;
            Genre = genre;
            

        }
    }
}
