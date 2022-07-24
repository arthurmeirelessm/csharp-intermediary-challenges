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
            for( int i = 0; i < arrayPPPP.Length; i++ )
            {
                arrayPPPP[i] = i;
                Console.WriteLine(arrayPPPP);
            }

            //foreach (var pair in array.Select((x, i) => new { Index = i, Value = x }))
            //{
            //    Console.WriteLine(pair.Index);
            //}


            //CONTAINS
            int valor = 5;
            var numeros = new List<int> { 4, 6, 56,5,4, 5, 65, 4,6, 7, 7};
            var resultado = numeros.Contains(valor);
            //Retorno: TRUE

            Console.WriteLine(resultado);
            foreach(int item in numeros)
            {
                numeros.Add(item);
                Console.WriteLine(numeros);
                Console.WriteLine("dgfbfb");
            }
        }
    }
}
