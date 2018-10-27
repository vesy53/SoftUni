using System;

namespace p2RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double area = num1 * num2;

            Console.WriteLine($"{area:F2}");
        }
    }
}
