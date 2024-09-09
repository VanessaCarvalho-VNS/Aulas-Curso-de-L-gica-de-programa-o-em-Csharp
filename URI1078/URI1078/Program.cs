using System;

namespace URI1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for(int i = 1;  i <= 10; i++)
            {
                int resultado = N * i;
                Console.WriteLine(N + " x " + i + " = " + resultado);

            }

            Console.ReadLine();
        }
    }
}