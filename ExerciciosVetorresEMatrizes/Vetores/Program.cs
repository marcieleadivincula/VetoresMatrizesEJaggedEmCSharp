using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início");

            //Uma Dimensão

            //definindo o tamanho e o operador new
            int[] numeros = new int[5] { 1, 2, 3, 4, 5 };

            string[] nomes = new string[3] { "Mac", "Jessica", "MiMi" };

            // omitindo o tamanho do array
            int[] numeros1 = new int[] { 1, 2, 3, 4, 5 };

            string[] nomes1 = new string[] { "Mac", "Jessica", "MiMi" };

            //Omitindo o operador new
            int[] numeros2 = { 1, 2, 3, 4, 5 };

            string[] nomes2 = { "Mac", "Jessica", "MiMi" };

            Console.WriteLine("Fim!!");
        }
    }
}
