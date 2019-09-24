using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um algoritmo que leia os valores de dois vetores de 10 posições gere um terceiro
                vetor de 20 posições que seja a união dos dois primeiros.
            */
            double[] vetor1 = new double[10];
            double[] vetor2 = new double[10];
            double[] vetor3 = new double[20];


            for(int i = 0; i <=9; i++){
                Console.Write("Digite um valor: ");
                vetor1[i] = double.Parse(Console.ReadLine());
            }

            
            for(int i = 0; i <=9; i++){
                Console.Write("Digite um valor: ");
                vetor2[i] = double.Parse(Console.ReadLine());
            }

            
            for(int i = 0; i <=9; i++){                
                vetor3[i] = vetor1[i];
            }

            
            for(int i = 0; i <=9; i++){
                vetor3[i+10] = vetor2[i];
            }

            for(int i = 0; i <=19; i++){
                Console.WriteLine("V3: "+vetor3[i]);
            }

        }
    }
}
