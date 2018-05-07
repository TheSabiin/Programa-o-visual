using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            int key = 0;
            int aux = 0;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            while (key != 5)
            {
                Console.WriteLine("Para calcular digite [1] \n para sair digite [2]", aux);
                aux = int.Parse(Console.ReadLine());

                if (aux == 1)
                {
                    double calc = 0;
                    double result = 0.0;

                    Console.WriteLine("Para somar digite 1");
                    Console.WriteLine("Para subtrair digite 2");
                    Console.WriteLine("Para multiplicar digite 4");
                    Console.WriteLine("Para dividir digite 3");
                    calc = double.Parse(Console.ReadLine());

                    switch (calc)
                    {

                        case 1: //Soma
                            result = num1 + num2;
                            Console.WriteLine( num1 + " + " + num2 + " = " + result);
                            break;

                        case 2: //Subtração

                            result = num1 - num2;
                            Console.WriteLine(num1 + " - " + num2 + " = " + result);
                            break;

                        case 3: //Multiplicação

                            result = num1 * num2;
                            Console.WriteLine(num1 + " * " + num2 + " = " + result);
                            break;

                        case 4://Divisão

                            result = num1 / num2;
                            Console.WriteLine(num1 + " / " + num2 + " = " + result);
                            break;

                        default:

                            break;

                    }

                }
                else if (aux == 2)
                {

                    key = 5;

                }

            }
        }
    }
}
