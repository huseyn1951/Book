using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Book> Books { get; set; }

        public Author(string name,string surname)
        {
            Name = name;
            Surname = surname;

        }
    }
}
