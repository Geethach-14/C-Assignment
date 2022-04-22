using System;

namespace CSharpIntroductionProgramming
{
    public class Average
    {
        static void Main()
        {
            double number1, number2, number3, number4, number5;
            Console.WriteLine("Enter the number1: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number2: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number3: ");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number4: ");
            number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number5: ");
            number5 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4 +number5) / 5;
            Console.WriteLine("The average of {0}, {1}, {2}, {4}, {5} is {5}", number1, number2, number3, number4, number5, result);
        }
    }
}
