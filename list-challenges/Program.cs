using native_methods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace list_challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lstAluno = new List<Aluno>();

            lstAluno.Add(new Aluno { Nome = "Jose", Idade = 20 });
            lstAluno.Add(new Aluno { Nome = "Maria", Idade = 10 });
            lstAluno.Add(new Aluno { Nome = "Joao", Idade = 15 });

            for(int i = 0; i < lstAluno.Count; i++)
            {
                Console.WriteLine(lstAluno[i]);
            }
        }
    }
}
