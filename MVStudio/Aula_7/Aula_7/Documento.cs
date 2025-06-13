using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
    internal class Documento
    {
        public string author;
        public string date;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string getAuthor()
        {
            return author;
        }

        public string getDate()
        {
            return date;
        }

        public void addAuthor()
        {
            Console.WriteLine($"O nome do autor é: {author}");
        }

        //public void PegarAuthor()
        //{
        //    Console.WriteLine($"O nome do autor é: {author}");
        //}

        //public void PegarDate()
        //{
        //    Console.WriteLine($"A data de publicação é: {date}");
        //}

        //public void MostrarTudo()
        //{
        //    Console.WriteLine($"O nome do autor é: {author}, a data de publicação é: {date}");
        //}

        //public void AddAuthor(string author)
        //{
        //    this.author = author;
        //}
    }
}
