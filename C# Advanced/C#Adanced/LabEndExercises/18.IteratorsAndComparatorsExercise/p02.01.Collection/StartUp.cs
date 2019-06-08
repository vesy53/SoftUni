namespace p02._01.Collection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split();

                string command = tokens[0];

                switch (command)
                {
                    case "Create":
                        string[] arguments = tokens
                            .Skip(1)
                            .ToArray();

                        listyIterator = new ListyIterator<string>(arguments);
                        break;
                    case "Move":
                        bool isMove = listyIterator.Move();

                        Console.WriteLine(isMove);
                        break;
                    case "HasNext":
                        bool isHasNext = listyIterator.HasNext();

                        Console.WriteLine(isHasNext);
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                    case "PrintAll":
                        foreach (string element in listyIterator)
                        {
                            Console.Write($"{element} ");
                        }

                        Console.WriteLine();
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
