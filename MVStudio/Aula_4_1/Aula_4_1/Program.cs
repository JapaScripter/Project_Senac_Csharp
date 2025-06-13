using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> info = new List<int>();
            //info.Add(30);
            //info.Add(20);
            //Console.WriteLine("A idade selecionada é: " + info[0]);

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine($"Digite o {i + 1}° número a ser somado: ");
                int num = Convert.ToInt32( Console.ReadLine() );
                info.Add(num);
                i++;
            }

            for (int j = 0; j < info.Count; j++)
            {
                Console.WriteLine(info[j]);
                int b = i + j;
                Console.WriteLine(b);
            }
        }
    }
}
