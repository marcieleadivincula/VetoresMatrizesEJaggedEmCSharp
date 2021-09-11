using System;

namespace ExerciciosVetorresEMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início");

            //Declaração de arrays
            int[] array1 = new int[10];
            int[] numeros; // Vetor de inteiros
            string[] nomes; // Vetor de strings
            int[,] matriz2dimensoes;
            decimal[,,] matriz3dimensoes;
            int[][] vetorDeInteiros;
            float[][] vetorDeDecimais;

            //Inserção de dados no Array
            //Inicialização de vetor junto com a declaração
            int[] impares = new int[] { 1, 3, 5, 7, 9 }; //ou int[] impares = { 1, 3, 5, 7, 9 };
            int[] array2 = new int[5] { 1, 3, 7, 12, 8 };
            int[] array3 = { 1, 3, 2, 7, 6 };
            int[] array4 = new int[50];
            for (int j = 0; j < 50; j++)
            {
                array4[j] = j + 1;
            }
            //Inicialização de matriz junto com a declaração
            int[,] matriz = new int[,] { { 1, 2 }, { 3, 4 } }; //ou int[,] matriz = { { 1, 2 }, { 3, 4 } };
            //Inicialização de jagged array junto com a declaração
            int[][] jagged1 = new int[][]
            {
                new int[] {0,1,2,3},
                new int[] {4,5,6,7,8,9},
                new int[] {10,20,30,40}
            };
            //ou
            //int[][] jagged1 =
            //            {
            //    new int[] {0,1,2,3},
            //    new int[] {4,5,6,7,8,9},
            //    new int[] {10,20,30,40}
            //};
            //Inicializando elementos de um vetor individualmente
            int[] vetor = new int[3];
            vetor[0] = 10;
            vetor[1] = 25;
            vetor[2] = 99;
            //Inicializando elementos de uma matriz individualmente
            string[,] names;
            int[,] array = new int[2, 2];
            string[,] matrizLing = new string[2, 2];
            matrizLing[0, 0] = "C#";
            matrizLing[0, 1] = "Delphi";
            matrizLing[1, 0] = "Java";
            matrizLing[1, 1] = "VB.NET";
            //Inicialização dos elementos de um jagged array(Array-of-arrays (jagged)) inividualmente
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 0, 1, 2, 3 };
            jagged[1] = new int[] { 4, 5, 6, 7, 8, 9 };
            jagged[2] = new int[] { 10, 20 };
            byte[][] resultados;
            int[][] numArray = new int[][] { new int[] { 1, 3, 5 }, new int[] { 2, 4, 6, 8, 10 } };


            //Acesso aos dados do array
            Console.WriteLine(array1[10]);


            //Iterações sobre os arrays
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array1[i]);
            }

            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(array1[k]);
                k++;
            }

            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }


            //Exemplo prático
            string[] pilotos = new string[4] { "Ayrton Senna", "Michael Schumacher", "Lewis Hamilton", "Alain Prost" };
            Console.WriteLine(pilotos[3]);
            Console.WriteLine();
            pilotos[3] = "Rubens Barrichello";
            foreach (string piloto in pilotos)
            {
                Console.WriteLine(piloto);
            }
            // Exemplo prático com vetor
            int[] valores = new int[10];
            decimal soma = 0, media = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Format("Informe o elemento de índice {0}:", i));
                valores[i] = int.Parse(Console.ReadLine());
                soma += valores[i];
            }
            media = soma / 10;
            for (int i = 0; i < 10; i++)
            {
                if (valores[i] < media)
                    Console.WriteLine(String.Format("O elemento de índice {0}, cujo valor é {1}, está abaixo da média.", i, valores[i]));
            }
            // Exemplo prático com matrizes
            int[,] bingo = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(String.Format("Informe o elemento ({0},{1})", i, j));
                    bingo[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Exemplo prático com array jagged
            Console.WriteLine("Informe o número de turmas: ");
            int num_turmas = int.Parse(Console.ReadLine());
            string[][] turmas = new string[num_turmas][];
            for (int i = 0; i < num_turmas; i++)
            {
                Console.WriteLine("Informe a quantidade de alunos da turma {0}:", i);
                int num_alunos = int.Parse(Console.ReadLine());
                turmas[i] = new string[num_alunos];
                for (int j = 0; j < num_alunos; j++)
                {
                    Console.WriteLine("Informe o nome do aluno {0}:", j);
                    turmas[i][j] = Console.ReadLine();
                }
            }

            int[,] matriz3x3 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            //string[][] cesta = new string[][]
            //{
            //    {"Pera","100" },
            //    {"Jaca", "200" },
            //    {"Maçã", "900" },
            //    {"Uva", "89" }
            //};

            //Console.WriteLine("Produto: " + cesta[0][0]);
            //Console.WriteLine("Quantidade: " + cesta[0][1]);

            Console.WriteLine("Fim!!");
        }
    }
}
