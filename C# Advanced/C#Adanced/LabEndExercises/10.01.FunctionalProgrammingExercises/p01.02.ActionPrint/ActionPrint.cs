namespace p01._02.ActionPrint
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

            Action<string> printActDelName = ConsolePrint;

            //second variant
            //Action<string> printActDelName = new Action<string>(ConsolePrint);

            foreach (string name in names)
            {
                printActDelName(name);
            }
        }

        static void ConsolePrint(string name)
        {
            Console.WriteLine(name);
        }
    }
}