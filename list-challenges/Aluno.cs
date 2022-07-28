using System;

namespace native_methods
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Modelo { get; set;}
        public string Marca { get; set; }
        public double Preco { get; set; }


        public override string ToString()
        {
            return "Id: " + Id + "   Modelo: " + Modelo + "   Marca: " + Marca + "   Preco: " + Preco;
        }


        public bool VerifyWhereLinq(object linqWhere)
        {
            if (linqWhere is null)
            {
                Console.WriteLine("Pair is null"); ;
                return false;
            }
            Console.WriteLine(linqWhere);
            return true;
        }
    }
}