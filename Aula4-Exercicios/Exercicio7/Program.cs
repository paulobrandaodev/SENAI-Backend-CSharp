using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um algoritmo que leia os valores de um vetor de 10 posições e que apresente o
                maior valor digitado e em qual posição ele se encontra.
            */

            double maior  = 0;
            double indice = 0;

            double[] vetor = new double[10];

            for(int i = 0; i <= 9; i++){
                Console.Write("Digite um numero: ");
                vetor[i] = double.Parse(Console.ReadLine());

                if(vetor[i] > maior){
                    maior  = vetor[i];
                    indice = i;
                }

            }

            Console.WriteLine($"Maior: {maior} , Indice: {indice}");


        }
    }
}
