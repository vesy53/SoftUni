namespace p01._04.ActionPrint
{
    using System;

    class ActionPrint4
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            Action<string> printActDelName = n => Console.WriteLine(n);

            foreach (string name in names)
            {
                printActDelName(name);
            }
        }
    }
}