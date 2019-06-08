namespace p01._01.ActionPrint
{
    using System;

    class ActionPrint
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Action<string[]> print = p => Console.WriteLine(
                string.Join(Environment.NewLine, p));

            print(names);
        }
    }
}
