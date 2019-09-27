using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( MostraInfo() );
            Console.WriteLine( MostraInfo("Brandão", "Paulo") );
            Console.WriteLine( MostraInfo("19", "65", "1,69") );
        }

        static string MostraInfo(){
            return "SENAI Serviço Nacional de Aprendizagem Industrial";
        }

        static string MostraInfo(string nome, string sobrenome){
            return $"{nome} {sobrenome}";
        }

        static string MostraInfo(string idade, string peso, string altura){
            return $"Idade: {idade}, Peso: {peso}KG, Altura: {altura}";
        }

        

    }
}
