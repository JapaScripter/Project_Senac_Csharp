using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro();
            car1.cor = "vermelho";
            car1.portas = 4;
            car1.potencia = 300.89;

            car1.Ligar();
        }
    }
}
