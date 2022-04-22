using System;

namespace CSharpIntroductionProgramming
{
    public class Circle
    {

        static void area()
        {
            double r, perimeter;
            double PI = 3.14;
            Console.WriteLine("Radius of the Circle= ");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = (2 * PI * r);
            Console.WriteLine("Perimeter of the Circle= " +perimeter);
            double area = (PI * r * r);
            Console.WriteLine("Area of the Circle= "+area);
        }
        public static void Main()
        {
            area();
        }
    }
}
