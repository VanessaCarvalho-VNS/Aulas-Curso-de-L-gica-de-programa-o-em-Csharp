using System;
using System.Runtime.Serialization;

namespace URI1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, min, max, soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y){
                min = X;
                max = Y;
            }
            else
            {
                min = Y;
                max = X;
            }

            soma = 0;
            for (int i=min+1; i<max; i++) {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);

            Console.ReadLine();
        }
    }
}