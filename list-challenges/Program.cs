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
            List<Aluno> lstAluno  = new List<Aluno>();

            lstAluno.Add(new Aluno() {Id = 1, Modelo = "Corsa", Marca = "Chevrolet", Preco = 29000});
            lstAluno.Add(new Aluno() { Id = 2, Modelo = "Punto", Marca = "Fiat", Preco = 34000 });
            lstAluno.Add(new Aluno() { Id = 3, Modelo = "Gol", Marca = "Volkswagen", Preco =23000 });
            lstAluno.Add(new Aluno() { Id = 4, Modelo = "Saveiro", Marca = "Volkswagen", Preco = 26000 });
            lstAluno.Add(new Aluno() { Id = 5, Modelo = "Uno", Marca = "Fiat", Preco = 16000 });
            lstAluno.Add(new Aluno() { Id = 6, Modelo = "Velar", Marca = "Landrover", Preco =455000 });



            string value = "Gol";


            //SELECT = retorna ture ou false
            foreach (var pair in lstAluno.Select((x, i) => new { Index = i, Value = x }))
            {
                //Console.WriteLine(pair.Value.Modelo == value); 
            }

            var filt = lstAluno.Where(x => x.Modelo == value).Count();
             
            //WHERE = retorna o valor jun
             if (filt == 0)
            {
                Console.WriteLine("Filt is not exists");
            }
             else
            {
                var list = lstAluno.Where(x => x.Modelo == value);
                foreach(var item in list)
                    Console.WriteLine(item);
            }




        }
    }
}
