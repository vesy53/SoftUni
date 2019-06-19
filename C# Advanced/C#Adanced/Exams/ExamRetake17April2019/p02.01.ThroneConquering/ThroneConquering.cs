namespace p02._01.ThroneConquering
{
    using System;
    using System.Linq;

    class ThroneConquering
    {
        static char[][] matrix;
        static int parisRow;
        static int parisCol;

        static void Main(string[] args)
        {
            int energyParis = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            parisRow = 0;
            parisCol = 0;

            FullTheMatrix();

            bool isDead = false;
            bool isRunAway = false;

            while (!isDead && !isRunAway)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                int spawnRow = int.Parse(tokens[1]);
                int spawnCol = int.Parse(tokens[2]);

                MoveSpawn(spawnRow, spawnCol);

                MoveParis(command, ref energyParis);

                if (matrix[parisRow][parisCol] == 'S')
                {
                    energyParis -= 2;

                    ParisDied(energyParis, ref isDead);

                    matrix[parisRow][parisCol] = '-';
                }
                else if (matrix[parisRow][parisCol] == 'H')
                {
                    matrix[parisRow][parisCol] = '-';
                    isRunAway = true;
                }

                ParisDied(energyParis, ref isDead);
            }

            PrintIfParisIsDied(energyParis, isDead, isRunAway);

            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void PrintIfParisIsDied(
            int energyParis, 
            bool isDead, 
            bool isRunAway)
        {
            if (isRunAway)
            {
                Console.WriteLine(
                    $"Paris has successfully sat on the throne! Energy left: {energyParis}");
            }
            else if (isDead)
            {
                Console.WriteLine(
                    $"Paris died at {parisRow};{parisCol}.");
            }
        }

        private static void ParisDied(
            int energyParis, 
            ref bool isDead)
        {
            if (energyParis <= 0)
            {
                matrix[parisRow][parisCol] = 'X';
                isDead = true;
            }
        }

        private static void MoveParis(
            string command,
            ref int energyParis)
        {
            matrix[parisRow][parisCol] = '-';

            switch (command)
            {
                case "up":
                    parisRow--;
                    break;
                case "down":
                    parisRow++;
                    break;
                case "left":
                    parisCol--;
                    break;
                case "right":
                    parisCol++;
                    break;
            }

            IsOuntOfRange();

            energyParis--;
        }

        private static void IsOuntOfRange()
        {
            if (parisRow < 0)
            {
                parisRow = 0;
            }
            else if (parisRow > matrix.Length - 1)
            {
                parisRow = matrix.Length - 1;
            }

            if (parisCol < 0)
            {
                parisCol = 0;
            }
            else if (parisCol > matrix[parisRow].Length - 1)
            {
                parisCol = matrix[parisRow].Length - 1;
            }
        }

        private static void MoveSpawn(
            int spawnRow,
            int spawnCol)
        {
            matrix[spawnRow][spawnCol] = 'S';
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
                    parisRow = row;
                    parisCol = Array.IndexOf(matrix[row], 'P');
                }
            }
        }
    }
}