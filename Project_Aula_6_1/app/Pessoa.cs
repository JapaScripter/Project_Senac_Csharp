using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_1
{
	internal class Pessoa
	{
		public string nome;
		public int idade;
		public double altura;
		public double peso;

		public void falar()
		{
			Console.WriteLine($"Olá, meu nome é {nome}, tenho {idade} anos de idade, peso atualmente {peso}kg e tenho {altura}m de altura.");
		}
		public void comer()
		{
			Console.WriteLine($"A pessoa {nome} está comendo.");
		}
	}
}