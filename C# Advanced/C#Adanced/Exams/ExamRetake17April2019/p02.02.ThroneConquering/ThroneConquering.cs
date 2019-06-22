namespace p02._02.ThroneConquering
{
    using System;
    using System.Linq;

    class ThroneConquering
    {
        private static int energyParis;
        private static char[][] matrix;
        private static int[] parisIndexes;
        
        static void Main(string[] args)
        {
            energyParis = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size][];
            parisIndexes = new int[2];

            FullTheMatrix();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = input[0];
                int spawnRow = int.Parse(input[1]);
                int spawnCol = int.Parse(input[2]);

                MoveSpartanSpawn(spawnRow, spawnCol);

                MoveParis(command);

                if (matrix[parisIndexes[0]][parisIndexes[1]] == 'S')
                {
                    energyParis -= 2;

                    if (energyParis <= 0)
                    {
                        matrix[parisIndexes[0]][parisIndexes[1]] = 'X';

                        Console.WriteLine(
                            $"Paris died at {parisIndexes[0]};{parisIndexes[1]}.");
                        break;
                    }
                }

                if (matrix[parisIndexes[0]][parisIndexes[1]] == 'H')
                {
                    matrix[parisIndexes[0]][parisIndexes[1]] = '-';

                    Console.WriteLine(
                    $"Paris has successfully sat on the throne! Energy left: {energyParis}");
                    break;
                }

                if (energyParis <= 0)
                {
                    matrix[parisIndexes[0]][parisIndexes[1]] = 'X';

                    Console.WriteLine(
                        $"Paris died at {parisIndexes[0]};{parisIndexes[1]}.");
                    break;
                }
            }

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

        private static void MoveParis(string command)
        {
            // parisIndexes[0] = row
            // parisIndexes[1] = col
            matrix[parisIndexes[0]][parisIndexes[1]] = '-';

            switch (command)
            {
                case "up":
                    parisIndexes[0] = parisIndexes[0] - 1 < 0 ?
                        0 :
                        parisIndexes[0] - 1;
                    break;
                case "down":
                    parisIndexes[0] = parisIndexes[0] + 1 >= matrix.Length ?
                        matrix.Length - 1 :
                        parisIndexes[0] + 1;
                    break;
                case "left":
                    parisIndexes[1] = parisIndexes[1] - 1 < 0 ?
                        0 :
                        parisIndexes[1] - 1;
                    break;
                case "right":
                    parisIndexes[1] = parisIndexes[1] + 1 >= matrix[parisIndexes[0]].Length ?
                        matrix[parisIndexes[0]].Length - 1 :
                        parisIndexes[1] + 1;
                    break;
            }

            energyParis--;
        }

        private static void MoveSpartanSpawn(
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
                    parisIndexes[0] = row;
                    parisIndexes[1] = Array.IndexOf(matrix[row], 'P');
                }
            }
        }
    }
}
