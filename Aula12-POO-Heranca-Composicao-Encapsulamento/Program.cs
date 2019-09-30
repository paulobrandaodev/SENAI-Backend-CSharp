using System;
using Aula12_POO_Heranca_Composicao_Encapsulamento.Controllers;
using Aula12_POO_Heranca_Composicao_Encapsulamento.Models;

namespace Aula12_POO_Heranca_Composicao_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosController carro = new CarrosController();
            CarrosEletricosController carroEletrico = new CarrosEletricosController();

            Console.Clear(); // Limpa a tela do terminal.
            
            carroEletrico.Ligar();

            carroEletrico.CarregarBateria(100);
            carroEletrico.CarregarBateria(15);
            System.Console.WriteLine("Carga do carro: " + carroEletrico.StatusBateria());
        }
    }
}