using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Um site na web precisa registrar 12 produtos de um fornecedor, crie um vetor para
                representar estes produtos com os seguintes atributos: Nome do produto, Cor,
                Tamanho e Preço.
            */

            string[] nomeProduto = new string[12];
            string[] cor = new string[12];
            string[] tamanho = new string[12];
            double[] preco = new double[12];

            for(int i = 1; i <= 11; i++){

                Console.Write("Digite o nome do produto: ");
                nomeProduto[i] = Console.ReadLine();

                Console.Write("Digite a cor do produto: ");
                cor[i] = Console.ReadLine();

                Console.Write("Digite o tamanho do produto: ");
                tamanho[i] = Console.ReadLine();

                Console.Write("Digite o preco do produto: ");
                preco[i] = double.Parse(Console.ReadLine());

            }


            for(int i = 1; i < nomeProduto.Length ; i++){

                Console.WriteLine();
                Console.WriteLine(nomeProduto[i]);
                Console.WriteLine(cor[i]);
                Console.WriteLine(tamanho[i]);
                Console.WriteLine(preco[i]);
                Console.WriteLine();
                
            }


        }
    }
}
