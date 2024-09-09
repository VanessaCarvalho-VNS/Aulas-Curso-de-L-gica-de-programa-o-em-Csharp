using System;
using System.Globalization;

namespace URI1003
{
    class Program
    {
        static void Main(string[] args)
        {
            //URI-1003

            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);

            Console.ReadLine();

        }
    }
}