using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Elabore um algoritmo que leia 100 números inteiros, maiores que zero e imprima os
                seguintes resultados:
                    a) A soma de todos os números impares;
                    b) O produto de todos os números múltiplos de 3.
            */

            int numero;
            int contador    = 1;                 
            int somaImpares = 0;
            int produtoM    = 1;
            
            while(contador <= 100){

                Console.Write("Digite um numero: ");
                numero = int.Parse( Console.ReadLine() );

                if(numero > 0){

                    if(numero % 2 != 0){
                        somaImpares = somaImpares + numero; 
                    }

                    if(numero % 3 == 0){
                        produtoM = produtoM * numero;
                    }

                    contador++;
                }                
            }

            Console.WriteLine($"Soma dos ímpares : {somaImpares}");        
            Console.WriteLine($"Produto dos múltiplos de 3 : {produtoM}");


        }
    }
}
