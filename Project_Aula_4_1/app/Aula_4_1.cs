using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Aula_4_1
{
	internal class Aula_4_1
	{

		static void Main(string[] args)
		{
			List<int> info = new List<int>();
			// info.Add(25);
			// info.Add(30);
			// Console.WriteLine("A idade é: " + info[0]);

			int i = 0;
			while (i < 5)
			{
				Console.WriteLine($"Digite o {i + 1}° numero que você quer somar: ");
				int num = Convert.ToInt32(Console.ReadLine());
				info.Add(num);
				i++;

				for (int j = 0; j < info.Count; j++)
				{
					Console.WriteLine(info[j]);
				}	
			}
		}
	}
}