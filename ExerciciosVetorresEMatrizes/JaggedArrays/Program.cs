using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início!!");

            // Arrays de Arrays (jagged arrays)

            //definindo o tamanho e o operador new
            int[][] numeros = new int[2][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };

            //omitindo o tamanho do array
            int[][] numeros1 = new int[][] { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };
            //ou
            int[][] numeros2 = { new int[] { 2, 3, 4 }, new int[] { 5, 6, 7, 8, 9 } };

            Console.WriteLine("Fim!!");
        }
    }
}
