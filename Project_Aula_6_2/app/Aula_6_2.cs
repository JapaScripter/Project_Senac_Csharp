using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Document doc1 = new Document("José", 27052025);
			Book book1 = new Book("Aprendendo C#", "Fábio Venâncio", 27052025);
			EMail email1 = new EMail("Reunião Urgente", "Fábio Venâncio", "José", 27052025);

			doc1.getAuthors();
			doc1.getDate();
			book1.getTitle();
			email1.getSubject();
			email1.getTo();

		}
	}
}