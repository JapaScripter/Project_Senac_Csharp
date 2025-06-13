using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7_1
{
	internal class Animal
	{
		public string nome;
		public char sexo;
		public int idade;
		public double peso;
		public string cor;

		public void Respirar()
		{
			Console.WriteLine($"{nome} está respirando!");
		}

		public void Comer(string racao)
		{
			Console.WriteLine($"{nome} está comendo {racao}!");
		}
		public void Correr(string local)
		{
			Console.WriteLine($"{nome} está correndo para {local}!");
		}

		public void Dormir(string horas)
		{
			Console.WriteLine($"{nome} está dormindo faz {horas} horas!");
		}
	}
}