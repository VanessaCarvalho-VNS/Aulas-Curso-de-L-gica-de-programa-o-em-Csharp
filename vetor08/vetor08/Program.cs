using System;
using System.Globalization;

namespace vetor08
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] sexo = new char[N];

            for (int  i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                alturas[i] = double.Parse(valores[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(valores[1]);
            }

            //1: Menor Altura

            double menorAltura = alturas[0];
            for (int i = 0; i < N; i++)
            {
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
            }

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InstalledUICulture));

            //2: maior altura
            double maioraltura = alturas[0];
            for (int i = 0; i < N; i++)
            {
                if (alturas[i] > maioraltura)
                {
                    maioraltura = alturas[i];
                }
            }

            Console.WriteLine("Maior altura = " + maioraltura.ToString("F2", CultureInfo.InvariantCulture));

            //3: altura media das mulhres

            double somaDasAlturasDasMulheres = 0.0;
            int contMulheres = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'F')
                {
                    somaDasAlturasDasMulheres = somaDasAlturasDasMulheres + alturas[i];
                    contMulheres++;
                }
            }

            if (contMulheres == 0)
            {
                Console.WriteLine("Não ha nenhuma mulher debtre as pessoas");
            }
            else
            {
                double media = somaDasAlturasDasMulheres / contMulheres;
                Console.WriteLine("Media das alturas das Mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }

            //4: numeros de homens

            int contHomens = 0;
            for (int i = 0; i < N; i++)
            {
                if (sexo[i] == 'M')
                {
                    contHomens++;
                }
            }

            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}