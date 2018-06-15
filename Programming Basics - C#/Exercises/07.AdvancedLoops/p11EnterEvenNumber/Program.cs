using System;

namespace p11EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int num = int.Parse(Console.ReadLine());

                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {num}");
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
