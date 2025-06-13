using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5_1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Program.Aluno("Yuri", 27);
			Program.Aluno("Fabio", 30);
			Program.Valores(15.15154612, 15.8499216);
			Program.Valores(15.48151, 6.45923445);
			Program.Verificar(15);
			Program.Media(5.8, 9.8, 2.5);
		}

		static void Aluno(string nome, int idade)
		{
			Console.WriteLine($"O nome do aluno é: {nome}, e a idade dele é: {idade}\r\n");
		}

		static void Valores(double valor1, double valor2)
		{
			double resultado = valor1 + valor2;
			Console.WriteLine($"{valor1} + {valor2} = {resultado}\r\n");
		}

		static bool Verificar(int idade)
		{
			if (idade >= 18)
			{
				Console.WriteLine("A pessoa é maior de idade\r\n");
				return true;
			}
			else
			{
				Console.WriteLine("A pessoa é menor de idade\r\n");
				return false;
			}
		}

		static bool Media(double nota1, double nota2, double nota3)
		{
			double resultadomedia = (nota1 + nota2 + nota3) / 3;
			if (resultadomedia >= 7)
			{
				Console.WriteLine($"nota1 + nota2 + nota3 = " + resultadomedia + " o aluno foi aprovado\r\n");
				return true;
			}
			else
			{
				Console.WriteLine($"nota1 + nota2 + nota3 = " + resultadomedia + " o aluno foi reprovado\r\n");
				return false;
			}
		}
	}
}