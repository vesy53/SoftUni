namespace p02._01.Ladybugs
{
    using System;
    using System.Linq;

    class Ladybugs3
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            int[] indexesOfLadybugs = Console.ReadLine()
                .Split(new char[] { ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            int[] field = new int[sizeOfTheField]; //създаваме [] на полето

            foreach (int index in indexesOfLadybugs)
            {
                if (index < 0 || index >= sizeOfTheField) //проверяваме дали калинките са извън границите
                {
                    continue;
                }

                field[index] = 1; //ако не са - добавяме 1 на всеки индекс където има калинка
            }

            while (command.Equals("end") == false)
            {
                string[] commandTokens = command
                    .Split();
                int index = int.Parse(commandTokens[0]);
                string direction = commandTokens[1];
                int flyLength = int.Parse(commandTokens[2]);

                if (index < 0 || index >= sizeOfTheField) //проверяваме дали index-а е извън границите
                {
                    continue;
                }

                if (field[index] == 0) //ако в полето от index-а = 0 т.е. няма калинка
                {
                    continue;
                }

                int position = index;  //новата променлива присвоява с-стта на index
                field[index] = 0;  //от настоящото си местоположение калинката излита

                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else if (direction == "left")
                    {
                        if (flyLength > 0)
                        {
                            position -= flyLength;
                        }
                        else
                        {
                            flyLength *= -1;
                            position += flyLength;
                        }
                    }

                    if (position < 0 || position >= sizeOfTheField)
                    {
                        break;
                    }

                    if (field[position] != 1) //ако нямаме калинка
                    {
                        field[position] = 1; //добави я
                        break;               
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
