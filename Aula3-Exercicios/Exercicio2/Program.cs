using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Elabore um algoritmo que mostre o resultado da tabuada de um número inteiro dado
                pelo usuário. O formato deve ser apresentado na forma: Exemplo, para o número 2:
            */

            int valor;

            Console.WriteLine("Digite um número inteiro: ");
            valor = int.Parse( Console.ReadLine() );

            // Função para limpar as linhas de console
            Console.Clear(); 

            for(int cont = 1; cont <= 10 ; cont++){
                Console.WriteLine($"{valor} x {cont} = {valor*cont} ");
            }
            


        }
    }
}
