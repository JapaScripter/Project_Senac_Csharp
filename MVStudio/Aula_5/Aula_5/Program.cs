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
            lista.Add("Juricleo");
            lista.Add("Amanda");
            lista.Add("Marcio");
            lista.Add("Lucas");
            lista.Add("Almeida");
            lista.Add("Ricardo");
            //lista.AddRange("Marcia", "João", "Maria", "José");

            //string item = lista[0];
            //int pos = lista.IndexOf(item);
            //Console.WriteLine(pos);

            //Console.WriteLine(lista[2]);

            Console.WriteLine("Essa é a lista completa inicial: \r\n");
            foreach (string nome in lista)
            {
                Console.WriteLine(nome);
            }

            string item_removido = lista[0];
            lista.Remove("Juricleo");
            Console.WriteLine("\r\n O item removido foi: " + item_removido + "\r\n");

            Console.WriteLine("Essa é a lista sem o item que foi removido: \r\n");
            foreach (string nome in lista)
            {
                Console.WriteLine(nome);
            }

            List<string> novalista = lista.Where(x => x.StartsWith("A")).ToList();

            string listaInteira = "";
            foreach (string l in novalista)
            {
                listaInteira += l + "-";
                Console.WriteLine(l);
            }

            List<string> join = lista.Concat(novalista).ToList();

            Console.WriteLine("\r\nEssa é a lista completa atualizada: \r\n");
            foreach (string l in join)
            {  
                Console.WriteLine(l);
            }
        }
    }
}
