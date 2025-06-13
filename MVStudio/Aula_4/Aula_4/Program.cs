using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] pessoas = { "Fábio", "Egon", "Ricardo", "Yuri" };

            //Console.WriteLine($"Pessoa 1: { pessoas[0]}");
            //Console.WriteLine($"Pessoa 2: { pessoas[0]}");
            //Console.WriteLine($"Pessoa 3: { pessoas[0]}");

            //for (int i = 0; i < pessoas.Length; i++)
            //{
            //    Console.WriteLine( pessoas[i] );
            //}

            //foreach (string pessoa in pessoas)
            //{
            //    Console.WriteLine( pessoa );
            //}

            string[,] cadastro =
            {
                { "C#", "Julio", "julio@gmail.com" },
                { "C#", "Ester", "ester@gmail.com" },
                { "C#", "Joyce", "joyce@gmail.com" },
                { "C#", "Seth", "seth@gmail.com" },
            };

            //Console.WriteLine(cadastro[0, 0]);

            for (int i = 0; i < cadastro.GetLength(0); i++)
            {
                for (int x = 0; x < cadastro.GetLength(1); x++)
                {
                    Console.WriteLine(cadastro[i,x]);
                }
            }
        }
    }
}
