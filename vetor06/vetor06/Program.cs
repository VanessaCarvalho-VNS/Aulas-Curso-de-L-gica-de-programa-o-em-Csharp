using System;
using System.Globalization;

namespace vetor06
{
    class Program
    {
        static void Main(string[] args)
        {
            ;
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                idades[i] = int.Parse(valores[1]);
               
            }

            //1: primeiro vamos encontrar a posicao de maior idade
            int maiorIdade = idades[0];
            int posicaoMaoirIdade = 0;

            for (int i = 0; i < N; i++)
            {
                if (idades[i] > maiorIdade)
                {
                    maiorIdade = idades[i];
                    posicaoMaoirIdade = i;
                }
            }

            //2: agora vamos acessar o vetor de nomes na posicao de maior idade

            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaoirIdade]);

            

           
        }
    }
}   



    

