using System;

namespace p17PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            char symbol1 = (char)(num1);
            char symbol2 = (char)(num2);

            for (char i = symbol1; i <= symbol2; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
