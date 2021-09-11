using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início");

            // Mais de uma Dimensão

            //definindo o tamanho e o operador new
            int[,] numeros = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            string[,] amigos = new string[2, 2] { { "Mac", "Jan" }, { "Mimi", "Jeff" } };

            //omitindo o tamanho do array
            int[,] numeros1 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            string[,] amigos1 = new string[,] { { "Mac", "Jan" }, { "Mimi", "Jeff" } };

            //Omitindo o operador new
            int[,] numeros2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            string[,] amigos2 = { { "Mac", "Jan" }, { "Mimi", "Jeff" } };

            Console.WriteLine("Fim!!");
        }
    }
}
