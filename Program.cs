using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {

            Menu();
        }
        static void Menu()
        {
            Console.WriteLine(" O q deseja fazer ?");
            Console.WriteLine("1-- soma");
            Console.WriteLine("2-- subtração");
            Console.WriteLine("3-- divisão");
            Console.WriteLine("4-- Multiplicação");
            Console.WriteLine("5-- Sair do Sistema");

            Console.WriteLine("______________");

            Console.WriteLine("Selecione uma opção");
            short res = short.Parse(Console.ReadLine());
            
            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: divisao(); break;
                case 4: multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }
               
        }

        static void Soma()
        {
            Console.WriteLine("Pimeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            float resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é" + resultado);
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($" O resultado da Subtração é {resultado} ");
            Console.ReadKey();
            Menu();
        }

        static void divisao()
        {
            Console.WriteLine("Primeiro Valor");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1/ v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void multiplicacao()
        {
            Console.WriteLine("Digite o primeiro numero:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da operação é {resultado}");

            Console.ReadKey();
            Menu();
        }
    } 

}