namespace p02._02.HelensAbduction
{
    using System;
    using System.Linq;

    class HelensAbduction
    {
        static char[][] matrix;
        static int energyParis;
        static int[] parisIndexes;
        static int[] helenIndexes;

        static void Main(string[] args)
        {
            energyParis = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            int sizeIndexes = 2;
            parisIndexes = new int[sizeIndexes];
            helenIndexes = new int[sizeIndexes];

            bool isDead = false;
            bool isRunAway = false;

            FullTheMatrix();

            while (!isDead &&
                   !isRunAway)
            {
                string[] input = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = input[0];
                int rowSpawn = int.Parse(input[1]);
                int colSpawn = int.Parse(input[2]);

                MovedSpartanSpawn(rowSpawn, colSpawn);

                MovedParis(command);

                if (matrix[parisIndexes[0]][parisIndexes[1]] == 'S')
                {
                    energyParis -= 2;

                    isDead = ParisIsDead(isDead);
                }

                if (matrix[parisIndexes[0]][parisIndexes[1]] ==
                    matrix[helenIndexes[0]][helenIndexes[1]])
                {
                    matrix[parisIndexes[0]][parisIndexes[1]] = '-';

                    isRunAway = true;
                }

                isDead = ParisIsDead(isDead);
            }

            PrintResult(isDead, isRunAway);

            PrintTheMatrix();
        }

        private static void PrintTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static void PrintResult(
            bool isDead,
            bool isRunAway)
        {
            if (isDead)
            {
                Console.WriteLine(
                        $"Paris died at {parisIndexes[0]};{parisIndexes[1]}.");
            }
            else if (isRunAway)
            {
                Console.Write($"Paris has successfully abducted Helen!");
                Console.WriteLine($" Energy left: {energyParis}");
            }
        }

        private static bool ParisIsDead(bool isDead)
        {
            if (energyParis <= 0)
            {
                matrix[parisIndexes[0]][parisIndexes[1]] = 'X';

                isDead = true;
            }

            return isDead;
        }

        private static void MovedParis(string command)
        {
            //row = parisIndexes[0];
            //col = parisIndexes[1];
            matrix[parisIndexes[0]][parisIndexes[1]] = '-';

            switch (command)
            {
                case "up":
                    parisIndexes[0]--;
                    break;
                case "down":
                    parisIndexes[0]++;
                    break;
                case "left":
                    parisIndexes[1]--;
                    break;
                case "right":
                    parisIndexes[1]++;
                    break;
            }

            IsOutsideOfTheRange();

            energyParis--;
        }

        private static void IsOutsideOfTheRange()
        {
            if (parisIndexes[0] < 0)
            {
                parisIndexes[0] = 0;
            }
            else if (parisIndexes[0] > matrix.Length - 1)
            {
                parisIndexes[0] = matrix.Length - 1;
            }

            if (parisIndexes[1] < 0)
            {
                parisIndexes[1] = 0;
            }
            else if (parisIndexes[1] > matrix[parisIndexes[0]].Length - 1)
            {
                parisIndexes[1] = matrix[parisIndexes[0]].Length - 1;
            }
        }

        private static void MovedSpartanSpawn(
            int rowSpawn, 
            int colSpawn)
        {
            matrix[rowSpawn][colSpawn] = 'S';
        }

        private static void FullTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                char[] elements = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = elements;

                if (matrix[row].Contains('P'))
                {
                    parisIndexes[0] = row;
                    parisIndexes[1] = Array.IndexOf(matrix[row], 'P');
                }

                if (matrix[row].Contains('H'))
                {
                    helenIndexes[0] = row;
                    helenIndexes[1] = Array.IndexOf(matrix[row], 'H');
                }
            }
        }
    }
}