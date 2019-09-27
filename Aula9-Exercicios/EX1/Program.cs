using System;

namespace EX1 {
    class Program {
        static void Main (string[] args) {

            double preco;
            double desconto;

            try {

                Console.WriteLine ("Digite um valor:");
                preco = double.Parse (Console.ReadLine ());

                Console.WriteLine ("Digite um desconto:");
                desconto = double.Parse (Console.ReadLine ().Replace ("%", ""));

                System.Console.WriteLine (AplicaDesconto (preco, desconto));

            }catch(Exception){
                System.Console.WriteLine("Os dados devem ser numéricos");
            }

           

        }

        /// <summary>
        /// Função que dá desconto em cima de um valor
        /// </summary>
        /// <param name="valor">preço da mercadoria</param>
        /// <param name="porcentagem">percentual de desconto</param>
        /// <returns>Valor já com desconto</returns>
        static double AplicaDesconto (double valor, double porcentagem) {
            return valor - (valor * (porcentagem / 100));
        }

    }
}