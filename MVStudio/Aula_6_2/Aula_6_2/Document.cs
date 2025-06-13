using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_2
{
    internal class Document
    {
        public string author;
        public int date;

        public Document(string author, int date)
        {
            this.author = author;
            this.date = date;
        }

        public void getAuthor()
        {
            Console.WriteLine($"O autor é: {author}");
        }

        public void getDate()
        {
            Console.WriteLine($"A data é {date}");
        }
    }
}
