namespace p09._01.RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            
            int[] numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfRectangle = numbers[0];
            int intersectionChecks = numbers[1];

            for (int i = 0; i < numberOfRectangle; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string id = tokens[0];
                double width = double.Parse(tokens[1]);
                double height = double.Parse(tokens[2]);
                double coordinateTopLeftX = double.Parse(tokens[3]);
                double coordinateTopLeftY = double.Parse(tokens[4]);

                Rectangle rectangle = new Rectangle(
                    id, 
                    width, 
                    height, 
                    coordinateTopLeftX, 
                    coordinateTopLeftY);

                rectangles.Add(rectangle);  
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                string[] rectanglesId = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string firstRectangleId = rectanglesId[0];
                string secondRectangleId = rectanglesId[1];

                Rectangle firstRectangle = rectangles
                    .FirstOrDefault(x => x.Id == firstRectangleId);
                Rectangle secondRectangle = rectangles
                    .FirstOrDefault(x => x.Id == secondRectangleId);

                if (firstRectangle.Intersect(secondRectangle))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
