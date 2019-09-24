using System;

namespace Aula2 {
    class Program {
        static void Main (string[] args) {

            // Declaramos as notas que utilizaremos  
            double nota1, nota2, nota3, media;

            // Capturamos a 1º nota
            Console.Write ("Digite sua primeira nota: ");
            nota1 = double.Parse (Console.ReadLine ());

            // Capturamos a 2º nota
            Console.Write ("Digite sua segunda nota: ");
            nota2 = double.Parse (Console.ReadLine ());

            // Capturamos a 3º nota
            Console.Write ("Digite sua terceira nota: ");
            nota3 = double.Parse (Console.ReadLine ());

            // Calculamos a média das notas
            media = (nota1 + nota2 + nota3) / 3;

            // Verificamos se a média do aluno é maior ou igual à 6
            if (media >= 6) {

                Console.WriteLine ($"Média: {media} Aluno aprovado!");

            } else {

                Console.WriteLine($"Média: {media} Aluno reprovado");

            }

        }
    }
}