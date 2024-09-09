using System;
using System.Globalization;

namespace vetor05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            string[] valores = Console.ReadLine().Split(' ');
            for (int i = 0; 
                i < N; i++)
            {
                vet[i] = double.Parse(valores[i]);
            }

            double somaDosPares = 0.0;
            int quantidadeDosPares = 0;
            for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    somaDosPares = somaDosPares + vet[i];
                    quantidadeDosPares++;
                }
            }

            if (quantidadeDosPares == 0)
            {
                Console.WriteLine("Não havia nenhum numero par");
            }
            else
            {
                double media = somaDosPares / quantidadeDosPares;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}