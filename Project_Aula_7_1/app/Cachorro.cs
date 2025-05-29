using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7_1
{
	internal class Cachorro:Animal
	{
		public bool melhorAmigo;
		
		public void Latir()
		{
			if (melhorAmigo)
			{
				Console.WriteLine($"{nome} é o melhor amigo do homem!");
			}
			else
			{
				Console.WriteLine($"{nome} está latindo!");
			}
		}
	}
}