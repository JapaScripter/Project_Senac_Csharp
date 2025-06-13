using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "Yuri";
            int idade = 27;

            Console.WriteLine("Olá, " + user + " e você tem " + idade.ToString() + " anos.");

            float peso = 60.0f;

            Console.WriteLine($"Seu peso é {peso} kg.");

            bool cadastrado = false;
            string status = "";

            if (cadastrado == false)
            {
                status = "Não está cadastrado";
            }
            else
            {
                status = "Está cadastrado";
            }

            Console.WriteLine($"O usuário está cadastrado? {status}");

            Console.ReadKey();
        }
    }
}
