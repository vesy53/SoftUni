namespace p01._03.ActionPrint
{
    using System;

    class ActionPrint
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
               .Split(' ',
                   StringSplitOptions
                   .RemoveEmptyEntries);

            Action<string> printActDelName = delegate (string name)
            {
                Console.WriteLine(name);
            };

            foreach (string name in names)
            {
                printActDelName(name);
            }
        }
    }
}