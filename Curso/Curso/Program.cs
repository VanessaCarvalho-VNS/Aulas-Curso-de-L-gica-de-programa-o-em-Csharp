using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex: Entrada de Dados

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();



            //string[] v = Console.ReadLine().Split(' ');
            //string p1 = v[0];
            //string p2 = v[1];
            //string p3 = v[2];


            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3);

            //----------------------------------------------------------

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            //Console.WriteLine("Você Digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            // Exercicio Proposto 

            //string nome = Console.ReadLine();
            //int quarto = int.Parse(Console.ReadLine());
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] vet = Console.ReadLine().Split(' ');
            //string n = vet[0];
            //int idade = int.Parse(vet[1]);  
            //double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);   



            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();


            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            Console.WriteLine("Entre com seu nome, idade e altura: ");

            string[] vet = Console.ReadLine().Split(' ');

            string n = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(n);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            
        }
    }
}

