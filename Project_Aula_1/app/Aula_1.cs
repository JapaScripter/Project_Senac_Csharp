using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{	
	internal class Program
	{
		static void Main(string[] args)
		{
			string user = "Yuri";
			int idade = 27;

			Console.WriteLine("Olá, " + user + " e você tem "  + idade.ToString() + " anos");

			float peso = 60.0f;

			Console.WriteLine($"Você pesa {peso} kg");

			bool cadastro = true;
			string status = "";

			if (cadastro == true)
			{
				status = "está cadastrado";
			}
			else
			{
				status = "não está cadastrado";
			}
			Console.WriteLine($"O usuário {user}, {status} no sistema.");

			Console.ReadKey();
		}
	}
}