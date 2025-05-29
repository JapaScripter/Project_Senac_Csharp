using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_1
{
	internal class Aluno : Pessoa
	{
		public int ra;

		public Aluno(string nome, int idade)
		{	
			this.nome = nome;
			this.idade = idade;
		}

		public Aluno(string nome, int idade, double altura, double peso, int ra)
		{
			this.nome = nome;
			this.idade = idade;
			this.altura = altura;
			this.peso = peso;
			this.ra = ra;
		}
		public void Mensagem(string msg)
		{
			Console.WriteLine($"O aluno {nome} tem um dúvida sobre: {msg}");
		}
	}
}