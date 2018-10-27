namespace p05._02.StringCommander
{
    using System;

    class StringCommander2
    {
        static void Main(string[] args)
        {
            string manipulatedStr = Console.ReadLine();

            string input = Console.ReadLine();

            while (input.Equals("end") == false)
            {
                string[] tokens = input
                    .Split();

                string command = tokens[0];

                switch (command)
                {
                    case "Left":
                        int count = int.Parse(tokens[1]);

                        count %= manipulatedStr.Length;

                        manipulatedStr = 
                            manipulatedStr.Substring(count) + 
                            manipulatedStr.Substring(0, count);
                        break;
                    case "Right":
                        int counter = int.Parse(tokens[1]);

                        counter %= manipulatedStr.Length;

                        string firstArg = manipulatedStr
                            .Substring(manipulatedStr.Length - counter);
                        string secondArg = manipulatedStr
                            .Substring(0, manipulatedStr.Length - counter);

                        manipulatedStr = firstArg + secondArg;

                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string currentCommand = tokens[2];

                        manipulatedStr = manipulatedStr
                            .Insert(index, currentCommand);

                        break;
                    case "Delete":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        manipulatedStr = manipulatedStr
                            .Remove(startIndex, endIndex - startIndex + 1);

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(manipulatedStr);
        }
    }
}
