using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            DiaDaSemana();
        }

        static void DiaDaSemana(){
            System.Console.WriteLine(DateTime.Now.DayOfWeek);
        }
    }
}
