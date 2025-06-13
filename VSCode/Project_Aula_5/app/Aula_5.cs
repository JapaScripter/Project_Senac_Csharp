using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> lista = new List<string>();
			lista.Add("Ana");
			lista.Add("Bia");
			lista.Add("Julia");
			lista.AddRange("Marcia", "João", "Maria", "José\r\n");

			// Console.WriteLine(lista[2]);

			Console.WriteLine("Essa é a Lista Completa:\r\n");
			foreach (string nome in lista)
			{
				Console.WriteLine(nome);
			}

			string item_removido = lista[0];
			string item = lista[0];

			bool verificar = lista.Contains(item);

			if (verificar == true)
			{
				int pos = lista.IndexOf(item);
				Console.WriteLine($"O item {item} está na posição {pos}.");
				Console.WriteLine($"O item {item_removido} existe na lista.");
				Console.WriteLine($"O item {item_removido} foi removido.\r\n");
				lista.Remove(item);
				// lista.RemoveAt(0);
				// lista.RemoveRange(0, 2);
				// lista.Clear();
			}
			else
			{
				Console.WriteLine("O item não existe na lista.");
			}

			Console.WriteLine("Essa é a Lista Sem o Item Removido:\r\n");
			foreach (string nome in lista)
			{
				Console.WriteLine(nome);
			}

			List<string> listanova = lista.Where(x => x.StartsWith("a")).ToList();

			string listaInteira = "";
			foreach (string l in listanova)
			{
				listaInteira += l + "-";
				Console.WriteLine(l);
			}

			List<string> ListaCompleta = lista.Concat(listanova).ToList();

			Console.WriteLine("Essa é a Lista Completa Atualizada:\r\n");
			foreach (string l in ListaCompleta)
			{
				Console.WriteLine(l);
			}

		}
	}
}