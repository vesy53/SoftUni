namespace p02._03.Ladybugs
{
    using System;
    using System.Linq;

    class Ladybugs3
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            long[] indexes = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();
            long[] bugField = new long[fieldSize];

            foreach (var index in indexes)
            {
                if (index >= 0 && index < bugField.Length)
                {
                    bugField[index] = 1;
                }
            }

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input
                    .Split();
                long ladyBugIndx = long.Parse(tokens[0]);
                string direction = tokens[1];
                long flyLength = long.Parse(tokens[2]);

                if (ladyBugIndx >= 0 && ladyBugIndx <= bugField.Length - 1)
                {
                    if (bugField[ladyBugIndx] == 1)
                    {
                        switch (direction)
                        {
                            case "right":
                                bugField = MoveLbRight(bugField, ladyBugIndx, flyLength);
                                break;
                            case "left":
                                bugField = MoveLbLeft(bugField, ladyBugIndx, flyLength);
                                break;
                        }
                    }
                }
                //Console.WriteLine(string.Join(" ", bugField));
                input = Console.ReadLine();
            }

            if (bugField.Length > 0)
            {
                Console.WriteLine(string.Join(" ", bugField));
            }
        }

        static long[] MoveLbLeft(long[] bugField, long ladyBugIndx, long flyLength)
        {
            long takeOffIndex = ladyBugIndx;
            long flight = takeOffIndex - flyLength;
            long landIndex = ladyBugIndx;

            if (flyLength == 0)  //ако нашата дължина на летене е 0
            {
                return bugField;
            }

            if (flyLength < 0)  //ако нашата дължина на летене е < 0, сменяме посоката на движение
            {
                bugField = MoveLbRight(bugField, ladyBugIndx, Math.Abs(flyLength));
                return bugField;
            }

            if (flight >= 0 && flight < bugField.Length)// To check later
            {
                if (bugField[flight] == 0)   //нямаме калинка
                {
                    landIndex = flight;

                    bugField[takeOffIndex] = 0; //старата позиция
                    bugField[landIndex] = 1;    //настояща позиция
                }
                else  // когато имаме калинка
                {
                    landIndex = -1;
                    for (long i = flight; i >= 0; i -= flyLength)
                    {
                        if (bugField[i] != 1)
                        {
                            landIndex = i;
                            bugField[takeOffIndex] = 0;   //старата позиция
                            bugField[landIndex] = 1;     //настоящата позиция
                            break;
                        }

                    }

                    if (landIndex < 0)  //ако сме излезнали извън полето
                    {
                        bugField[takeOffIndex] = 0;  //стария Index = 0
                    }
                }
            }
            else  //ако сме излезнали извън полето
            {
                bugField[takeOffIndex] = 0;  //стария Index = 0
            }

            return bugField;
        }

        static long[] MoveLbRight(long[] bugField, long ladyBugIndx, long flyLength)
        {
            long takeOffIndex = ladyBugIndx;
            long flight = takeOffIndex + flyLength;
            long landIndex = ladyBugIndx;

            if (flyLength == 0) //ако нашата дължина на летене е 0
            {
                return bugField;
            }

            if (flyLength < 0) //ако нашата дължина на летене е < 0, сменяме посоката на движение
            {
                bugField = MoveLbLeft(bugField, ladyBugIndx, Math.Abs(flyLength));
                return bugField;
            }

            if (flight >= 0 && flight < bugField.Length)// To check later
            {

                if (bugField[flight] == 0) //нямаме калинка
                {
                    landIndex = flight;

                    bugField[takeOffIndex] = 0; //старата позиция
                    bugField[landIndex] = 1;    //настоящата позиция
                }
                else // когато имаме калинка
                {
                    landIndex = -1;

                    for (long i = flight; i < bugField.Length; i += flyLength)
                    {
                        if (bugField[i] != 1)
                        {
                            landIndex = i;
                            bugField[takeOffIndex] = 0;  //старата позиция
                            bugField[landIndex] = 1;     //настоящата позиция
                            break;
                        }

                    }

                    if (landIndex < 0) //ако сме излезнали извън полето
                    {
                        bugField[takeOffIndex] = 0; //стария Index = 0
                    }
                }
            }
            else //ако сме излезнали извън полето
            {
                bugField[takeOffIndex] = 0;  //стария Index = 0
            }

            return bugField;
        }
    }
}
