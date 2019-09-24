using System;

namespace Aula4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] series1 = new string[10];
            string[] series2 = new string[10];

            for(int i = 0; i <= 9 ; i++){
                Console.Write("Digite o nome de uma série: ");
                series1[i] = Console.ReadLine();
            }

            for(int i = 0; i <= 9; i++){                
                series2[i] = series1[i];
            }

            for(int i = 0; i <= 9; i++){
                Console.WriteLine(series2[i]);
            }


        }
    }
}
