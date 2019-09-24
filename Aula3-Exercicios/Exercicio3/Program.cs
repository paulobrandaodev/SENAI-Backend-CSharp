using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                Escreva um algoritmo que leia um número n 
                e imprima todos os múltiplos de 5, 
                no intervalo de 1 a n. 
            */

            int n;
            int cont = 1;

            Console.Write("Digite um número: ");
            n = int.Parse( Console.ReadLine() );

            while(cont <= n){

                if(cont % 5 == 0){
                    Console.WriteLine(cont);
                }
                cont++;
            }

        }
    }
}
