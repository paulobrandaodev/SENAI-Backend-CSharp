using System;
using EX2.Controllers;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CalculadoraCientifica calculos = new CalculadoraCientifica();
            Console.WriteLine( calculos.Somar() );     

        }
    }
}
