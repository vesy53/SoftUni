using System;

namespace p12NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");               
            }
        }
    }
}
