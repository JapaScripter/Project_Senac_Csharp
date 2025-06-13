using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// float nota1 = 10f;
			// float nota2 = 5.5f;
			// float nota3 = 8.3f;
			// float media = (nota1 + nota2 + nota3) / 3;

			// if (media >= 7)
			// {
			// 	Console.WriteLine("O aluno foi aprovado com média = " + media);
			// }
			// else
			// {
			// 	Console.WriteLine("O aluno foi reprovado com média = " + media);
			// }

			int level = 1;

			if (level <= 10)
			{
				Console.WriteLine("Você é um noob");
			}
			else if (level <= 20 & level > 10)
			{
				Console.WriteLine("Você é um amador");
			}
			else if (level <= 30 & level > 20)
			{
				Console.WriteLine("Você é um guerreiro");
			}
			else if (level <= 40 & level > 30)
			{
				Console.WriteLine("Você é um mestre");
			}
		}
	}
}