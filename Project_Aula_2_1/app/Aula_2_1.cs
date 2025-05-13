using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			// string login = "admin";
			// string senha = "admin";

			// string login_bd = "admin";
			// string senha_bd = "admin";

			// if (login == login_bd)
			// {
			// 	if (senha == senha_bd)
			// 	{
			// 		Console.WriteLine("Login realizado com sucesso!");
			// 	}
			// 	else
			// 	{
			// 		Console.WriteLine("Senha incorreta!");
			// 	}
			// }
			// else
			// {
			// 	Console.WriteLine("Login incorreto!");
			// }

			// if (login == login_bd & senha == senha_bd)
			// {
			// 	Console.WriteLine("Login realizado com sucesso!");
			// }
			// else
			// {
			// 	Console.WriteLine("Login ou senha incorretos!");
			// }

			// float dinheiro = 1000.58f;
			// float cartao = 1500.36f;
			// float compra = 2000.00f;

			// if (dinheiro >= compra || cartao >= compra)
			// {
			// 	Console.WriteLine("Compra aprovada!");
			// }
			// else if ((dinheiro + cartao) >= compra)
			// {
			// 	Console.WriteLine("Compra aprovada parte no cartão, parte no dinheiro!");
			// }
			// else
			// {
			// 	Console.WriteLine("Compra negada!");
			// }

			// string email_user = "admin@admin.com";

			// // if (email_user != "") //Utilizando o operador de negação
			// if (!(email_user  == "")) //Utilizando o operador de negação
			// {
			// 	Console.WriteLine("Email " + email_user + " cadastrado com sucesso!");
			// }

			string tipo_game = "FPS";

			switch (tipo_game)
			{
				case "FPS":
					Console.WriteLine("Jogo de tiro em primeira pessoa");
					break;
				case "RPG":
					Console.WriteLine("Jogo de RPG");
					break;
				case "MOBA":
					Console.WriteLine("Jogo de MOBA");
					break;
				default:
					Console.WriteLine("Tipo de jogo não encontrado!");
					break;
			}

		}
	}
}
