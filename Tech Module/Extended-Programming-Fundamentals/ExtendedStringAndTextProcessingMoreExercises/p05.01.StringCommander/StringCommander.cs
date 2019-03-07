namespace p05._01.StringCommander
{
    using System;

    class StringCommander
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

                        for (int i = 0; i < count; i++)
                        {
                            string firstStr = manipulatedStr[0]
                                .ToString();

                            manipulatedStr = manipulatedStr
                                .Remove(0, 1);

                            manipulatedStr = manipulatedStr
                                .Insert(manipulatedStr.Length, firstStr);
                        }

                        break;
                   case "Right":
                        int counter = int.Parse(tokens[1]);

                        for (int i = 0; i < counter; i++)
                        {
                            string lastStr = 
                                manipulatedStr[manipulatedStr.Length - 1]
                                .ToString();

                            manipulatedStr = manipulatedStr
                                .Remove(manipulatedStr.Length - 1, 1);

                            manipulatedStr = manipulatedStr
                                .Insert(0, lastStr);
                        }

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
