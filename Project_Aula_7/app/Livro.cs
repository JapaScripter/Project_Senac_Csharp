using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
	internal class Livro:Documento
	{
		private string titulo;

		public string getTitulo()
		{
			return titulo;
		}

		public void setTitulo(string titulo)
		{
			this.titulo = titulo;
		}

		public void DadosLivro()
		{
			Console.WriteLine($"O titulo do livro é: {titulo}");
			Console.WriteLine($"O autor é: {getAuthor()}");
			Console.WriteLine($"A data é: {getDate()}");
		}
	}
}