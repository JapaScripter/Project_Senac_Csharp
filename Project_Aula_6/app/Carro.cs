using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
	internal class Carro
	{
		private string marca;
		public string modelo;
		public int velocidade;
		public bool ligado;

		public void ligar()
		{
			if (ligado)
			{
				Console.WriteLine("O carro já está ligado.");
			}
			else
			{
				ligado = true;
				Console.WriteLine("Agora foi ligado.");
			}
		}
		public void desligar()
		{
			if (!ligado)
			{
				Console.WriteLine("O carro já está desligado.");
			}
			else
			{
				ligado = false;
				Console.WriteLine("Agora foi desligado.");
			}
		}

		public void acelerar()
		{
			if (ligado)
			{
				velocidade += 10;
				Console.WriteLine($"Acelerando a {velocidade} km/h");
			}
			else
			{

				Console.WriteLine("O carro está desligado. Ligue-o primeiro.");
			}
		}

		public void frear()
		{
			if (ligado)
			{
				if (velocidade > 0)
				{
					velocidade = velocidade * 0;
					Console.WriteLine($"A velocidade foi para {velocidade} km/h o carro está parado.");
				}
				else
				{
					Console.WriteLine("O carro já está parado.");
				}
			}
		}

		public void setMarca(string marca)
		{
			this.marca = marca;
		}
		public string getMarca()
		{
			return this.marca;
		}
	}
}