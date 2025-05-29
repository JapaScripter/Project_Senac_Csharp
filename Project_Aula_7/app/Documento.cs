using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7
{
	internal class Documento
	{
		private string author;
		private string date;

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

		public void setAuthor(string author)
		{
			this.author = author;
		}

		public void setDate(string date)
		{
			this.date = date;
		}

		public void addAuthor()
		{
			Console.WriteLine($"O nome do autor é: {author}");
		}

		public void addDate()
		{
			Console.WriteLine($"A data é: {date}");
		}
	}
}