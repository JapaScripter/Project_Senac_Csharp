using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato();
            gato1.nome = "KittyKat";
            gato1.sexo = 'f';
            gato1.idade = 7;
            gato1.peso = 10;
            gato1.cor = "Laranjado";
            gato1.Respirar();
            gato1.Comer("Raçao de Frango");
            gato1.Correr("Telhado");
            gato1.Dormir("8");
            Console.WriteLine($"A {gato1.nome}, tem {gato1.idade} anos de idade, pesa {gato1.peso}kg e tem a cor {gato1.cor}");
            Console.WriteLine("=================");
            Cachorro cachorro1 = new Cachorro();
            cachorro1.nome = "Kira";
            cachorro1.sexo = 'f';
            cachorro1.idade = 11;
            cachorro1.peso = 45;
            cachorro1.cor = "Preto";
            cachorro1.Respirar();
            cachorro1.Comer("Ração de Carner");
            cachorro1.Correr("Parque");
            cachorro1.Dormir("5");
            Console.WriteLine($"A {cachorro1.nome}, tem {cachorro1.idade} anos de idade, pesa {cachorro1.peso}kg e tem a cor {cachorro1.cor}");
            Console.WriteLine("=================");
        }
    }
}
