using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* 
                Elabore um algoritmo que apresente 
                os números inteiros de 1 a 100 
                elevados ao cubo (x³). 
            */

            for(int cont = 1 ; cont <= 100 ; cont++){
                Console.WriteLine( Math.Pow(cont, 3) );
            }

        }
    }
}
