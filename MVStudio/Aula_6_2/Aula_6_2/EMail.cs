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

        public EMail(string author, int date, string subject, string to)
        {
            this.subject = subject;
            this.to = to;
            this.author = author;
            this.date = date;
        }

        public void getSubject()
        {
            Console.WriteLine($"O assunto do email é: {subject}");
        }

        public void getTo()
        {
            Console.WriteLine($"O destinatário é: {to}");
        }
    }
}
