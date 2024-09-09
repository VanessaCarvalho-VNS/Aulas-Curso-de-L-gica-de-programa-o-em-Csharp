using System;

namespace repetitivaPara
{
    class Program
    {
        static void Main(string[] args)
        {
            //int N, x, soma;

            //N = int.Parse(Console.ReadLine());

            //soma = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    x = int.Parse(Console.ReadLine());
            //    soma = soma + x;
            //}
            //Console.WriteLine(soma);

            //------------------------------------------------------//

            //int x, y, i;

            //x = 4;
            //y = x + 2;

            //for (i = 0; i < x; i++)
            //{
            //    Console.WriteLine(x+ " "+y);
            //    y = y + i;
            //}

            //----------------------------------------------------//

            //int y, i;

            //y = 10;

            //for(i = 1; i < 4; i++)
            //{
            //    Console.WriteLine(i);
            //    y = y + i;

            //    Console.WriteLine(y);
            //}

            //---------------------------------------------------//

            //int x, y, i;

            //x = 4;
            //y = 0;

            //for(i = 0; i < x;  i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(x);
            //    y = y + 10;
            //}

            //--------------------------------------------------//

            //int x, y, i;

            //x = 4;
            //y = 0;

            //for(i = 0; i < x; i++)
            //{
            //    y = y + i;
            //}

            //Console.WriteLine(y);

            //------------------------------------------------------//     

            //int x, y, i;

            //x = 8;
            //y = 3;

            //for(i = 0; y < x; i++)
            //{
            //    x = x - 2;
            //    y = y + 1;

            //    Console.WriteLine(i);
            //}

            //--------------------------------------------------//



            int x, y, i;

            x = 3;
            y = 0;

            for(i = 0; i < x; i++)
            {
                Console.WriteLine(i + ",");
                y = y + 5;
                Console.WriteLine(y);
            }
            Console.ReadLine();


        }
    }
}
