using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] v1 = { 4, 5, 9, 6, 5, 8};
            System.Console.WriteLine( MaiorNumero(v1) );
        }

        static double MaiorNumero(double[] vetor){
            
            double maior = 0;

            for (int i = 0; i < vetor.Length; i++){
                
                if(vetor[0] < 0){
                    maior = vetor[0];
                }

                if(vetor[i] > maior){
                    maior = vetor[i];
                }              
            
            }

            return maior;

        }

    }
}
