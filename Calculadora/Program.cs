using System;
using System.Globalization;

namespace Calculadora   
{
    class Programa       
    {
        static void Main(string[] args)  
        {
            Menu();
            Soma();
            Subtracao();
            Divisao();
            Multiplicacao();
            ConversorMoedasMenu();
            Dolar();
            Euro();
            Libra();
            
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá usuário, seja bem-vindo(a) à Calculadora!");
            Console.WriteLine("");
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Conversor de Moedas");
            Console.WriteLine("6 - Sair");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");
            short response = short.Parse(Console.ReadLine());
            

            switch (response)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: ConversorMoedasMenu(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break; 
            }

            
            Console.ReadKey();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue + secondValue;

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é: {result}");
            Console.ReadKey();

            Menu();


        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue - secondValue;

            Console.WriteLine($"O resultado da subtração é: {result}");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue / secondValue;

            Console.WriteLine($"O resultado da divisão é: {result}");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = firstValue * secondValue;

            Console.WriteLine($"O resultado da multiplicação é: {result}");
            Console.ReadKey();

            Menu();

        }

        static void ConversorMoedasMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversor de moedas");
            Console.WriteLine("");
            Console.WriteLine("Para qual moeda será convertido seu valor em reais?");
            Console.WriteLine("1 - Dolar");
            Console.WriteLine("2 - Euro");
            Console.WriteLine("3 - Libra");         
            Console.WriteLine("4 - Menu principal");

            Console.WriteLine("-------------------");
            Console.WriteLine("Selecione uma opção: ");
            short response = short.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (response)
            {
                case 1: Dolar(); break;
                case 2: Euro(); break;
                case 3: Libra(); break;
                case 4: Menu(); break;
                default: Menu(); break;
            }
            

            Console.ReadKey();

            ConversorMoedasMenu();
        }

        static void Dolar()
        {

            Console.WriteLine("Qual é a cotação do Dolar hoje? ");
            float dollarRate = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o valor em reais que deseja converter em Dolar: ");
            float realValue = float.Parse(Console.ReadLine());
            Console.WriteLine();

            float conversion = realValue / dollarRate;

            Console.WriteLine();
            Console.WriteLine("Preço convertido em dolar: US$" + conversion.ToString("F2",CultureInfo.InvariantCulture) + " dolar");

            Console.ReadKey();

            ConversorMoedasMenu();
        }

        static void Euro()
        {
 
            Console.WriteLine("Qual é a cotação do Euro hoje? ");
            float euroRate = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o valor em reais que deseja converter em Euro: ");
            float realValue = float.Parse(Console.ReadLine());
            Console.WriteLine();

            float conversion = realValue / euroRate;

            Console.WriteLine();
            Console.WriteLine("Preço convertido em euro: " + conversion.ToString("F2",CultureInfo.InvariantCulture) + " euro");

            Console.ReadKey();

            ConversorMoedasMenu();
        }

        static void Libra()
        {

            Console.WriteLine("Qual é a cotação da Libra hoje? ");
            float poundRate = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o valor em reais que deseja converter em Libra: ");
            float realValue = float.Parse(Console.ReadLine());
            Console.WriteLine();

            float conversion = realValue / poundRate;

            Console.WriteLine();
            Console.WriteLine("Preço convertido em libra: £" + conversion.ToString("F2",CultureInfo.InvariantCulture) + " libra");

            Console.ReadKey();

            ConversorMoedasMenu();
        }



    }

}
