using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
	class Program:Documento
	{
		static void Main(string[] args)
		{
			// Documento doc1 = new Documento();
			// doc1.author = "Julian";
			// doc1.date = "29/05/2025";
			// doc1.setAuthor("Julian");
			// // doc1.Author = "Juliano";
			// doc1.setDate("29/05/2025");
			// Console.WriteLine(doc1.getAuthor());
			// Console.WriteLine(doc1.getDate());
			// Console.WriteLine(doc1.Author);

			Livro livro1 = new Livro();
			livro1.setTitulo("Aprendendo C#");
			livro1.setAuthor("Julian");
			livro1.setDate("29/05/2025");
			livro1.DadosLivro();
		}
	}
}