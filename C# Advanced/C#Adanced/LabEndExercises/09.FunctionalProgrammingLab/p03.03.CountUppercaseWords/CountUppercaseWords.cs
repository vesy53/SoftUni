namespace p03._03.CountUppercaseWords
{
    using System;
    using System.Linq;

    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]))
                .Select(w =>
                {
                    Console.WriteLine(w);
                    return w;
                })
                .ToList();
        }
    }
}