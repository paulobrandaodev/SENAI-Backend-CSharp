using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um algoritmo que gere um vetor de 10 posições sendo que seu conteúdo seja o
                dobro de seu próprio índice.
            */

            int[] vetor = new int[10];

            for(int i= 1; i <= 9; i++){
                vetor[i] = i * 2;
            }

            for(int i= 1; i <= 9; i++){
                Console.WriteLine(vetor[i]);
            }

        }
    }
}
