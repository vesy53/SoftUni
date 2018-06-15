using System;

namespace p13AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string areasOfFigures = Console.ReadLine();

            double area = 0.0;

            if (areasOfFigures == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (areasOfFigures == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());

                area = side1 * side2;
            }
            else if (areasOfFigures == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                area = radius * radius * 3.14159265359;
            }
            else if (areasOfFigures == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());

                area = (side1 * side2) / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
