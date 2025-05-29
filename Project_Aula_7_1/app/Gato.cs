using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7_1
{
	internal class Gato : Animal
	{
		public bool brincalhao;
		
		public void Miar()
		{
			if(brincalhao)
			{
				Console.WriteLine($"{nome} está brincando!");
			}
			else
			{
				Console.WriteLine($"{nome} está miando!");
			}
		}
	}
}