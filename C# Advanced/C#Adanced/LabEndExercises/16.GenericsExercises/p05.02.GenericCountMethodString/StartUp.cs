namespace p05._02.GenericCountMethodString
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Box<string> elements = new Box<string>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                elements.Add(input);
            }

            string comparisonByValue = Console.ReadLine();

            int count = elements
                .CompareElement(comparisonByValue);

            Console.WriteLine(count);
        }
    }
}
