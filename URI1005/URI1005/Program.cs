using System;
using System.Globalization;


namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            // URI-1005

            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }

}