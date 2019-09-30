using System;
using Senai.POO.CadastroDeAlunos.Models;

namespace Senai.POO.CadastroDeAlunos.ComPOO.Controllers {
    public class AlunoController {

        AlunoModel al = new AlunoModel();

        /// <summary>
        /// Exibe as informações do aluno.
        /// </summary>
        public void ExibirAluno () {
            System.Console.WriteLine ("Nome: " + al.Nome);
            System.Console.WriteLine ("Curso: " + al.Curso);
            System.Console.WriteLine ("RG: " + al.Rg);
            System.Console.WriteLine ("Idade: " + al.Idade);
        }

        /// <summary>
        /// Método ir no banheiro, somente imprime uma string na tela.
        /// </summary>
        public void IrNoBanheiro () {
            System.Console.WriteLine ("=======================================");
            System.Console.WriteLine ("      Deixa eu ir no banheiro AEEE!!");
            System.Console.WriteLine ("=======================================");
        }

        /// <summary>
        /// Cadastrar um aluno
        /// </summary>
        public void CadastrarAluno () {
            // Lendo nome
            System.Console.WriteLine ("Insira seu nome:");
            al.Nome = Console.ReadLine ();

            // Lendo nome do curso
            System.Console.WriteLine ("Insira o nome de seu curso: ");
            al.Curso = Console.ReadLine ();

            // Lendo RG
            System.Console.WriteLine ("Insira seu RG: ");
            al.Rg = int.Parse (Console.ReadLine ());

            // Lendo idade
            System.Console.WriteLine ("Insira sua idade: ");
            al.Idade = int.Parse (Console.ReadLine ());
        }

    }
}