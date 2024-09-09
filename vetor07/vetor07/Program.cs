using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace vetor07
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] notaSemestre1 = new double[N];
            double[] notaSemestre2 = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                nomes[i] = valores[0];
                notaSemestre1[i] = double.Parse(valores[1], CultureInfo.InvariantCulture);
                notaSemestre2[i] = double.Parse(valores[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados");
            for (int i = 0; i < N; i++)
            {
                double media = (notaSemestre1[i] + notaSemestre2[i]) / 2.0;
                if (media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}