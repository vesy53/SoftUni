namespace p03._01.SpaceStationEstablishment
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SpaceStationEstablishment
    {
        private static char[][] matrix;
        private static int spaceshipRow;
        private static int spaceshipCol;
        private static int starsPower;
        private static List<int[]> blackHoles;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];
            starsPower = 0;

            // first method per initialize List<int[]>
            //blackHoles = new List<int[]>
            //{
            //    new int[] { -1, -1 },
            //    new int[] { -1, -1 }
            //};

            // second method per initialize List<int[]>
            blackHoles = new List<int[]>();
            int[] coordinates = new int[2];
            blackHoles.Add(coordinates);
            blackHoles.Add(coordinates);

            FullTheMatrix();

            bool isIntoTheVoid = false;

            while (!isIntoTheVoid && 
                   starsPower < 50)
            {
                string command = Console.ReadLine().ToLower();

                MovePlayerSpaceship(command);

                if (IsInTheRange(spaceshipRow, spaceshipCol))
                {
                    char star = matrix[spaceshipRow][spaceshipCol];

                    if (char.IsDigit(star))
                    {
                        starsPower += int.Parse(star.ToString());
                    }
                    else if (matrix[spaceshipRow][spaceshipCol] == 'O')
                    {
                        matrix[spaceshipRow][spaceshipCol] = '-';

                        if (spaceshipRow == blackHoles[0][0] &&
                            spaceshipCol == blackHoles[0][1])
                        {
                            spaceshipRow = blackHoles[1][0];
                            spaceshipCol = blackHoles[1][1];
                        }
                        else
                        {
                            spaceshipRow = blackHoles[0][0];
                            spaceshipCol = blackHoles[0][1];
                        }
                    }

                    matrix[spaceshipRow][spaceshipCol] = 'S';
                }
                else
                {
                    isIntoTheVoid = true;
                }
            }

            PrintResult(isIntoTheVoid);

            PrintTheMatrix();
        }

        private static void PrintTheMatrix()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void PrintResult(bool isIntoTheVoid)
        {
            if (isIntoTheVoid)
            {
                Console.WriteLine(
                    "Bad news, the spaceship went to the void.");
            }
            else if (starsPower >= 50)
            {
                Console.WriteLine(
                    "Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {starsPower}");
        }

        private static bool IsInTheRange(int spaceshipRow, int spaceshipCol)
        {
            return spaceshipRow >= 0 &&
                   spaceshipRow < matrix.Length &&
                   spaceshipCol >= 0 &&
                   spaceshipCol < matrix[spaceshipRow].Length;
        }

        private static void MovePlayerSpaceship(string command)
        {
            matrix[spaceshipRow][spaceshipCol] = '-';

            switch (command)
            {
                case "up":
                    spaceshipRow--;
                    break;
                case "down":
                    spaceshipRow++;
                    break;
                case "left":
                    spaceshipCol--;
                    break;
                case "right":
                    spaceshipCol++;
                    break;
            }
        }

        private static void FullTheMatrix()
        {
            int count = 1;

            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = elements;

                if (matrix[row].Contains('S'))
                {
                    spaceshipRow = row;
                    spaceshipCol = Array.IndexOf(matrix[row], 'S');
                }

                if (matrix[row].Contains('O') && 
                    count == 1)
                {
                    blackHoles[0][0] = row;
                    blackHoles[0][1] = Array.IndexOf(matrix[row], 'O');
                    count++;
                }
                else if (matrix[row].Contains('O') && 
                    count == 2)
                {
                    blackHoles[1][0] = row;
                    blackHoles[1][1] = Array.IndexOf(matrix[row], 'O');
                    count++;
                }
            }
        }
    }
}