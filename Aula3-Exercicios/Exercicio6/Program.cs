using System;

namespace Exercicio6 {
    class Program {
        static void Main (string[] args) {

            /*
                Faça um algoritmo que gere 20 números da série Fibonacci (0, 1, 1, 2, 3, 5, 8, 13, 21...).
            */

            int atual    = 0;
            int anterior = 0;

            for (int cont = 1; cont <= 20; cont++) {               

                if(atual == 0){

                    Console.WriteLine(atual);

                    atual    = 1;
                    anterior = 0;                    

                }else{

                    atual    = atual + anterior;                    
                    anterior = atual - anterior;              

                }

                Console.WriteLine(atual); 
                

            }

        }
    }
}