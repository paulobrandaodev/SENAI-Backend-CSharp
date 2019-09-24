using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Dado um conjunto de 20 valores, faça um algoritmo que:
                    a) Imprima os valores que não são negativos.
                    b) Calcule e imprima a média dos valores < 0.
            */

            int ini = -15;
            int fim =  5;

            string naoNegativos = "";
            int soma = 0;
            int qtd  = 0;

            do{
                
                if(ini > 0){
                    naoNegativos += $" {ini} ";
                }else{
                    soma += ini;
                    qtd++;
                }

                ini ++;

            }while(ini < fim);

            Console.WriteLine("Não negativos: " + naoNegativos);
            Console.WriteLine("Média dos valores menor que 0 : " + soma / qtd);

        }
    }
}
