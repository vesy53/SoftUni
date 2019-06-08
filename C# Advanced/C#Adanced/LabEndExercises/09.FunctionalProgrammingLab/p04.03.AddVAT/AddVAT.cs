namespace p04._03.AddVAT
{
    using System;
    using System.Linq;

    class AddVAT
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(p => p * 1.2)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p:F2}"));
        }
    }
}