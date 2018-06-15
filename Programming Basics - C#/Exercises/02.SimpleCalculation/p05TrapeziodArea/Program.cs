using System;

namespace p05TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = (firstNum + secondNum) * height / 2;

            Console.WriteLine($"Trapezoid area = {area}");
        }
    }
}
