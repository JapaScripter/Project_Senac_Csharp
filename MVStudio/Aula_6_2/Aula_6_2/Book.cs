using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_2
{
    internal class Book:Document
    {
        public string title;

        public Book(string author, int date, string title)
        {
            this.title = title;
            this.author = author;
            this.date = date;
        }

        public void getTitle()
        {
            Console.WriteLine($"O titulo do livro é?");
        }
    }
}
