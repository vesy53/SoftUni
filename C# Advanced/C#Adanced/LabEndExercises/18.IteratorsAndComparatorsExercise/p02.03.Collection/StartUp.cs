namespace p02._03.Collection
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
                    case "PrintAll":

                        //foreach (var element in list)
                        //{
                        //    Console.Write(element + " ");
                        //}
                        //
                        //Console.WriteLine();

                        Console.WriteLine(string.Join(" ", list));
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
