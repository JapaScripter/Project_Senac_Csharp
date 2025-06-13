using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Aula_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Aluno("Yuri", 27);
            Program.Aluno("Fabio", 40);
            Program.Valores(29.23123123,13.3123123123);
            Program.Verificar(30);
            Program.Media(5.6, 8.9, 3.9);
        }

        static void Aluno(string nome, int idade)
        {
            Console.WriteLine($"O nome do aluno é: {nome}, e a idade dele é: {idade}\r\n");
        }

        static void Valores(double valor1, double valor2)
        {
            double resultado = valor1 + valor2;
            Console.WriteLine($"{valor1} + {valor2} = " + resultado + "\r\n");
        }

        static bool Verificar (int idade)
        {
            if (idade >= 18)
            {
                Console.WriteLine("A pessoa é maior de idade!\r\n");
                return true;
            }
            else
            {
                Console.WriteLine("A pessoa é menor de idade!\r\n");
                return false;
            }
        }

        static bool Media (double nota1, double nota2, double nota3)
        {
            double resultadomedia = (nota1 + nota2 + nota3) / 3;
            if (resultadomedia >= 7)
            {
                Console.WriteLine($"nota1 + nota2 + nota3 = " + resultadomedia + " o aluno passou de ano!\r\n");
                return true;
            }
            else
            {
                Console.WriteLine($"nota1 + nota2 + nota3 = " + resultadomedia + " o aluno não passou de ano!\r\n");
                return false;
            }
        }
    }
}
