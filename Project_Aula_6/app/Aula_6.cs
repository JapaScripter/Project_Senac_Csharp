using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
	class Program : Carro
	{
		static void Main(string[] args)
		{
			Carro car1 = new Carro();
			// car1.marca = "Fiat";
			car1.modelo = "Uno";
			car1.velocidade = 300;
			car1.ligado = true;
			// car1.ligar();
			// car1.acelerar();
			// car1.frear();
			// car1.desligar();
			Console.WriteLine(car1.getMarca());

			// Console.ReadKey();
		}
		
	}
}