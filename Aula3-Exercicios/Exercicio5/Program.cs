using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Uma empresa com X funcionários precisa saber a média de seus salários. Faça um
                algoritmo para ler a quantidade de funcionários e o salário de cada um e escrever a
                média dos salários.
            */

            int funcionarios;
            double salarios = 0;

            Console.Write("Digite a quantidade de funcionários de sua empresa : ");
            funcionarios = int.Parse( Console.ReadLine() );

            for(int cont = 1; cont <= funcionarios; cont++){

                Console.Write($"Digite o salário do {cont}º funcionário : ");
                salarios += double.Parse( Console.ReadLine() );

            }

            Console.WriteLine($"Média dos salários: {salarios / funcionarios}");

        }
    }
}
