namespace p06._02.GenericCountMethodDouble
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Box<double> elements = new Box<double>();

            for (int i = 0; i < number; i++)
            {
                double input = double.Parse(Console.ReadLine());

                elements.Add(input);
            }

            double comparisonByValue = double.Parse(Console.ReadLine());

            int count = elements
                .CompareElement(comparisonByValue);

            Console.WriteLine(count);
        }
    }
}
