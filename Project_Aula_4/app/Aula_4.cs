using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// string[] pessoas = { "Lucas", "João", "Maria", "Ana", "Pedro", "Carlos", "Fernanda", "Juliana", "Roberto", "Patrícia" };

			// Console.WriteLine($"Pessoa 1: {pessoas[0]}");
			// Console.WriteLine($"Pessoa 2: {pessoas[1]}");
			// Console.WriteLine($"Pessoa 3: {pessoas[2]}");

			// for (int i = 0; i < pessoas.Length; i++)
			// {
			// 	Console.WriteLine(pessoas[i]);
			// }

			// foreach (string pessoa in pessoas)
			// {
			// 	Console.WriteLine(pessoa);
			// }

			// int i = 0;

			// while (i < pessoas.Length)
			// {
			// 	Console.WriteLine(pessoas[i]);
			// 	i++;
			// }
			// do
			// {
			// 	Console.WriteLine(pessoas[i]);
			// 	i++;
			// } while (i < pessoas.Length);

			string[,] cadastro =
			{
				{"C#","Lucas", "lucas@gmail.com"},
				{"C#","João", "joao@gmail.com"},
				{"C#","Maria", "maria@gmail.com"},
				{"C#","Ana", "ana@gmail.com"},
				{"C#","Pedro", "pedro@gmail.com"},
			};

			// for (int i = 0; i < cadastro.GetLength(0); i++)
			// {
			// 	for (int j = 0; j < cadastro.GetLength(1); j++)
			// 	{
			// 		Console.WriteLine(cadastro[i, j]);
			// 	}Console.WriteLine("\r\n");
			// }

		}
	}
}