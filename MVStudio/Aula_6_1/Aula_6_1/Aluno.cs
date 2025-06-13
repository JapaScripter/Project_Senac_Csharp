using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Aula_6_1
{
    internal class Aluno:Pessoa
    {
        public int ra;

        public Aluno(string nome_p, int idade_p)
        {
            this.nome = nome_p;
            this.idade = idade_p;
        }

        public Aluno(string nome, int idade, double altura, double peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine($"O aluno {nome} está com dúvida sobre: {msg}");
        }
    }
}
