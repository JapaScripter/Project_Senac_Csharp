using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Aula_1_2
{
	class Program
	{
		static void Main(string[] args)
		{
			int valor1 = 10;
			int valor2 = 33;
			int resultado = valor1 + valor2;
			Console.WriteLine($"A soma de valor1 e valor2 é= {resultado}");

			string aluno = "João";
			float nota1 = 7.5f;
			float nota2 = 8.0f;
			float nota3 = 1.0f;
			float media = (nota1 + nota2 + nota3) / 3;
			Console.WriteLine($"A média final do aluno= {aluno} é {media}.");
			Console.WriteLine(aluno.GetType());

			double carteira = 10.510; Console.WriteLine($"Valor inicial da carteira= {carteira}");
			carteira++; Console.WriteLine($"Valor da carteira + 1 = {carteira}");
			carteira--; Console.WriteLine($"Valor da carteira - 1 = {carteira}");
			carteira += 10; Console.WriteLine($"Valor da carteira + 10 = {carteira}");
			carteira -= 10; Console.WriteLine($"Valor da carteira - 10 = {carteira}");
			carteira /= 10; Console.WriteLine($"Valor da carteira / 10 = {carteira}");
			carteira *= 10; Console.WriteLine($"Valor da carteira * 10 = {carteira}");

			float maior = 10.5f;
			float menor = 5.5f;
			bool result = maior < menor;
			Console.WriteLine($"O result é = {result}");
		}
	}
}