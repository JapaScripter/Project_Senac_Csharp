using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_2
{
	internal class EMail:Document
	{
		public string subject;
		public string to;

		public EMail(string subject, string to, string authors, int date)
		{
			this.subject = subject;
			this.to = to;
			this.authors = authors;
			this.date = date;
		}

		public void getSubject()
		{
			Console.WriteLine($"O assunto do email é {subject}");
		}

		public void getTo()
		{
			Console.WriteLine($"O destinatário do email é {to}");
		}
	}
}