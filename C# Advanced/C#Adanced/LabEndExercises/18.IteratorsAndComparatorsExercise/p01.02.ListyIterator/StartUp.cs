namespace p01._02.ListyIterator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToArray(); 

            ListyIterator<string> list = new ListyIterator<string>(data);

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                switch (input)
                {
                    case "Move":
                        Console.WriteLine(list.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(list.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            list.Print();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
