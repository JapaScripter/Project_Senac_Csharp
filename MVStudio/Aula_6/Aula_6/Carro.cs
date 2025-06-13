using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6
{
    internal class Carro
    {
        private string marca;
        public string modelo;
        public int velocidade;
        public bool ligado;

        public void ligar()
        {
            if (ligado)
            {
                Console.WriteLine("Já está ligado");
            }
            else
            {
                ligado = true;
                Console.WriteLine("Agora está ligado");
            }
        }

        public void desligar()
        {
            if (!ligado)
            {
                Console.WriteLine("Já está desligado");
            }
            else
            {
                ligado = false;
                Console.WriteLine("Agora está desligado");
            }
        }

        public void acelerar()
        {
            if(ligado)
            {
                velocidade += 10;
                Console.WriteLine($"Acelerando a {velocidade} km/h");
            }
            else
            {
                Console.WriteLine("Liga o carro primeiro");
            }
        }

        public void frear()
        {
            if(velocidade > 0)
            {
                velocidade -= 10;
                Console.WriteLine($"Freando a {velocidade} km/h");
            }
            else
            {
                Console.WriteLine("O carro está parado.");
            }
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca()
        {
            return this.marca;
        }
    }
}

    
