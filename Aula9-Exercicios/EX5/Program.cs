using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = { 9.8, 6.0, 5.4};
            Console.WriteLine( Soma(vetor) );
        }

        static double Soma(double[] numeros){

            double soma = 0;

            foreach (double numero in numeros)
            {
                soma += numero;
            }

            return soma;
        }

    }
}
