using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Jorge", 20, 1.60, 60.1);
            Aluno aluno2 = new Aluno("Daniel", 38, 1.78, 80);
            aluno1.falar();
            aluno1.comer();
            aluno2.falar();
            aluno2.comer();
        }
    }
}
