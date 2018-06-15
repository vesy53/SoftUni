using System;

namespace p01ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double evaluation = double.Parse(Console.ReadLine());

            if (evaluation >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
