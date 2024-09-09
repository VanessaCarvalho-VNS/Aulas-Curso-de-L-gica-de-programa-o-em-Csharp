using System;
using System.Globalization;

namespace URI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            //URI-1002

            double Raio, Area, pi = 3.14159;

            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = pi * Raio * Raio;

            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}