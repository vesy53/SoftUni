namespace p03._01.SpaceStationEstablishment
{
    using System;
    using System.Linq;

    class SpaceStationEstablishment
    {
        private static char[][] matrix;
        private static int spaceshipRow;
        private static int spaceshipCol;
        private static int starsPower;
        private static int[] blackHoles1;
        private static int[] blackHoles2;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];
            starsPower = 0;
            blackHoles1 = new int[2];
            blackHoles1[0] = -1;
            blackHoles1[1] = -1;
            blackHoles2 = new int[2];
            blackHoles2[0] = -1;
            blackHoles2[1] = -1;

            FullTheMatrix();

            bool intoTheVoid = false;

            while (!intoTheVoid)
            {
                string command = Console.ReadLine().ToLower();

                MovePlayerShip(command);

                if (IsInTheRange(spaceshipRow, spaceshipCol))
                {
                    char star = matrix[spaceshipRow][spaceshipCol];

                    if (char.IsDigit(star))
                    {
                        starsPower += int.Parse(star.ToString());
                    }

                    if (matrix[spaceshipRow][spaceshipCol] == 'O' &&
                        blackHoles1[0] != -1 &&
                        blackHoles1[0] != -1)
                    {
                        matrix[spaceshipRow][spaceshipCol] = '-';

                        spaceshipRow = blackHoles2[0];
                        spaceshipCol = blackHoles2[1];
                    }
                    else if (matrix[spaceshipRow][spaceshipCol] == 'O' &&
                        matrix[blackHoles1[0]][blackHoles1[1]] == 'O' &&
                        blackHoles2[0] != -1 &&
                        blackHoles2[0] != -1)
                    {
                        matrix[spaceshipRow][spaceshipCol] = '-';

                        spaceshipRow = blackHoles1[0];
                        spaceshipCol = blackHoles1[1];
                    }

                    matrix[spaceshipRow][spaceshipCol] = 'S'; 
                }
                else
                {
                    intoTheVoid = true;
                }

                if (starsPower >= 50)
                {
                    break;
                }
            }   

            if (intoTheVoid)
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

            PrintTheMatrix();
        }

        private static void PrintTheMatrix()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static bool IsInTheRange(int spaceshipRow, int spaceshipCol)
        {
            return spaceshipRow >= 0 &&
                   spaceshipRow < matrix.Length &&
                   spaceshipCol >= 0 &&
                   spaceshipCol < matrix[spaceshipRow].Length;
        }

        private static void MovePlayerShip(string command)
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
                   blackHoles1[0] = row;
                   blackHoles1[1] = Array.IndexOf(matrix[row], 'O');
                   count++;
               }
               else if (matrix[row].Contains('O') && 
                    count == 2)
               {
                   blackHoles2[0] = row;
                   blackHoles2[1] = Array.IndexOf(matrix[row], 'O');
                   count++;
               }
            }
        }
    }
}
