using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Aluno aluno1 = new Aluno("João", 20, 1.75, 70.5, 1234);
			Aluno aluno2 = new Aluno("Jorge", 22, 1.86, 94.5, 12345);
			aluno1.falar();
			aluno1.comer();
			aluno2.falar();
			aluno2.comer();
		}
	}
}