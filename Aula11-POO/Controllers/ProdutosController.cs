using System;
using System.IO;
using Aula11_POO.Models;

namespace Aula11_POO.Controllers {
    public class ProdutosController {

        ProdutosModel produtos = new ProdutosModel();

        public void CadastrarProduto () {

            try {

                Console.WriteLine ("Digite o ID do Produto: ");
                produtos.IdProduto = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite o Nome do Produto: ");
                produtos.NomeProduto = Console.ReadLine ();

                System.Console.WriteLine ("Descricao do Produto: ");
                produtos.Descricao = Console.ReadLine ();

                System.Console.WriteLine ("Digite o preco do Produto: ");
                produtos.Preco = double.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o ID do Fornecedor: ");
                // produtos.Fornecedor.IdFornecedor = int.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o Nome do Fornecedor: ");
                // produtos.Fornecedor.NomeFornecedor = Console.ReadLine ();

            } catch (Exception ex) {

                Console.WriteLine("Desculpe :( Houve um erro na aplicação");
                SalvarErros(ex);
                
            }

        }

        public void ExibirProduto () {

            System.Console.WriteLine (produtos.IdProduto);
            System.Console.WriteLine (produtos.NomeProduto);
            System.Console.WriteLine (produtos.Descricao);
            System.Console.WriteLine (produtos.Preco);

            // System.Console.WriteLine (produtos.Fornecedor.IdFornecedor);
            // System.Console.WriteLine (produtos.Fornecedor.NomeFornecedor);

        }

        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();

        }

    }
}