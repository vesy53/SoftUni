namespace p07._02.PredicateForNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            List<string> inputNames = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();

            Func<List<string>, List<string>> function = names =>
                    names.Where(x => x.Length <= length)
                         .ToList();

            Action<List<string>> print = p =>
                    Console.WriteLine(string.Join(Environment.NewLine, p));

            inputNames = function(inputNames);
            print(inputNames);
        }
    }
}
