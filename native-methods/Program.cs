using System;
using System.Collections.Generic;
using System.Linq;

namespace native_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VALORES SOLTOS

            int strFirst = 3;
            string strSecond = "Hello";
            string strThird = "a small string";
            int strFourth = 3;

            //ComparateTo() - Comparação 
            Console.WriteLine("CompareTo/Retorno do metodo: " + strFirst.CompareTo(strFourth));
            //Console result = 0

            //Equals - Compara se valores sao iguais independente se os tipos são diferentes ou não
            Console.WriteLine("Equals/Retorno do metodo: " + strFirst.Equals(strFourth));
            //Console result = true








            //LISTAS
            //List<int> list = new List<int>() = Define uma lista com valores de tipos diferentes ou iguais
            //int[,] numeros = new int[5,2] = Define uma lista que só pode conter valores 
            //OBS: Length não pega noList<>


            //var listaLivros = new List<Livro>();
            // Inicializa o objeto e o inclui na coleção
            // var livro1 = new Livro(1, "ASP, ADO e Banco de dados na web", "Macoratti", "8585943963");
            //listaLivros.Add(livro1);
            //var livro2 = new Livro(2, "ASP - Aprenda Rápido", "Macoratti", "8585845214");
            // listaLivros.Add(livro2);

            // Console.WriteLine(listaLivros);


            List<object> array = new List<object> { 1, 3, 5, 5, 5, 3, 5 };
            int[] arrayPPPP = new int[] { 3, 5, 7, 5, 65, 55 };
            int[] copia = new int[arrayPPPP.Length];
            int numero = 2;

            //IMPORTANTE //Index funcionou aqui
            for (int i = 0; i < arrayPPPP.Length; i++)
            {
                arrayPPPP[i] = i;
                Console.WriteLine(arrayPPPP);
            }

            //foreach (var pair in array.Select((x, i) => new { Index = i, Value = x }))
            //{
            //    Console.WriteLine(pair.Index);
            //}


            //CONTAINS / Funciona como um includes
            int valor = 5;
            var numeros = new List<int> { 4, 6, 56, 5, 4, 5, 65, 4, 6, 7, 7 };
            var resultado = numeros.Contains(valor);
            //Retorno: TRUE



            //WHERE / Funciona como Filter
            var artistas = new List<string> { "Bob Dylan", "Janis Japlin", "Gregg Allman", "Jim Morrison", "Madonna", "Jimmi Hendrix" };
            var nome = "Jim Morrison";
            var artistasComJ = artistas.Where((x) => x == nome).ToList();

            foreach (string item in artistasComJ)
            {
                Console.WriteLine(item);
            }


            //ACOPLANDO VALORES DE ARRAY DENTRO DE UMA LISTA
            string[] input = {"Brachiosaurus: Fraco",
            "Amargasaurus: Forte",
            "Mamenchisaurus: Forte" };

            var dinosaurs = new List<string>(input);


            var valval = "Brachiosaurus";
            var filt = dinosaurs.Where(x => x == valval).ToList();

            foreach (string i in dinosaurs)
            {
                Console.Write(i);
            }

            //SELECT / Funciona como map
            var numeros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var resultado2 = numeros2.Select(x => x * x);
            foreach (var n in resultado2)
                Console.WriteLine(n + " ");

            //FIRST
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54,
                    83, 23, 87, 435, 67, 12, 19 };

            var first = numbers.First(x => x < 10);

            Console.WriteLine(first);


            //ArrayPush / Funciona como push / Criado na outra classe
            string[] table = { "apple", "orange" };

            MethodsCreateds methodsCreateds = new MethodsCreateds();

            methodsCreateds.ArrayPush(ref table, "banana");
            Array.ForEach(table, x => Console.WriteLine(x));


        }
    }
}
