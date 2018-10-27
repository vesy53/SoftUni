using System;

namespace p06PowerPlants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');

            int length = splitInput.Length;
            int[] plants = new int[length];
            int days = length;

            for (int i = 0; i < length; i++)
            {
                plants[i] = int.Parse(splitInput[i]);
            }

            int allDays = 0;
            int seasons = 0;

            for (int currentDay = 0; currentDay < days; currentDay++)
            {
                for (int i = 0; i < length; i++)
                {
                    if (currentDay != i && plants[i] > 0)
                    {
                        plants[i]--;
                    }
                }
                allDays++;

                if (currentDay + 1 == days)
                {
                    seasons++;
                    currentDay = -1;

                    for (int i = 0; i < length; i++)
                    {
                        if (plants[i] > 0)
                        {
                            plants[i]++;
                        }
                    }
                }

                //Here, we check whether all plants are dead;
                bool areAllPlantsWither = true;
                for (int j = 0; j < length; j++)
                {
                    if (plants[j] != 0)
                    {
                        areAllPlantsWither = false;
                        break;
                    }
                }

                if (areAllPlantsWither)
                {
                    break;
                }
            }

            if (allDays % days == 0)
            {
                seasons--;
            }

            string result = $"survived {allDays} days ({seasons} ";
            if (seasons == 1)
            {
                result += "season)";
            }
            else
            {
                result += "seasons)";
            }
            Console.WriteLine(result);
        }
    }
}
    
    

