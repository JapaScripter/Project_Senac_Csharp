using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc1 = new Document("João", 27052025);
            Book book1 = new Book("Junior",27052025, "O Senhor dos Anéis");
            EMail email1 = new EMail("Junior",25052025,"Reunião de docentes", "Fábio Venâncio");

            book1.getTitle();
            email1.getSubject();
            email1.getTo();
        }
    }
}
