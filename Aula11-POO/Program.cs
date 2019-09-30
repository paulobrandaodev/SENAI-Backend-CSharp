using System;
using Aula11_POO.Controllers;

namespace Aula11_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProdutosController produto1 = new ProdutosController();

            produto1.CadastrarProduto();
            produto1.ExibirProduto();

        }
    }
}
