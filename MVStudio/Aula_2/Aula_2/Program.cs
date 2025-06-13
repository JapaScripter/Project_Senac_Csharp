using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var nota1 = 10;
            //var nota2 = 5.5;
            //var nota3 = 8.9;
            //var media = (nota1 + nota2 + nota3) / 3;

            //if (media >= 7)
            //{
            //    Console.WriteLine("Aluno aprovado com média: " + media);
            //}
            //else
            //{
            //    Console.WriteLine("Aluno reprovado com média: " + media);
            //}

            var level = 1;

            if (level <= 10)
            {
                Console.WriteLine("Você é um noob");
            }
            else if (level <= 20 & level > 10)
            {
                Console.WriteLine("Você é um amador");
            }
            else if (level <= 30 & level > 20)
            {
                Console.WriteLine("Você é um guerreiro");
            }
            else if (level <=40 & level > 30)
            {
                Console.WriteLine("Você é um mestre");
            }
        }
    }
}
