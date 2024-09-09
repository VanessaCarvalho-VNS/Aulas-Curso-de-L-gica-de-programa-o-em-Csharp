using System;
using System.Diagnostics;

namespace matriz01
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            int[,] mat;

            string[] valores = Console.ReadLine().Split(' ');
            M = int.Parse(valores[0]);
            N = int.Parse(valores[1]);
            mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
                
            }

            Console.WriteLine("VALORES NEGATIVOS: ");
            for (int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }
            }
           
        }
    }
}
