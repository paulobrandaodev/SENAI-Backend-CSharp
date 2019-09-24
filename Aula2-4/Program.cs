using System;

namespace Aula2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string placa;
            string final;
            string resultado;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            // Contamos a quantidade de caracteres de
            // um elemento
            int caracteres = placa.Length;

            // Pegamos o último dígito
            // com o método Substring()
            final = placa.Substring(caracteres - 1);

            if(final == "1" || final == "2"){
                resultado = "IF/ELSE - Seu rodízio é na Segunda-Feira";      
            }else if( final == "3" || final == "4" ){
                resultado = "IF/ELSE - Seu rodízio é na Terça-Feira";
            }else if( final == "5" || final == "6"){
                resultado = "IF/ELSE - Seu rodízio é na Quarta-Feira";
            }else if( final == "7" || final == "8"){
                resultado = "IF/ELSE - Seu rodízio é na Quinta-Feira";
            }else if( final == "9" || final == "0"){
                resultado = "IF/ELSE - Seu rodízio é na Sexta-Feira";
            }else{
                resultado = "IF/ELSE - Placa inválida!";
            }

            Console.WriteLine(resultado);


            switch(final){

                case "1":
                resultado = "Switch - Segunda-Feira";
                break;

                case "2":
                resultado = "Switch - Segunda-Feira";
                break;

                case "3":
                resultado = "Switch - Terça-Feira";
                break;

                case "4":
                resultado = "Switch - Terça-Feira";
                break;

                case "5":
                resultado = "Switch - Quarta-Feira";
                break;

                case "6":
                resultado = "Switch - Quarta-Feira";
                break;

                case "7":
                resultado = "Switch - Quinta-Feira";
                break;

                case "8":
                resultado = "Switch - Quinta-Feira";
                break;

                case "9":
                resultado = "Switch - Sexta-Feira";
                break;

                case "0":
                resultado = "Switch - Sexta-Feira";
                break;

                default:
                resultado = "Switch - Entrada inválida! :( ";
                break;

            }

            Console.WriteLine(resultado);           


        }
    }
}
