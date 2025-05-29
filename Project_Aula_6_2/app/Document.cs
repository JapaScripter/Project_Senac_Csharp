using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_2
{
	internal class Document
	{
		public string authors;
		public int date;

		public Document(string authors, int date)
		{
			this.authors = authors;
			this.date = date;
		}
		public void getAuthors()
		{
			Console.WriteLine($"O autor é {authors}");
		}
		public void getDate()
		{
			Console.WriteLine($"A data é {date}");
		}
	}
}