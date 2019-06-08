namespace p07._03.PredicateForNames
{
    using System;

    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Func<string, bool> filter = Filter(length);

            Action<string> print = p => Console.WriteLine(p);

            foreach (string name in names)
            {
                if (filter(name))
                {
                    print(name);
                }
            }
        }

        static Func<string, bool> Filter(int length)
        {
            return x => x.Length <= length;
        }
    }
}
