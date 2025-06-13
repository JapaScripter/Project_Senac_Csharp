using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 10;
            int valor2 = 20;
            int resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma de valor1 e valor2 é: {resultado}");

            string aluno = "Fábio";
            float nota1 = 1.0f;
            float nota2 = 10.0f;
            float nota3 = 7.0f;
            float media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"A média final do aluno {aluno} é {media}");

            double carteira = 10.34; Console.WriteLine(carteira);
            carteira++; Console.WriteLine(carteira);
            carteira--; Console.WriteLine(carteira);
            carteira += 10;

            float maior = 10.0f;
            float menor = 1.0f;
            bool result = maior > menor;
            Console.WriteLine($"O result é = {result}");
        }
    }
}
