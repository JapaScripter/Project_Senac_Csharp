using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
    internal class Livro:Documento
    {
        public string titulo;

        public string getTitle()
        {
            return titulo;
        }

        public void DadosLivro()
        {
            Console.WriteLine($"Titulo do livro é: {titulo}");
            Console.WriteLine($"Autor: {getAuthor()}");
            Console.WriteLine($"Data: {getDate()}");

        }
    }
}
