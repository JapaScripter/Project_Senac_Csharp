using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string login = "admin";
            //string password = "admin";

            //string login_bd = "admin";
            //string password_bd = "admin";

            //if (login == login_bd)
            //{
            //    if (password == password_bd)
            //    {
            //        Console.WriteLine("Login realizado com sucesso");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A senha está incorreta");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("O login está errado!");
            //}

            //if (login == login_bd & password == password_bd)
            //{
            //    Console.WriteLine("Login realizado com sucesso!");
            //}
            //else
            //{
            //    Console.WriteLine("Login ou Senha errados!");
            //}

            //float dinheiro = 1000.58f;
            //float cartao = 1500.36f;
            //float compra = 2000.00f;

            //if (dinheiro >= compra || cartao >= compra)
            //{
            //    Console.WriteLine("Compra aprovada");
            //}
            //else if ((cartao + dinheiro) >= compra)
            //{
            //    Console.WriteLine("Compra aprovada parte no cartão, parte no dinheiro");
            //}
            //else
            //{
            //    Console.WriteLine("Compra negada");
            //}

            //string email_user = "admin@admin.com";

            //if (email_user != "")
            //{
            //    Console.WriteLine("Email " + email_user + " cadastrado com sucesso!");
            //}

            string tipo_game = "FPS";

            switch (tipo_game)
            {
                case "FPS":
                    Console.WriteLine("É um jogo de FPS");
                    break;
                case "RPG":
                    Console.WriteLine("É um jogo de RPG");
                    break;
                case "MOBA":
                    Console.WriteLine("É um jogo de MOBA");
                    break;
                default:
                    Console.WriteLine("Nenhum desses tipos");
                    break;
            }
        }
    }
}
