using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um algoritmo que leia os valores de 10 posições e exiba o vetor e sua última
                posição multiplicada por 5.            
            */

            double[] valores = new double[10];

            for(int i = 0; i<= 9; i++){
                Console.Write("Digite um valor : ");
                valores[i] = double.Parse( Console.ReadLine() );
            }

            Console.WriteLine(valores[9] * 5);


        }
    }
}
