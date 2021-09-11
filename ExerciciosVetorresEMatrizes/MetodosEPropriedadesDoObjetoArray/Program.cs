using System;

namespace MetodosEPropriedadesDoObjetoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início");

            string[] Cores = { "vermelho", "verde", "amarelo", "laranja", "azul" };
            //A classe Array fornece propriedades e métodos para criar, manipular, procurar e ordenar arrays. Abaixo temos os mais importantes:
            //1 - Propriedades
            //IsFixedSize: Retorna um valor indicando se um array possui um tamanho fixo ou não.
            if (Cores.IsFixedSize) //Verificando se o Array tem tamanho fixo
            {
                //listBox2.Items.Add("O array e fixo");

                //listBox2.Items.Add(" tamanho => (Cores.Lenght) = " + Cores.Length);

                //listBox2.Items.Add(" intervalo => (Cores.Rank) = " + Cores.Rank);
            }

            //IsReadOnly: Retorna um a valor indicando se um array é somente - leitura ou não.

            //IsSynchronized: Retorna um a valor que indica se o acesso a um array é thread - safe ou não.

            //Length: Retorna o número total de itens em todas as dimensões de um array
            Console.WriteLine(Cores.Length); //Obter o tamanho do Array

            //Rank: Retorna o número de dimensões de um array

            //SyncRoot: Retorna um objeto que pode ser usado para sincronizar o acesso a um array.


            //2- Métodos
            //BinarySearch: Procura em um array unidimensional ordenado por um valor usando o algoritmo de busca binário.
            object oCor = "verde";
            int retorno = Array.BinarySearch(Cores, oCor); //Realizando uma busca binária no Array
            if (retorno >= 0)
            {
                //listBox2.Items.Add("Indice do Item " + retorno.ToString());
            }
            else
            {
                //listBox2.Items.Add("Item nÆo localizado");
            }

            //Clear: Remove todos os itens de um array e define um intervalo de itens no array com valor zero.

            //Clone: Cria uma cópia do Array.

            //Copy: Copia uma seção de um array para outro array e realiza a conversão de tipos e boxing requeridas.

            //CopyTo: Copia todos os elementos do array unidimensional atual para o array unidimensional especificado iniciando no índice de destino especificado do array.

            //CreateInstance: Inicializa uma nova instância da classe Array.

            //GetEnumerator: Retorna um IEnumerator para o Array.

            //GetLength: Retorna o número de itens de um Array.

            //GetLowerBound: Retorna o primeiro item de um Array.
            //GetUpperBound: Retorna o último item de um Array.
            for (int j = Cores.GetLowerBound(0); j <= Cores.GetUpperBound(0); j++)//Usar GetLowerBound/GetUpperBound
            {
                //listBox2.Items.Add("Cores[0] = " + j + " " + Cores[j]);
            }

            //GetValue: Retorna o valor do item especificado no  Array.

            //IndexOf: Retorna o índice da primeira ocorrência de um valor em um array de uma dimensão ou em uma porção do Array.
            int ind = Array.IndexOf(Cores, "verde"); //Obtendo o índice de um item do Array
            //listBox2.Items.Add("O índice do item 'verde' e " + ind);

            //LastIndexOf: Retorna o índice da última ocorrência de um valor em um array unidimensional ou em uma  porção do Array.

            //Reverse: Reverte a ordem de um item em um array de uma dimensão ou parte do array.
            Array.Reverse(Cores); //Inverter a ordem dos itens no Array

            //SetValue: Define o item especificado em um array atual para o valor definido.

            //Sort: Ordena os itens de um array.
            Array.Sort(Cores); //Ordenar o Array

            Console.WriteLine("Fim!!");

        }
    }
}
