using System;

namespace CSharpIntroductionProgramming
{

    class Calcutaor
    {
        static void Main(string[] args)
        {
            char op;
            double num1, num2;

            Console.WriteLine("Enter the Operation(+,-,*,/");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter the numbers");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            switch( op)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, (num1 * num2));
                    break;

                case '/':
                    if (num2 == 0.0)
                        Console.WriteLine("Divide by zero situation");
                    else
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, (num1 / num2));
                    break;

                default:
                    Console.WriteLine("{0} is an invalid operator", op);
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}