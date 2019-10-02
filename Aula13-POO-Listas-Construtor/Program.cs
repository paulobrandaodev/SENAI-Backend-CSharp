using System;
using System.Collections.Generic;
using Aula13_POO_Listas_Construtor.Models;

namespace Aula13_POO_Listas_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa classe com 
            // o método construtor passando os parâmetros
            ProdutoModel produto = new ProdutoModel(1, "Maça", "Verde", 3.5);
            
            // Chamos um atrubuto do objeto instanciado
            Console.WriteLine(produto.NomeProduto);

            // Instanciamos nossa classe 
            // sem passar parâmetros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();

            // Alimentamos nosso objeto que estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;


            // Chamamos a nossa lista que vai se do 
            // objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adicionamos objetos instanciados e atribuídos
            // em nossa lista
            prod.Add( new ProdutoModel( 1, "Cenoura", "Laranja", 2.30 ) );
            prod.Add( new ProdutoModel( 2, "Mamão", "Laranja", 2.30 ) );
            prod.Add( new ProdutoModel( 3, "Beterraba", "Laranja", 2.30 ) );
            prod.Add( new ProdutoModel( 4, "Pastel", "Laranja", 2.30 ) );
            prod.Add( new ProdutoModel( 5, "Caldo de Cana", "Laranja", 2.30 ) );
            prod.Add( new ProdutoModel( 6, "Chuchu", "Laranja", 2.30 ) );

            // Lemos os dados da nossa lista 
            foreach(ProdutoModel p in prod){
                Console.WriteLine();
                Console.WriteLine(p.IdProduto);
                Console.WriteLine(p.NomeProduto);
                Console.WriteLine(p.Descricao);
                Console.WriteLine(p.Preco);
                Console.WriteLine();
            }

            // Chamamos através do índice um atributo específico
            Console.WriteLine(prod[4].NomeProduto);

        }
    }
}
