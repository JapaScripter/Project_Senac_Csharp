using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Aula_7_1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"======================");
			Cachorro cachorro1 = new Cachorro();
			cachorro1.nome = "Buddy";
			cachorro1.sexo = 'm';
			cachorro1.idade = 3;
			cachorro1.peso = 15.0;
			cachorro1.cor = "Marrom";
			cachorro1.melhorAmigo = true;
			cachorro1.Respirar();
			cachorro1.Comer("ração de carne");
			cachorro1.Correr("quintal");
			cachorro1.Dormir("6");
			cachorro1.Latir();
			Console.WriteLine($"O nome do primieiro cachorro é {cachorro1.nome}, ele tem {cachorro1.idade} anos, pesa {cachorro1.peso} kg e é da cor {cachorro1.cor}.");
			Console.WriteLine($"======================");
			Gato gato1 = new Gato();
			gato1.nome = "Mia";
			gato1.sexo = 'f';
			gato1.idade = 2;
			gato1.peso = 4.5;
			gato1.cor = "Laranjado";
			gato1.brincalhao = true;
			gato1.Respirar();
			gato1.Comer("ração de frango");
			gato1.Correr("telhado");
			gato1.Dormir("10");
			gato1.Miar();
			Console.WriteLine($"O nome do primeiro gato é {gato1.nome}, ele tem {gato1.idade} anos, pesa {gato1.peso} kg e é da cor {gato1.cor}.");
			Console.WriteLine($"======================");
		}
	}
}