namespace p02._01.HelensAbduction
{
    using System;
    using System.Linq;

    class HelensAbduction
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

            string input = Console.ReadLine();

            while (true)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string moveCommand = tokens[0];
                int spawnRow = int.Parse(tokens[1]);
                int spawnCol = int.Parse(tokens[2]);

                MoveSpawn(spawnRow, spawnCol);

                MoveParis(moveCommand, ref energyParis);

                if (matrix[parisRow][parisCol] == 'S')
                {
                    energyParis -= 2;

                    if (energyParis <= 0)
                    {
                        ParisDied();
                        break;
                    }
                    else
                    {
                        matrix[parisRow][parisCol] = '-';
                    }
                }
                else if (matrix[parisRow][parisCol] == 'H')
                {
                    matrix[parisRow][parisCol] = '-';

                    Console.WriteLine(
                        $"Paris has successfully abducted Helen! Energy left: {energyParis}");
                    break;
                }

                if (energyParis <= 0)
                {
                    ParisDied();
                    break;
                }

                input = Console.ReadLine();
            }

            if (energyParis <= 0)
            {
                Console.WriteLine(
                    $"Paris died at {parisRow};{parisCol}.");
            }

            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            foreach (char[] row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void ParisDied()
        {
            matrix[parisRow][parisCol] = 'X';
        }

        private static void MoveParis(
            string moveCommand,
            ref int energyParis)
        {
            matrix[parisRow][parisCol] = '-';

            switch (moveCommand)
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

        private static void MoveSpawn(int spawnRow, int spawnCol)
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
