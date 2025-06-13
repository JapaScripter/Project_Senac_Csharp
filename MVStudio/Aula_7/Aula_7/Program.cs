using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento doc1 = new Documento();
            //doc1.author = "Julian";
            //doc1.date = "29/05/2025";

            //doc1.PegarAuthor();
            //doc1.PegarDate();
            //doc1.MostrarTudo();

            //doc1.setAuthor("Julian");
            //doc1.setDate("29/05/2025");
            doc1.Author = "Juliano";
            //Console.WriteLine(doc1.getAuthor());
            //Console.WriteLine(doc1.getDate());
            Console.WriteLine(doc1.Author);
        }
    }
}
